namespace LoginProject
{
    partial class IndexFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.keywordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mysqlcsharpDataSet = new LoginProject.mysqlcsharpDataSet();
            this.keywordTableAdapter = new LoginProject.mysqlcsharpDataSetTableAdapters.keywordTableAdapter();
            this.keywordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.drugBtn = new System.Windows.Forms.Button();
            this.pornBtn = new System.Windows.Forms.Button();
            this.murderBtn = new System.Windows.Forms.Button();
            this.rapeBtn = new System.Windows.Forms.Button();
            this.cyberBtn = new System.Windows.Forms.Button();
            this.bribeBtn = new System.Windows.Forms.Button();
            this.pedoBtn = new System.Windows.Forms.Button();
            this.assaultBtn = new System.Windows.Forms.Button();
            this.fraudBtn = new System.Windows.Forms.Button();
            this.harassBtn = new System.Windows.Forms.Button();
            this.trafficBtn = new System.Windows.Forms.Button();
            this.hateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // keywordBindingSource
            // 
            this.keywordBindingSource.DataMember = "keyword";
            this.keywordBindingSource.DataSource = this.mysqlcsharpDataSet;
            // 
            // mysqlcsharpDataSet
            // 
            this.mysqlcsharpDataSet.DataSetName = "mysqlcsharpDataSet";
            this.mysqlcsharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keywordTableAdapter
            // 
            this.keywordTableAdapter.ClearBeforeFill = true;
            // 
            // keywordBindingSource1
            // 
            this.keywordBindingSource1.DataMember = "keyword";
            this.keywordBindingSource1.DataSource = this.mysqlcsharpDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // drugBtn
            // 
            this.drugBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugBtn.Location = new System.Drawing.Point(744, 195);
            this.drugBtn.Name = "drugBtn";
            this.drugBtn.Size = new System.Drawing.Size(144, 48);
            this.drugBtn.TabIndex = 1;
            this.drugBtn.Text = "Drug";
            this.drugBtn.UseVisualStyleBackColor = true;
            this.drugBtn.Click += new System.EventHandler(this.drugBtn_Click);
            // 
            // pornBtn
            // 
            this.pornBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pornBtn.Location = new System.Drawing.Point(572, 292);
            this.pornBtn.Name = "pornBtn";
            this.pornBtn.Size = new System.Drawing.Size(144, 48);
            this.pornBtn.TabIndex = 2;
            this.pornBtn.Text = "Pornography";
            this.pornBtn.UseVisualStyleBackColor = true;
            this.pornBtn.Click += new System.EventHandler(this.pornBtn_Click);
            // 
            // murderBtn
            // 
            this.murderBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.murderBtn.Location = new System.Drawing.Point(219, 292);
            this.murderBtn.Name = "murderBtn";
            this.murderBtn.Size = new System.Drawing.Size(144, 48);
            this.murderBtn.TabIndex = 4;
            this.murderBtn.Text = "Murder";
            this.murderBtn.UseVisualStyleBackColor = true;
            this.murderBtn.Click += new System.EventHandler(this.murderBtn_Click);
            // 
            // rapeBtn
            // 
            this.rapeBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapeBtn.Location = new System.Drawing.Point(744, 292);
            this.rapeBtn.Name = "rapeBtn";
            this.rapeBtn.Size = new System.Drawing.Size(144, 48);
            this.rapeBtn.TabIndex = 5;
            this.rapeBtn.Text = "Rape";
            this.rapeBtn.UseVisualStyleBackColor = true;
            this.rapeBtn.Click += new System.EventHandler(this.rapeBtn_Click);
            // 
            // cyberBtn
            // 
            this.cyberBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cyberBtn.Location = new System.Drawing.Point(572, 195);
            this.cyberBtn.Name = "cyberBtn";
            this.cyberBtn.Size = new System.Drawing.Size(144, 48);
            this.cyberBtn.TabIndex = 6;
            this.cyberBtn.Text = "Cyber Crime";
            this.cyberBtn.UseVisualStyleBackColor = true;
            this.cyberBtn.Click += new System.EventHandler(this.cyberBtn_Click);
            // 
            // bribeBtn
            // 
            this.bribeBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.bribeBtn.Location = new System.Drawing.Point(395, 195);
            this.bribeBtn.Name = "bribeBtn";
            this.bribeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bribeBtn.Size = new System.Drawing.Size(144, 48);
            this.bribeBtn.TabIndex = 7;
            this.bribeBtn.Text = "Bribery";
            this.bribeBtn.UseVisualStyleBackColor = true;
            this.bribeBtn.Click += new System.EventHandler(this.bribeBtn_Click);
            // 
            // pedoBtn
            // 
            this.pedoBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedoBtn.Location = new System.Drawing.Point(395, 292);
            this.pedoBtn.Name = "pedoBtn";
            this.pedoBtn.Size = new System.Drawing.Size(144, 48);
            this.pedoBtn.TabIndex = 8;
            this.pedoBtn.Text = "Pedophile";
            this.pedoBtn.UseVisualStyleBackColor = true;
            this.pedoBtn.Click += new System.EventHandler(this.pedoBtn_Click);
            // 
            // assaultBtn
            // 
            this.assaultBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assaultBtn.Location = new System.Drawing.Point(219, 195);
            this.assaultBtn.Name = "assaultBtn";
            this.assaultBtn.Size = new System.Drawing.Size(144, 48);
            this.assaultBtn.TabIndex = 9;
            this.assaultBtn.Text = "Assault";
            this.assaultBtn.UseVisualStyleBackColor = true;
            this.assaultBtn.Click += new System.EventHandler(this.assaultBtn_Click);
            // 
            // fraudBtn
            // 
            this.fraudBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.fraudBtn.Location = new System.Drawing.Point(219, 396);
            this.fraudBtn.Name = "fraudBtn";
            this.fraudBtn.Size = new System.Drawing.Size(144, 48);
            this.fraudBtn.TabIndex = 10;
            this.fraudBtn.Text = "Fraud";
            this.fraudBtn.UseVisualStyleBackColor = true;
            this.fraudBtn.Click += new System.EventHandler(this.fraudBtn_Click);
            // 
            // harassBtn
            // 
            this.harassBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.harassBtn.Location = new System.Drawing.Point(395, 396);
            this.harassBtn.Name = "harassBtn";
            this.harassBtn.Size = new System.Drawing.Size(144, 48);
            this.harassBtn.TabIndex = 11;
            this.harassBtn.Text = "Harassment";
            this.harassBtn.UseVisualStyleBackColor = true;
            this.harassBtn.Click += new System.EventHandler(this.harassBtn_Click);
            // 
            // trafficBtn
            // 
            this.trafficBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.trafficBtn.Location = new System.Drawing.Point(572, 396);
            this.trafficBtn.Name = "trafficBtn";
            this.trafficBtn.Size = new System.Drawing.Size(144, 48);
            this.trafficBtn.TabIndex = 12;
            this.trafficBtn.Text = "Trafficking";
            this.trafficBtn.UseVisualStyleBackColor = true;
            this.trafficBtn.Click += new System.EventHandler(this.trafficBtn_Click);
            // 
            // hateBtn
            // 
            this.hateBtn.Font = new System.Drawing.Font("Arial", 10.8F);
            this.hateBtn.Location = new System.Drawing.Point(744, 396);
            this.hateBtn.Name = "hateBtn";
            this.hateBtn.Size = new System.Drawing.Size(144, 48);
            this.hateBtn.TabIndex = 13;
            this.hateBtn.Text = "Hate";
            this.hateBtn.UseVisualStyleBackColor = true;
            this.hateBtn.Click += new System.EventHandler(this.hateBtn_Click);
            // 
            // IndexFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hateBtn);
            this.Controls.Add(this.trafficBtn);
            this.Controls.Add(this.harassBtn);
            this.Controls.Add(this.fraudBtn);
            this.Controls.Add(this.assaultBtn);
            this.Controls.Add(this.pedoBtn);
            this.Controls.Add(this.bribeBtn);
            this.Controls.Add(this.cyberBtn);
            this.Controls.Add(this.rapeBtn);
            this.Controls.Add(this.murderBtn);
            this.Controls.Add(this.pornBtn);
            this.Controls.Add(this.drugBtn);
            this.Controls.Add(this.label1);
            this.Name = "IndexFile";
            this.Size = new System.Drawing.Size(1201, 837);
            this.Load += new System.EventHandler(this.IndexFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource keywordBindingSource;
        private mysqlcsharpDataSet mysqlcsharpDataSet;
        private mysqlcsharpDataSetTableAdapters.keywordTableAdapter keywordTableAdapter;
        private System.Windows.Forms.BindingSource keywordBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drugBtn;
        private System.Windows.Forms.Button pornBtn;
        private System.Windows.Forms.Button murderBtn;
        private System.Windows.Forms.Button rapeBtn;
        private System.Windows.Forms.Button cyberBtn;
        private System.Windows.Forms.Button bribeBtn;
        private System.Windows.Forms.Button pedoBtn;
        private System.Windows.Forms.Button assaultBtn;
        private System.Windows.Forms.Button harassBtn;
        private System.Windows.Forms.Button trafficBtn;
        private System.Windows.Forms.Button hateBtn;
        private System.Windows.Forms.Button fraudBtn;
    }
}
