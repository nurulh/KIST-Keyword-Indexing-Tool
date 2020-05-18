namespace LoginProject
{
    partial class rapeUpdate
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
            this.updatebttn = new System.Windows.Forms.Button();
            this.NRkeyword = new System.Windows.Forms.TextBox();
            this.Rkeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updatebttn
            // 
            this.updatebttn.Location = new System.Drawing.Point(288, 156);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(91, 30);
            this.updatebttn.TabIndex = 14;
            this.updatebttn.Text = "Update";
            this.updatebttn.UseVisualStyleBackColor = true;
            this.updatebttn.Click += new System.EventHandler(this.updatebttn_Click);
            // 
            // NRkeyword
            // 
            this.NRkeyword.Location = new System.Drawing.Point(49, 160);
            this.NRkeyword.Name = "NRkeyword";
            this.NRkeyword.Size = new System.Drawing.Size(206, 22);
            this.NRkeyword.TabIndex = 13;
            // 
            // Rkeyword
            // 
            this.Rkeyword.Location = new System.Drawing.Point(48, 79);
            this.Rkeyword.Name = "Rkeyword";
            this.Rkeyword.Size = new System.Drawing.Size(206, 22);
            this.Rkeyword.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Keyword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Keyword:";
            // 
            // rapeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 234);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.NRkeyword);
            this.Controls.Add(this.Rkeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rapeUpdate";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.TextBox NRkeyword;
        private System.Windows.Forms.TextBox Rkeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}