using System;
using System.Windows.Forms;

namespace VkPostingAppAPI
{
    public partial class AuthForms : Form
    {
        string userToken;
        string userId;
        string groupId;
        public AuthForms()
        {
            InitializeComponent();
        }


        private void button1_Auth_Click(object sender, EventArgs e)
        {
            string url = "https://oauth.vk.com/authorize?client_id=7219063&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=manage,photos,groups,wall,offline&response_type=token&v=5.103";

            webBrowser1.Navigate(url);
        }

        private void button1_GetUserToken_Click_1(object sender, EventArgs e)
        {
            string fullUrl = webBrowser1.Url.ToString();

            userToken = fullUrl.Split('=')[1].Split('&')[0];
            userId = fullUrl.Split('=')[3];

            string groupUrl = textBox2_url.Text;
            groupId = groupUrl.Substring(groupUrl.IndexOf("wall")).Split('-')[1].Split('_')[0];
            MessageBox.Show("Got");
        }

        public string GetUserToken
        {
            get
            {
                return userToken;
            }
        }

        public string GetUserId
        {
            get
            {
                return userId;
            }
        }

        public string GetGroupId
        {
            get
            {
                return groupId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AuthForms_Load(object sender, EventArgs e)
        {

        }


    }
}
