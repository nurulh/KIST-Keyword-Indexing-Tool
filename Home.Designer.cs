namespace LoginProject
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.indexButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.examiner = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.ic = new System.Windows.Forms.TextBox();
            this.dUsername = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.changePasswd = new System.Windows.Forms.LinkLabel();
            this.phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.indexFile1 = new LoginProject.IndexFile();
            this.newCase1 = new LoginProject.NewCase();
            this.recentCase1 = new LoginProject.RecentCase();
            this.label11 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // indexButton
            // 
            this.indexButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.indexButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.indexButton.Location = new System.Drawing.Point(21, 251);
            this.indexButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(280, 62);
            this.indexButton.TabIndex = 3;
            this.indexButton.Text = "Index File";
            this.indexButton.UseVisualStyleBackColor = false;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(21, 156);
            this.newButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(280, 62);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New Case File";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.examiner);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.indexButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 732);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F);
            this.button1.Location = new System.Drawing.Point(21, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F);
            this.button2.Location = new System.Drawing.Point(21, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "User Manual";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // examiner
            // 
            this.examiner.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.examiner.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F);
            this.examiner.Location = new System.Drawing.Point(21, 354);
            this.examiner.Name = "examiner";
            this.examiner.Size = new System.Drawing.Size(280, 62);
            this.examiner.TabIndex = 10;
            this.examiner.Text = "User Profile";
            this.examiner.UseVisualStyleBackColor = false;
            this.examiner.Click += new System.EventHandler(this.examiner_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LoginProject.Properties.Resources.logo_uthm;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 99);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.status.Location = new System.Drawing.Point(1075, 350);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(312, 29);
            this.status.TabIndex = 48;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.gender.Location = new System.Drawing.Point(1075, 302);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(312, 29);
            this.gender.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(924, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "Marital Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(923, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 45;
            this.label9.Text = "Gender:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(558, 375);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(325, 75);
            this.address.TabIndex = 44;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.email.Location = new System.Drawing.Point(558, 317);
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(325, 29);
            this.email.TabIndex = 43;
            // 
            // ic
            // 
            this.ic.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.ic.Location = new System.Drawing.Point(558, 483);
            this.ic.Name = "ic";
            this.ic.ReadOnly = true;
            this.ic.Size = new System.Drawing.Size(325, 29);
            this.ic.TabIndex = 42;
            // 
            // dUsername
            // 
            this.dUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.dUsername.Location = new System.Drawing.Point(558, 157);
            this.dUsername.Name = "dUsername";
            this.dUsername.ReadOnly = true;
            this.dUsername.Size = new System.Drawing.Size(325, 29);
            this.dUsername.TabIndex = 41;
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.fullname.Location = new System.Drawing.Point(558, 253);
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Size = new System.Drawing.Size(325, 29);
            this.fullname.TabIndex = 40;
            // 
            // changePasswd
            // 
            this.changePasswd.AutoSize = true;
            this.changePasswd.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.changePasswd.Location = new System.Drawing.Point(556, 210);
            this.changePasswd.Name = "changePasswd";
            this.changePasswd.Size = new System.Drawing.Size(145, 22);
            this.changePasswd.TabIndex = 39;
            this.changePasswd.TabStop = true;
            this.changePasswd.Text = "Change Password";
            this.changePasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePasswd_LinkClicked);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.phone.Location = new System.Drawing.Point(558, 541);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(325, 29);
            this.phone.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "IC/ Passport No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fullname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 51);
            this.label2.TabIndex = 50;
            this.label2.Text = "Welcome,";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.editBtn.Location = new System.Drawing.Point(560, 584);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(323, 43);
            this.editBtn.TabIndex = 51;
            this.editBtn.Text = "Edit Profile";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::LoginProject.Properties.Resources.LOGO_PSM;
            this.pictureBox3.Location = new System.Drawing.Point(1346, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(889, 157);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(38, 29);
            this.okBtn.TabIndex = 53;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // indexFile1
            // 
            this.indexFile1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.indexFile1.Location = new System.Drawing.Point(321, 0);
            this.indexFile1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indexFile1.Name = "indexFile1";
            this.indexFile1.Size = new System.Drawing.Size(1396, 760);
            this.indexFile1.TabIndex = 11;
            // 
            // newCase1
            // 
            this.newCase1.AutoSize = true;
            this.newCase1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newCase1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCase1.Location = new System.Drawing.Point(321, 0);
            this.newCase1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newCase1.Name = "newCase1";
            this.newCase1.Size = new System.Drawing.Size(1396, 813);
            this.newCase1.TabIndex = 7;
            this.newCase1.Load += new System.EventHandler(this.newCase1_Load);
            // 
            // recentCase1
            // 
            this.recentCase1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recentCase1.Location = new System.Drawing.Point(321, 0);
            this.recentCase1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recentCase1.Name = "recentCase1";
            this.recentCase1.Size = new System.Drawing.Size(1396, 760);
            this.recentCase1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(924, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 54;
            this.label11.Text = "D.O.B:";
            // 
            // dob
            // 
            this.dob.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.dob.Location = new System.Drawing.Point(1075, 252);
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Size = new System.Drawing.Size(312, 29);
            this.dob.TabIndex = 55;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1565, 732);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ic);
            this.Controls.Add(this.indexFile1);
            this.Controls.Add(this.newCase1);
            this.Controls.Add(this.dUsername);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.changePasswd);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recentCase1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KIST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private NewCase newCase1;
        private RecentCase recentCase1;
        private System.Windows.Forms.Button examiner;
        private IndexFile indexFile1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox ic;
        private System.Windows.Forms.TextBox dUsername;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.LinkLabel changePasswd;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dob;
    }
}