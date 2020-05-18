namespace LoginProject
{
    partial class DrugForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mysqlcsharpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mysqlcsharpDataSet = new LoginProject.mysqlcsharpDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Dkeyword = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.keywordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keywordTableAdapter = new LoginProject.mysqlcsharpDataSetTableAdapters.keywordTableAdapter();
            this.checkboxx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.drugFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxx});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(288, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(307, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mysqlcsharpDataSetBindingSource
            // 
            this.mysqlcsharpDataSetBindingSource.DataSource = this.mysqlcsharpDataSet;
            this.mysqlcsharpDataSetBindingSource.Position = 0;
            // 
            // mysqlcsharpDataSet
            // 
            this.mysqlcsharpDataSet.DataSetName = "mysqlcsharpDataSet";
            this.mysqlcsharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyword:";
            // 
            // Dkeyword
            // 
            this.Dkeyword.Location = new System.Drawing.Point(37, 56);
            this.Dkeyword.Name = "Dkeyword";
            this.Dkeyword.Size = new System.Drawing.Size(212, 22);
            this.Dkeyword.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(37, 104);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 33);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Arial", 10.2F);
            this.updateBtn.Location = new System.Drawing.Point(37, 176);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(118, 33);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnLoad.Location = new System.Drawing.Point(37, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 33);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 10.2F);
            this.deleteBtn.Location = new System.Drawing.Point(37, 255);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(118, 33);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // keywordBindingSource
            // 
            this.keywordBindingSource.DataMember = "keyword";
            this.keywordBindingSource.DataSource = this.mysqlcsharpDataSet;
            // 
            // keywordTableAdapter
            // 
            this.keywordTableAdapter.ClearBeforeFill = true;
            // 
            // checkboxx
            // 
            this.checkboxx.HeaderText = "";
            this.checkboxx.Name = "checkboxx";
            this.checkboxx.ReadOnly = true;
            this.checkboxx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkboxx.Visible = false;
            // 
            // drugFormBindingSource
            // 
            this.drugFormBindingSource.DataSource = typeof(LoginProject.DrugForm);
            // 
            // DrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.Dkeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Form";
            this.Load += new System.EventHandler(this.DrugForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlcsharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dkeyword;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource mysqlcsharpDataSetBindingSource;
        private mysqlcsharpDataSet mysqlcsharpDataSet;
        private System.Windows.Forms.BindingSource keywordBindingSource;
        private mysqlcsharpDataSetTableAdapters.keywordTableAdapter keywordTableAdapter;
        private System.Windows.Forms.BindingSource drugFormBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxx;
        //private System.Windows.Forms.Button btnLoad;
    }
}