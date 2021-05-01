namespace WindowsFormsApplication1
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.FromL = new System.Windows.Forms.Label();
            this.ToL = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.JourneyDtL = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.Hmpage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FromCMbox = new System.Windows.Forms.ComboBox();
            this.ToCMbox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromL
            // 
            this.FromL.AutoSize = true;
            this.FromL.Location = new System.Drawing.Point(355, 84);
            this.FromL.Name = "FromL";
            this.FromL.Size = new System.Drawing.Size(30, 13);
            this.FromL.TabIndex = 0;
            this.FromL.Text = "From";
            // 
            // ToL
            // 
            this.ToL.AutoSize = true;
            this.ToL.Location = new System.Drawing.Point(355, 146);
            this.ToL.Name = "ToL";
            this.ToL.Size = new System.Drawing.Size(20, 13);
            this.ToL.TabIndex = 1;
            this.ToL.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // JourneyDtL
            // 
            this.JourneyDtL.AutoSize = true;
            this.JourneyDtL.Location = new System.Drawing.Point(355, 211);
            this.JourneyDtL.Name = "JourneyDtL";
            this.JourneyDtL.Size = new System.Drawing.Size(70, 13);
            this.JourneyDtL.TabIndex = 5;
            this.JourneyDtL.Text = "Journey Date";
            // 
            // searchB
            // 
            this.searchB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.searchB.Location = new System.Drawing.Point(483, 288);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(75, 23);
            this.searchB.TabIndex = 6;
            this.searchB.Text = "Search";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitB.ForeColor = System.Drawing.Color.Crimson;
            this.ExitB.Location = new System.Drawing.Point(358, 288);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(75, 23);
            this.ExitB.TabIndex = 7;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // Hmpage
            // 
            this.Hmpage.AutoSize = true;
            this.Hmpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hmpage.ForeColor = System.Drawing.Color.ForestGreen;
            this.Hmpage.Location = new System.Drawing.Point(353, 28);
            this.Hmpage.Name = "Hmpage";
            this.Hmpage.Size = new System.Drawing.Size(150, 29);
            this.Hmpage.TabIndex = 8;
            this.Hmpage.Text = "Home Page";
            this.Hmpage.Click += new System.EventHandler(this.Hmpage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FromCMbox
            // 
            this.FromCMbox.FormattingEnabled = true;
            this.FromCMbox.Items.AddRange(new object[] {
            "Bogra",
            "Rajshahi",
            "Dhaka"});
            this.FromCMbox.Location = new System.Drawing.Point(358, 112);
            this.FromCMbox.Name = "FromCMbox";
            this.FromCMbox.Size = new System.Drawing.Size(200, 21);
            this.FromCMbox.TabIndex = 10;
            // 
            // ToCMbox
            // 
            this.ToCMbox.FormattingEnabled = true;
            this.ToCMbox.Items.AddRange(new object[] {
            "Bogra",
            "Rajshahi",
            "Dhaka"});
            this.ToCMbox.Location = new System.Drawing.Point(358, 171);
            this.ToCMbox.Name = "ToCMbox";
            this.ToCMbox.Size = new System.Drawing.Size(200, 21);
            this.ToCMbox.TabIndex = 11;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(599, 339);
            this.Controls.Add(this.ToCMbox);
            this.Controls.Add(this.FromCMbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hmpage);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.JourneyDtL);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ToL);
            this.Controls.Add(this.FromL);
            this.Name = "Homepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromL;
        private System.Windows.Forms.Label ToL;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label JourneyDtL;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Label Hmpage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox FromCMbox;
        private System.Windows.Forms.ComboBox ToCMbox;

    }
}