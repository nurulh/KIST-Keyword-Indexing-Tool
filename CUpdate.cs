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
    public partial class CUpdate : Form
    {
        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        public CUpdate()
        {
            InitializeComponent();
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE mysqlcsharp.cybertable SET keyword = '" + this.NCkeyword.Text + "' WHERE keyword='" + this.Ckeyword.Text + "'";

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
