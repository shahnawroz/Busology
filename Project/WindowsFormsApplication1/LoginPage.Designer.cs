namespace WindowsFormsApplication1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.LoginB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.LoginL = new System.Windows.Forms.Label();
            this.ForgotPWLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(415, 149);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // UNbox
            // 
            this.UNbox.Location = new System.Drawing.Point(489, 104);
            this.UNbox.MaxLength = 6;
            this.UNbox.Name = "UNbox";
            this.UNbox.Size = new System.Drawing.Size(175, 20);
            this.UNbox.TabIndex = 4;
            // 
            // PWbox
            // 
            this.PWbox.Location = new System.Drawing.Point(489, 146);
            this.PWbox.MaxLength = 8;
            this.PWbox.Multiline = true;
            this.PWbox.Name = "PWbox";
            this.PWbox.PasswordChar = '*';
            this.PWbox.Size = new System.Drawing.Size(175, 20);
            this.PWbox.TabIndex = 6;
            this.PWbox.TextChanged += new System.EventHandler(this.PWbox_TextChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(406, 106);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(77, 16);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "User Name";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.ForeColor = System.Drawing.Color.Green;
            this.LoginB.Location = new System.Drawing.Point(589, 226);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(75, 25);
            this.LoginB.TabIndex = 8;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // ExitB
            // 
            this.ExitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitB.ForeColor = System.Drawing.Color.Red;
            this.ExitB.Location = new System.Drawing.Point(489, 226);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(75, 25);
            this.ExitB.TabIndex = 9;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Location = new System.Drawing.Point(504, 290);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(160, 13);
            this.SignUpLink.TabIndex = 10;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Don\'t have an account, Sign Up";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // LoginL
            // 
            this.LoginL.AutoSize = true;
            this.LoginL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginL.Location = new System.Drawing.Point(486, 30);
            this.LoginL.Name = "LoginL";
            this.LoginL.Size = new System.Drawing.Size(101, 37);
            this.LoginL.TabIndex = 11;
            this.LoginL.Text = "Login";
            // 
            // ForgotPWLink
            // 
            this.ForgotPWLink.AutoSize = true;
            this.ForgotPWLink.Location = new System.Drawing.Point(489, 175);
            this.ForgotPWLink.Name = "ForgotPWLink";
            this.ForgotPWLink.Size = new System.Drawing.Size(86, 13);
            this.ForgotPWLink.TabIndex = 12;
            this.ForgotPWLink.TabStop = true;
            this.ForgotPWLink.Text = "Forgot Password";
            this.ForgotPWLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPWLink_LinkClicked);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(695, 349);
            this.Controls.Add(this.ForgotPWLink);
            this.Controls.Add(this.LoginL);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label LoginL;
        private System.Windows.Forms.LinkLabel ForgotPWLink;
    }
}

