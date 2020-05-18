using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginProject
{
    public partial class PornForm : Form
    {
        public PornForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)                                                                      //SAVE BUTTON
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
            string Query = "INSERT INTO mysqlcsharp.porntable (keyword) VALUES ('" + this.Pkeyword.Text + "');";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

            if (Pkeyword.Text == "")                                                                                                //CHECK EXISTING KEYWORD
            {
                MessageBox.Show("Please enter keyword");

            }
            else
            {
                cmdDataBase = new MySqlCommand("SELECT * FROM porntable where keyword='" + this.Pkeyword.Text + "'", conDataBase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                DataSet dbdataset = new DataSet();
                da.Fill(dbdataset);
                int i = dbdataset.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Keyword " + Pkeyword.Text + " already exist");
                    dbdataset.Clear();
                }
                else
                {
                    try
                    {
                        constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                        Query = "INSERT INTO mysqlcsharp.porntable (keyword) VALUES ('" + this.Pkeyword.Text + "');";
                        conDataBase = new MySqlConnection(constring);
                        cmdDataBase = new MySqlCommand(Query, conDataBase);

                        conDataBase.Open();                                                                                         //OPEN AND VALIDATE CONNECTION
                        cmdDataBase.ExecuteNonQuery();
                        da = new MySqlDataAdapter("SELECT keyword FROM mysqlcsharp.porntable;", conDataBase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        //myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                        Pkeyword.Text = "";                        //textbox clear code
                        conDataBase.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }       

        private void loadBtn_Click_1(object sender, EventArgs e)                                                                   //LOAD BUTTON
        {
                string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.porntable;", conDataBase);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                    sda.Update(dbdataset);

                    /*/call headercheckbox mouse click
                    AddHeaderCheckBox();
                    HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
            /*/headercheckbox
            CheckBox HeaderCheckBox = null;
            bool IsHeaderCheckBoxClicked = false;

            private void AddHeaderCheckBox()
            {
                HeaderCheckBox = new CheckBox();
                HeaderCheckBox.Size = new Size(15, 15);

                //add checkbox into datagridview
                this.dataGridView1.Controls.Add(HeaderCheckBox);
            }
            //header checkbox clickevent
            private void HeaderCheckBoxClick(CheckBox HCheckBox)
            {
                IsHeaderCheckBoxClicked = true;

                foreach (DataGridViewRow Row in dataGridView1.Rows)
                    ((DataGridViewCheckBoxCell)Row.Cells["checkboxx"]).Value = HCheckBox.Checked;

                dataGridView1.RefreshEdit();

                //TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;

                IsHeaderCheckBoxClicked = false;
            }
            //mouse click event
            private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
            {
                HeaderCheckBoxClick((CheckBox)sender);
            }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Pkeyword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
        */
        private void updateBtn_Click(object sender, EventArgs e)                                                                    //UPDATE BUTTON
        {
            UpdatePorn PUpdateform = new UpdatePorn();
            PUpdateform.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)                                                            //DELETE BUTTON
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            string deleteQuery = "DELETE FROM mysqlcsharp.porntable WHERE keyword = '" + this.Pkeyword.Text + "';";
            conDataBase.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, conDataBase);

            if (MessageBox.Show("Are you sure you want to delete this keyword?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Keyword deleted!");
                    Pkeyword.Text = "";                 //textbox clear code
                }
            }
            else
            {
                MessageBox.Show("Keyword not deleted!");
                Pkeyword.Text = "";                     //textbox clear code
            }
            conDataBase.Close();
            
        }
    }
}  


    

