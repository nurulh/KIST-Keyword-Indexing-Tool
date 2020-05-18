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
using System.Security.Cryptography;
using System.Configuration;


namespace LoginProject
{
    public partial class Register : Form
    {
        string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conDataBase = new MySqlConnection();
        HashCode hc = new HashCode();



        public Register()
        {
            InitializeComponent();
        }
        

        string patternPasswd = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        private void Create_new_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            if (Username.Text.Equals("") || Password.Text.Equals(""))
                MessageBox.Show("Please fill mandatory fields!");
            else if (Password.Text != CPassword.Text)
                MessageBox.Show("Password do not match!");
            else
            {
                using (MySqlConnection conDataBase = new MySqlConnection(constring))
                {
                    //MySqlConnection conDataBase = new MySqlConnection(constring);
                    string Query = "INSERT INTO mysqlcsharp (fullname,email,phone_num,address,username,password) VALUES ('" + Fname.Text + "','" + Email.Text + "','" + Pno.Text + "','" + address.Text + "','" + Username.Text + "','" + hc.GetMD5(Password.Text) + "');";
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

                    conDataBase.Open();
                    cmdDataBase.ExecuteNonQuery();
                    
                    MessageBox.Show("Registration is successful!");
                    Close();
                }
                
            }
        }


        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void Pno_KeyPress(object sender, KeyPressEventArgs e)               //phone number allow numbers only
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 187)
            {
                e.Handled = true;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Password.Text, patternPasswd) == false)
            {
                Password.Focus();
                errorProvider1.SetError(this.Password, "Please Enter Alphanumeric Characters Only");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(Email.Text, pattern) == false)
            {
                Email.Focus();
                errorProvider2.SetError(this.Email, "Invalid Email Address");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            conDataBase.Open();
            cmd.CommandText = "SELECT * from mysqlcsharp.mysqlcsharp WHERE username ='" + Username.Text + "';";
            cmd.Connection = conDataBase;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                errorProvider3.SetError(this.Username, "Username Not Available!");
            }
            else
            {
                errorProvider3.Clear();
            }
            conDataBase.Close();
        }

        /*private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.Text = Encrypt(Password.Text);
        }*/
    }
}
