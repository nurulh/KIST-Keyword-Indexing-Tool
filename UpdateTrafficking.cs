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
    public partial class UpdateTrafficking : Form
    {
        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        public UpdateTrafficking()
        {
            InitializeComponent();
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE mysqlcsharp.traffictable SET keyword = '" + this.NTKeyword.Text + "' WHERE keyword='" + this.TKeyword.Text + "'";

            conDataBase.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, conDataBase);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Keyword updated!");
                }
                else
                {
                    MessageBox.Show("Keyword cannot update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
            Close();
        }
    }
}
