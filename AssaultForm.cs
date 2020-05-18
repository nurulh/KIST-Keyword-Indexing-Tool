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
    public partial class AssaultForm : Form
    {
        public AssaultForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)                                                                          //INSERT NEW KEYWORD
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
            string Query = "INSERT INTO mysqlcsharp.assaulttable (keyword) VALUES ('" + this.Askeyword.Text + "');";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

            if (Askeyword.Text == "")                                                                                                //CHECK EXISTING KEYWORD
            {
                MessageBox.Show("Please enter keyword!");

            }
            else
            {
                cmdDataBase = new MySqlCommand("SELECT * FROM assaulttable where keyword='" + this.Askeyword.Text + "'", conDataBase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                DataSet dbdataset = new DataSet();
                da.Fill(dbdataset);
                int i = dbdataset.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Keyword " + Askeyword.Text + " already exist");
                    dbdataset.Clear();
                }
                else
                {
                    try
                    {
                        constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                        Query = "INSERT INTO mysqlcsharp.assaulttable (keyword) VALUES ('" + this.Askeyword.Text + "');";
                        conDataBase = new MySqlConnection(constring);
                        cmdDataBase = new MySqlCommand(Query, conDataBase);

                        conDataBase.Open();                                                                                         //OPEN AND VALIDATE CONNECTION
                        cmdDataBase.ExecuteNonQuery();
                        da = new MySqlDataAdapter("SELECT keyword FROM mysqlcsharp.assaulttable;", conDataBase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        //myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                        Askeyword.Text = "";                                    //textbox clear code
                        conDataBase.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)                                                                 //LOAD & DISPLAY KEYWORD
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.assaulttable;", conDataBase);

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
                HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick); */
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
        */
        private void updateBtn_Click(object sender, EventArgs e)                                                           //UPDATE NEW KEYWORD
        {
            assaultUpdate assault = new assaultUpdate();
            assault.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)                                                            //DELETE KEYWORD
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            string deleteQuery = "DELETE FROM mysqlcsharp.assaulttable WHERE keyword = '" + this.Askeyword.Text + "';";
            conDataBase.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, conDataBase);

            if (MessageBox.Show("Are you sure you want to delete this keyword?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Keyword deleted!");
                    Askeyword.Text = "";                    //textbox clear code
                }
            }
            else
            {
                MessageBox.Show("Keyword not deleted!");
                Askeyword.Text = "";                        //textbox clear code
            }
            conDataBase.Close();
        }
    }
    
}
