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
    public partial class MUpdate : Form
    {
        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        public MUpdate()
        {
            InitializeComponent();
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE mysqlcsharp.murdertable SET keyword = '" + this.NMkeyword.Text + "' WHERE keyword='" + this.Mkeyword.Text + "'";

            conDataBase.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, conDataBase);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("KEYWORD UPDATED");
                }
                else
                {
                    MessageBox.Show("KEYWORD NOT UPDATED");
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
