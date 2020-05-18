namespace LoginProject
{
    partial class UpdateFraud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFraud));
            this.updatebttn = new System.Windows.Forms.Button();
            this.NFKeyword = new System.Windows.Forms.TextBox();
            this.FKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updatebttn
            // 
            this.updatebttn.Location = new System.Drawing.Point(288, 156);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(91, 30);
            this.updatebttn.TabIndex = 19;
            this.updatebttn.Text = "Update";
            this.updatebttn.UseVisualStyleBackColor = true;
            this.updatebttn.Click += new System.EventHandler(this.updatebttn_Click);
            // 
            // NFKeyword
            // 
            this.NFKeyword.Location = new System.Drawing.Point(49, 160);
            this.NFKeyword.Name = "NFKeyword";
            this.NFKeyword.Size = new System.Drawing.Size(206, 22);
            this.NFKeyword.TabIndex = 18;
            // 
            // FKeyword
            // 
            this.FKeyword.Location = new System.Drawing.Point(48, 79);
            this.FKeyword.Name = "FKeyword";
            this.FKeyword.Size = new System.Drawing.Size(206, 22);
            this.FKeyword.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "New Keyword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Keyword:";
            // 
            // UpdateFraud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 234);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.NFKeyword);
            this.Controls.Add(this.FKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateFraud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateFraud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.TextBox NFKeyword;
        private System.Windows.Forms.TextBox FKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}