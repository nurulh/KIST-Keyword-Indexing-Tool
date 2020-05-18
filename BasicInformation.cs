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
using System.IO;

namespace LoginProject
{
    public partial class BasicInformation : Form
    {
        string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
        MySqlCommand cmd = new MySqlCommand();
        string gender = "";
        string status = "";
        public BasicInformation(string login1)
        {
            InitializeComponent();
            username.Text = login1;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (maleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (singleBtn.Checked)
            {
                status = "Single";
            }
            else if (marriedBtn.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "Other";
            }
            MySqlConnection conDataBase = new MySqlConnection(constring);
            
           string Query = "UPDATE mysqlcsharp.mysqlcsharp SET fullname='"+Fname.Text+"',email='"+Email.Text+"',phone_num='"+phone.Text+"',address='"+address.Text+"',Gender='"+gender+"',Marital_status='"+status+"',Date='"+dateTimePicker1.Text+"'  WHERE username='" + username.Text + "'";
           // string Query = "INSERT INTO mysqlcsharp.mysqlcsharp (fullname,email,phone_num,address,Gender,Marital_status,Date) VALUES ('" + Fname.Text + "','" + Email.Text + "','" + phone.Text + "','" + address.Text + "','" + gender + "','" + status + "','" + dateTimePicker1.Text + "') WHERE username='" + username.Text + "'" ;
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

            conDataBase.Open();
            
            if (cmdDataBase.ExecuteNonQuery()==1)
            {
                
                MessageBox.Show("User information is updated!");
            }
            else
            {
                MessageBox.Show("Username does not exist");
            }
            Close();
        }
        private void BasicInformation_Load(object sender, EventArgs e)
        {
            username.Text = login.recby;
        }

        private void username_Leave(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
            conDataBase.Open();
            cmd.CommandText = "SELECT * from mysqlcsharp.mysqlcsharp WHERE username ='" + username.Text + "';";
            cmd.Connection = conDataBase;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                errorProvider1.Clear();

            }
            else
            {
               
                errorProvider1.SetError(this.username, "Username Not Available!");
            }
            conDataBase.Close();
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

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 187)
            {
                e.Handled = true;
            }
        }

        private void ic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 187)
            {
                e.Handled = true;
            }
        }
    }
    }

