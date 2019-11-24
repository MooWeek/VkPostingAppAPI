using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using xNet;

namespace VkPostingAppAPI
{
    public partial class Form1 : Form
    {
        AuthForms af = new AuthForms();
        public Form1()
        {
            InitializeComponent();
        }

        private string SendRequest(string url)
        {
            string sourceResponce;
            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    sourceResponce = reader.ReadToEnd();
                    return sourceResponce;
                }
            }
        }


        private void button1_send_Click_1(object sender, EventArgs e)
        {
            string groupId = af.GetGroupId;
            string message = richTextBox1.Text;
            string userToken = af.GetUserToken;
            string userId = af.GetUserId;

            string postPhotoUrl = "https://api.vk.com/method/photos.getWallUploadServer?group_id=" + groupId + "&access_token=" + userToken + "&v=5.103";
            string postPhotoRespond = SendRequest(postPhotoUrl);
            string uriSend = postPhotoRespond.Substring(postPhotoRespond.IndexOf("http"));
            uriSend = uriSend.Substring(0, uriSend.IndexOf("user_id") - 3);
            while (uriSend.IndexOf("\\/") != -1)
            {
                uriSend = uriSend.Remove(uriSend.IndexOf("\\/"), 1);
            }

            HttpRequest req = new HttpRequest();

            req.AddFile("photo", @pictureBox1.ImageLocation);

            HttpResponse response = req.Post(uriSend);

            richTextBox2_debug.Text = Convert.ToString(response);

            string s = richTextBox2_debug.Text;

            while (s.IndexOf("\\\"") != -1)
            {
                s = s.Remove(s.IndexOf("\\\""), 1);
            }

            string server = s.Substring(s.IndexOf("server") + 8);
            server = server.Remove(server.IndexOf(",\"photo\":\""));

            string photo = s.Substring(s.IndexOf(",\"photo\":\"") + 10);
            photo = photo.Remove(photo.IndexOf("\",\"hash"));

            string hash = s.Substring(s.IndexOf("\",\"hash\":\"") + 10);
            hash = hash.Remove(hash.IndexOf("\"}"));


            string reqUrl = "https://api.vk.com/method/photos.saveWallPhoto?group_id=" + groupId + "&user_id" + userId + "&photo=" + photo + "&server=" + server + "&hash=" + hash + "&access_token=" + userToken + "&v=5.103";
            string saveResp = SendRequest(reqUrl);

            string photoId = saveResp.Substring(saveResp.IndexOf(":[{\"id\":") + 8);
            photoId = photoId.Remove(photoId.IndexOf(",\"album_id"));

            string ownerId = saveResp.Substring(saveResp.IndexOf("owner_id") + 10);
            ownerId = ownerId.Remove(ownerId.IndexOf(",\"sizes\":[{"));

            string urlWallpost = "https://api.vk.com/method/wall.post?owner_id=-" + groupId + "&message=" + message + "&attachments=photo" + ownerId + "_" + photoId + "&access_token=" + userToken + "&v=5.103";
            string warrPostResp = SendRequest(urlWallpost);
            if (warrPostResp.IndexOf("post_id") != -1)
                MessageBox.Show("Posted");
            else
                MessageBox.Show("Error");
        }

        private void button1_choose_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Файлы jpeg|*.jpg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = OFD.FileName;
                MessageBox.Show(OFD.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            af.Show();
        }



    }
}
