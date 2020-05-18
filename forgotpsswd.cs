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
using System.Text.RegularExpressions;

namespace LoginProject
{
    public partial class forgotpsswd : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        HashCode hc = new HashCode();
        public forgotpsswd()
        {
            InitializeComponent();
        }
        string patternPasswd = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        private void getPasswd_Click(object sender, EventArgs e)
        {
          if (Newpsswd.Text != Cpasswd.Text)
                MessageBox.Show("Password do not match!");
            else 
            {
                string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                string Query = "UPDATE mysqlcsharp.mysqlcsharp SET password = '" + hc.GetMD5(Newpsswd.Text) + "' WHERE username='" + this.username.Text + "'";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                conDataBase.Open();
                cmdDataBase.ExecuteNonQuery();

                MessageBox.Show("Reset Password Done!");
                Close();
            }
        }

        private void Newpsswd_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Newpsswd.Text, patternPasswd) == false)
            {
                Newpsswd.Focus();
                errorProvider1.SetError(this.Newpsswd, "Please Enter Alphanumeric Characters Only");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            /*string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(username.Text, pattern) == false)
            {
                username.Focus();
                errorProvider2.SetError(this.username, "Invalid Email Address!");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }*/
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            conDataBase.Open();
            cmd.CommandText = "SELECT * from mysqlcsharp.mysqlcsharp WHERE username ='" + username.Text + "';";
            cmd.Connection = conDataBase;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                errorProvider2.Clear();

            }
            else
            {
                errorProvider2.SetError(this.username, "Username Not Available!");
            }
            conDataBase.Close();
        }
        
    }
    
}
