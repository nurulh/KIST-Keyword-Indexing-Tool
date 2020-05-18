namespace LoginProject
{
    partial class EvidenceProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidenceProcess));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caseid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.examinername = new System.Windows.Forms.TextBox();
            this.casenm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label1.Location = new System.Drawing.Point(44, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Examiner Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caseid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.savebtn);
            this.groupBox1.Controls.Add(this.examinername);
            this.groupBox1.Controls.Add(this.casenm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 398);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Case Details";
            // 
            // caseid
            // 
            this.caseid.Location = new System.Drawing.Point(197, 38);
            this.caseid.Name = "caseid";
            this.caseid.Size = new System.Drawing.Size(334, 27);
            this.caseid.TabIndex = 20;
            this.caseid.Leave += new System.EventHandler(this.caseid_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label5.Location = new System.Drawing.Point(44, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Case ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(197, 200);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(334, 130);
            this.desc.TabIndex = 18;
            this.desc.Text = "";
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(431, 336);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 30);
            this.savebtn.TabIndex = 16;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // examinername
            // 
            this.examinername.Location = new System.Drawing.Point(197, 86);
            this.examinername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.examinername.Name = "examinername";
            this.examinername.Size = new System.Drawing.Size(334, 27);
            this.examinername.TabIndex = 8;
            // 
            // casenm
            // 
            this.casenm.Location = new System.Drawing.Point(197, 137);
            this.casenm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.casenm.Name = "casenm";
            this.casenm.Size = new System.Drawing.Size(334, 27);
            this.casenm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label3.Location = new System.Drawing.Point(44, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Case Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label2.Location = new System.Drawing.Point(44, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EvidenceProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 438);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvidenceProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Case Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox examinername;
        private System.Windows.Forms.TextBox casenm;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.RichTextBox desc;
        private System.Windows.Forms.TextBox caseid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}