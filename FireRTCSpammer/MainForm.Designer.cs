namespace FireRTCSpammer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chk_Terms = new System.Windows.Forms.CheckBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.btn_StartSpamming = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Terms
            // 
            this.chk_Terms.AutoSize = true;
            this.chk_Terms.Location = new System.Drawing.Point(45, 339);
            this.chk_Terms.Name = "chk_Terms";
            this.chk_Terms.Size = new System.Drawing.Size(158, 95);
            this.chk_Terms.TabIndex = 15;
            this.chk_Terms.Text = "I agree not to spam anyone \r\nwithout their prior consent\r\nusing this software. I " +
    "also\r\nagree that the author is\r\nnot responsible if my\r\nFireRTC account is banned" +
    "\r\nas a result of this program.";
            this.chk_Terms.UseVisualStyleBackColor = true;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(45, 310);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(195, 20);
            this.txt_Time.TabIndex = 14;
            this.txt_Time.Text = "Time Between Calls (in milliseconds)";
            // 
            // btn_StartSpamming
            // 
            this.btn_StartSpamming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartSpamming.Location = new System.Drawing.Point(45, 448);
            this.btn_StartSpamming.Name = "btn_StartSpamming";
            this.btn_StartSpamming.Size = new System.Drawing.Size(195, 77);
            this.btn_StartSpamming.TabIndex = 16;
            this.btn_StartSpamming.Text = "START SPAMMING";
            this.btn_StartSpamming.UseVisualStyleBackColor = true;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(45, 284);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(195, 20);
            this.txt_Phone.TabIndex = 13;
            this.txt_Phone.Text = "Phone Number to Spam";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(45, 258);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(195, 20);
            this.txt_Password.TabIndex = 12;
            this.txt_Password.Text = "Password";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(45, 232);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(195, 20);
            this.txt_Username.TabIndex = 11;
            this.txt_Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "SPAMMER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 533);
            this.Controls.Add(this.chk_Terms);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.btn_StartSpamming);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Spammer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Terms;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.Button btn_StartSpamming;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}