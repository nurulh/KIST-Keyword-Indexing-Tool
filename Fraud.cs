﻿using System;
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
    public partial class Fraud : Form
    {
        public Fraud()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
            string Query = "INSERT INTO mysqlcsharp.fraudtable (keyword) VALUES ('" + this.FKeyword.Text + "');";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

            if (FKeyword.Text == "")                                                                                                //CHECK EXISTING KEYWORD
            {
                MessageBox.Show("Please enter keyword!");

            }
            else
            {
                cmdDataBase = new MySqlCommand("SELECT * FROM fraudtable where keyword='" + this.FKeyword.Text + "'", conDataBase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                DataSet dbdataset = new DataSet();
                da.Fill(dbdataset);
                int i = dbdataset.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Keyword " + FKeyword.Text + " already exist");
                    dbdataset.Clear();
                }
                else
                {
                    try
                    {
                        constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                        Query = "INSERT INTO mysqlcsharp.fraudtable (keyword) VALUES ('" + this.FKeyword.Text + "');";
                        conDataBase = new MySqlConnection(constring);
                        cmdDataBase = new MySqlCommand(Query, conDataBase);

                        conDataBase.Open();                                                                                         //OPEN AND VALIDATE CONNECTION
                        cmdDataBase.ExecuteNonQuery();
                        da = new MySqlDataAdapter("SELECT keyword FROM mysqlcsharp.fraudtable;", conDataBase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        //myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Saved");
                        FKeyword.Text = "";         //textbox clear code
                        conDataBase.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateFraud fraud = new UpdateFraud();
            fraud.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            string deleteQuery = "DELETE FROM mysqlcsharp.fraudtable WHERE keyword = '" + this.FKeyword.Text + "';";
            conDataBase.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, conDataBase);

            if (MessageBox.Show("Are you sure you want to delete this keyword?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Keyword deleted!");
                    FKeyword.Text = "";                 //textbox clear code
                }
            }
            else
            {
                MessageBox.Show("Keyword not deleted!");
                FKeyword.Text = "";                     //textbox clear code
            }
            conDataBase.Close();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.fraudtable;", conDataBase);

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
    }
}
