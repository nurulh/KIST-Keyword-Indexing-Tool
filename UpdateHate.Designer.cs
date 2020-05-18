namespace LoginProject
{
    partial class UpdateHate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateHate));
            this.updatebttn = new System.Windows.Forms.Button();
            this.NHateKwrd = new System.Windows.Forms.TextBox();
            this.HateKwrd = new System.Windows.Forms.TextBox();
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
            // NHateKwrd
            // 
            this.NHateKwrd.Location = new System.Drawing.Point(49, 160);
            this.NHateKwrd.Name = "NHateKwrd";
            this.NHateKwrd.Size = new System.Drawing.Size(206, 22);
            this.NHateKwrd.TabIndex = 18;
            // 
            // HateKwrd
            // 
            this.HateKwrd.Location = new System.Drawing.Point(48, 79);
            this.HateKwrd.Name = "HateKwrd";
            this.HateKwrd.Size = new System.Drawing.Size(206, 22);
            this.HateKwrd.TabIndex = 17;
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
            // UpdateHate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 234);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.NHateKwrd);
            this.Controls.Add(this.HateKwrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateHate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateHate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.TextBox NHateKwrd;
        private System.Windows.Forms.TextBox HateKwrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}