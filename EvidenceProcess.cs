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
    public partial class EvidenceProcess : Form
    {
        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        public EvidenceProcess()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (connct.query("INSERT INTO mysqlcsharp.casedetail (caseID,examiner,casename,description) VALUES ('" + caseid.Text + "','" + examinername.Text + "','" + casenm.Text + "','" + desc.Text + "')"))
            {
                MessageBox.Show("Success");

                NewCase newCase1 = new NewCase();
                newCase1.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Success");
                Close();
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void caseid_Leave(object sender, EventArgs e)
        {
           
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            MySqlCommand cmd = new MySqlCommand();
            conDataBase.Open();
            cmd.CommandText = "SELECT * from mysqlcsharp.casedetail WHERE ID ='" + caseid.Text + "';";
            cmd.Connection = conDataBase;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                errorProvider1.SetError(this.caseid, "ID Not Available!");
            }
            else
            {
                errorProvider1.Clear();
            }
            conDataBase.Close();
        }
    }
}
