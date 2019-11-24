namespace VkPostingAppAPI
{
    partial class Form1
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
            this.richTextBox2_debug = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button1_choose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1_send = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2_debug
            // 
            this.richTextBox2_debug.Location = new System.Drawing.Point(283, 391);
            this.richTextBox2_debug.Name = "richTextBox2_debug";
            this.richTextBox2_debug.ReadOnly = true;
            this.richTextBox2_debug.Size = new System.Drawing.Size(383, 27);
            this.richTextBox2_debug.TabIndex = 19;
            this.richTextBox2_debug.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 115);
            this.button1.TabIndex = 18;
            this.button1.Text = "Authorize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1_choose
            // 
            this.button1_choose.Location = new System.Drawing.Point(672, 330);
            this.button1_choose.Name = "button1_choose";
            this.button1_choose.Size = new System.Drawing.Size(343, 88);
            this.button1_choose.TabIndex = 17;
            this.button1_choose.Text = "Choose Picture";
            this.button1_choose.UseVisualStyleBackColor = true;
            this.button1_choose.Click += new System.EventHandler(this.button1_choose_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(671, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1_send
            // 
            this.button1_send.Location = new System.Drawing.Point(10, 285);
            this.button1_send.Name = "button1_send";
            this.button1_send.Size = new System.Drawing.Size(226, 133);
            this.button1_send.TabIndex = 15;
            this.button1_send.Text = "Send";
            this.button1_send.UseVisualStyleBackColor = true;
            this.button1_send.Click += new System.EventHandler(this.button1_send_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(283, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 373);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 433);
            this.Controls.Add(this.richTextBox2_debug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_choose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1_send);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2_debug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1_choose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1_send;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

