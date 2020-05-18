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
    public partial class DrugForm : Form
    {
        public DrugForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)                                                                      //SAVE BUTTON
        {
           string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
           string Query = "INSERT INTO mysqlcsharp.drugtable (keyword) VALUES ('" + this.Dkeyword.Text + "');";
            
           MySqlConnection conDataBase = new MySqlConnection(constring);
           MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
          
            if (Dkeyword.Text == "")                                                                                                //CHECK EXISTING KEYWORD
            {
                MessageBox.Show("Please enter keyword");
                
            }
            else
            {
                cmdDataBase = new MySqlCommand("SELECT * FROM drugtable where keyword='" + this.Dkeyword.Text + "'", conDataBase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                DataSet dbdataset = new DataSet();
                //DataTable dt = new DataTable("keyword");                
                              
                da.Fill(dbdataset);
                int i = dbdataset.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Keyword " + Dkeyword.Text + " already exist");
                    dbdataset.Clear();
                }
                else
                {
                   try
                    {
                       constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                       Query = "INSERT INTO mysqlcsharp.drugtable (keyword) VALUES ('" + this.Dkeyword.Text + "');";
                       conDataBase = new MySqlConnection(constring);
                       cmdDataBase = new MySqlCommand(Query, conDataBase);

                       conDataBase.Open();                                                              //OPEN AND VALIDATE CONNECTION
                       cmdDataBase.ExecuteNonQuery();
                       da = new MySqlDataAdapter("SELECT keyword FROM mysqlcsharp.drugtable;", conDataBase);
                       DataTable dt = new DataTable();
                       da.Fill(dt);

                       dataGridView1.DataSource = dt;
                                
                       //myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                        Dkeyword.Text = "";     //textbox clear code
                        conDataBase.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } 
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)                                                                  //LOAD BUTTON AND DISPLAY DATAGRIDVIEW
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
             MySqlConnection conDataBase = new MySqlConnection(constring);
             MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.drugtable;", conDataBase);

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
            }
            catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }
        
        private void updateBtn_Click(object sender, EventArgs e)                                                                    //UPDATE BUTTON
        {
            DrugUpdate drugUpdate = new DrugUpdate();
            drugUpdate.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dkeyword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DrugForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mysqlcsharpDataSet.keyword' table. You can move, or remove it, as needed.
            //this.keywordTableAdapter.Fill(this.mysqlcsharpDataSet.keyword);

        }

        private void deleteBtn_Click(object sender, EventArgs e)                                                                   //DELETE BUTTON
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            string deleteQuery = "DELETE FROM mysqlcsharp.drugtable WHERE keyword = '" + this.Dkeyword.Text + "';";
            conDataBase.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, conDataBase);

            if (MessageBox.Show("Are you sure you want to delete this keyword?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Keyword deleted!");
                    Dkeyword.Text = "";         //textbox clear code
                }
            }
            else
            {
                MessageBox.Show("Keyword not deleted!");
                Dkeyword.Text = "";             //textbox clear code
            }
            conDataBase.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
