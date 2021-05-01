namespace WindowsFormsApplication1
{
    partial class NewPWpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPWpage));
            this.ConfirmPwL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RecoverPwL = new System.Windows.Forms.Label();
            this.ConfirmPwB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.NewPwL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmPwL
            // 
            this.ConfirmPwL.AutoSize = true;
            this.ConfirmPwL.Location = new System.Drawing.Point(294, 129);
            this.ConfirmPwL.Name = "ConfirmPwL";
            this.ConfirmPwL.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPwL.TabIndex = 1;
            this.ConfirmPwL.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 94);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 126);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RecoverPwL
            // 
            this.RecoverPwL.AutoSize = true;
            this.RecoverPwL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverPwL.ForeColor = System.Drawing.Color.Teal;
            this.RecoverPwL.Location = new System.Drawing.Point(291, 32);
            this.RecoverPwL.Name = "RecoverPwL";
            this.RecoverPwL.Size = new System.Drawing.Size(244, 29);
            this.RecoverPwL.TabIndex = 5;
            this.RecoverPwL.Text = "Password Recovery";
            // 
            // ConfirmPwB
            // 
            this.ConfirmPwB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConfirmPwB.ForeColor = System.Drawing.Color.Green;
            this.ConfirmPwB.Location = new System.Drawing.Point(504, 182);
            this.ConfirmPwB.Name = "ConfirmPwB";
            this.ConfirmPwB.Size = new System.Drawing.Size(75, 23);
            this.ConfirmPwB.TabIndex = 6;
            this.ConfirmPwB.Text = "Confirm";
            this.ConfirmPwB.UseVisualStyleBackColor = false;
            this.ConfirmPwB.Click += new System.EventHandler(this.ConfirmPwB_Click);
            // 
            // CancelB
            // 
            this.CancelB.ForeColor = System.Drawing.Color.Crimson;
            this.CancelB.Location = new System.Drawing.Point(405, 182);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 7;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = true;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // NewPwL
            // 
            this.NewPwL.AutoSize = true;
            this.NewPwL.Location = new System.Drawing.Point(294, 97);
            this.NewPwL.Name = "NewPwL";
            this.NewPwL.Size = new System.Drawing.Size(78, 13);
            this.NewPwL.TabIndex = 8;
            this.NewPwL.Text = "New Password";
            // 
            // NewPWpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(623, 261);
            this.Controls.Add(this.NewPwL);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.ConfirmPwB);
            this.Controls.Add(this.RecoverPwL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConfirmPwL);
            this.Name = "NewPWpage";
            this.Text = "NewPWpage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConfirmPwL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RecoverPwL;
        private System.Windows.Forms.Button ConfirmPwB;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Label NewPwL;
    }
}