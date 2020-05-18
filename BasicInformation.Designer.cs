namespace LoginProject
{
    partial class BasicInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicInformation));
            this.Email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.singleBtn = new System.Windows.Forms.RadioButton();
            this.marriedBtn = new System.Windows.Forms.RadioButton();
            this.otherBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(213, 163);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(295, 22);
            this.Email.TabIndex = 37;
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(213, 239);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(295, 22);
            this.phone.TabIndex = 36;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(213, 125);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(295, 22);
            this.Fname.TabIndex = 34;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(209, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 19);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            // 
            // ic
            // 
            this.ic.Location = new System.Drawing.Point(213, 202);
            this.ic.Name = "ic";
            this.ic.Size = new System.Drawing.Size(295, 22);
            this.ic.TabIndex = 32;
            this.ic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ic_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label8.Location = new System.Drawing.Point(71, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label7.Location = new System.Drawing.Point(71, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label6.Location = new System.Drawing.Point(71, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label4.Location = new System.Drawing.Point(71, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label3.Location = new System.Drawing.Point(71, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "IC/ Passport No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label1.Location = new System.Drawing.Point(71, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fullname:";
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.savebtn.Location = new System.Drawing.Point(390, 547);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(118, 33);
            this.savebtn.TabIndex = 52;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.button1.Location = new System.Drawing.Point(213, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 53;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(213, 457);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(295, 82);
            this.address.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Username:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(213, 40);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(295, 22);
            this.username.TabIndex = 55;
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label5.Location = new System.Drawing.Point(71, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "Marital Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label10.Location = new System.Drawing.Point(72, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 61;
            this.label10.Text = "D.O.B";
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.maleBtn.Location = new System.Drawing.Point(213, 348);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(63, 23);
            this.maleBtn.TabIndex = 62;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.femaleBtn.Location = new System.Drawing.Point(312, 349);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(78, 23);
            this.femaleBtn.TabIndex = 63;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // singleBtn
            // 
            this.singleBtn.AutoSize = true;
            this.singleBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.singleBtn.Location = new System.Drawing.Point(213, 397);
            this.singleBtn.Name = "singleBtn";
            this.singleBtn.Size = new System.Drawing.Size(71, 23);
            this.singleBtn.TabIndex = 64;
            this.singleBtn.TabStop = true;
            this.singleBtn.Text = "Single";
            this.singleBtn.UseVisualStyleBackColor = true;
            // 
            // marriedBtn
            // 
            this.marriedBtn.AutoSize = true;
            this.marriedBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.marriedBtn.Location = new System.Drawing.Point(312, 396);
            this.marriedBtn.Name = "marriedBtn";
            this.marriedBtn.Size = new System.Drawing.Size(82, 23);
            this.marriedBtn.TabIndex = 65;
            this.marriedBtn.TabStop = true;
            this.marriedBtn.Text = "Married";
            this.marriedBtn.UseVisualStyleBackColor = true;
            // 
            // otherBtn
            // 
            this.otherBtn.AutoSize = true;
            this.otherBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.otherBtn.Location = new System.Drawing.Point(415, 396);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.Size = new System.Drawing.Size(67, 23);
            this.otherBtn.TabIndex = 66;
            this.otherBtn.TabStop = true;
            this.otherBtn.Text = "Other";
            this.otherBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // BasicInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.otherBtn);
            this.Controls.Add(this.marriedBtn);
            this.Controls.Add(this.singleBtn);
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Basic Information";
            this.Load += new System.EventHandler(this.BasicInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox ic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton otherBtn;
        private System.Windows.Forms.RadioButton marriedBtn;
        private System.Windows.Forms.RadioButton singleBtn;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.Label label10;
    }
}