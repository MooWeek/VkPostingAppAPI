namespace VkPostingAppAPI
{
    partial class AuthForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button1_GetUserToken = new System.Windows.Forms.Button();
            this.button1_Auth = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Post In Group(Url):";
            // 
            // textBox2_url
            // 
            this.textBox2_url.AcceptsReturn = true;
            this.textBox2_url.Location = new System.Drawing.Point(279, 491);
            this.textBox2_url.Name = "textBox2_url";
            this.textBox2_url.Size = new System.Drawing.Size(410, 26);
            this.textBox2_url.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 68);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1_GetUserToken
            // 
            this.button1_GetUserToken.Location = new System.Drawing.Point(248, 543);
            this.button1_GetUserToken.Name = "button1_GetUserToken";
            this.button1_GetUserToken.Size = new System.Drawing.Size(213, 68);
            this.button1_GetUserToken.TabIndex = 14;
            this.button1_GetUserToken.Text = "Get User Token";
            this.button1_GetUserToken.UseVisualStyleBackColor = true;
            this.button1_GetUserToken.Click += new System.EventHandler(this.button1_GetUserToken_Click_1);
            // 
            // button1_Auth
            // 
            this.button1_Auth.Location = new System.Drawing.Point(12, 543);
            this.button1_Auth.Name = "button1_Auth";
            this.button1_Auth.Size = new System.Drawing.Size(213, 68);
            this.button1_Auth.TabIndex = 13;
            this.button1_Auth.Text = "Authorize";
            this.button1_Auth.UseVisualStyleBackColor = true;
            this.button1_Auth.Click += new System.EventHandler(this.button1_Auth_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1166, 623);
            this.webBrowser1.TabIndex = 12;
            // 
            // AuthForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_url);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_GetUserToken);
            this.Controls.Add(this.button1_Auth);
            this.Controls.Add(this.webBrowser1);
            this.Name = "AuthForms";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1_GetUserToken;
        private System.Windows.Forms.Button button1_Auth;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}