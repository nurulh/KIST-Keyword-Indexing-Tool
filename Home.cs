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
using System.IO;


namespace LoginProject
{
    public partial class Home : Form
    {
        
        public Home(string login1)
        {
            InitializeComponent();
            dUsername.Text = login1;
        }
        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        MySqlCommand cmdDataBase = new MySqlCommand();

        private void Home_Load(object sender, EventArgs e)
        {
            newCase1.Hide();
            recentCase1.Hide();
            indexFile1.Hide();
            //profile.Show();
            //profile.BringToFront();

            dUsername.Text = login.recby;
            label2.Text="Welcome, " +login.recby+"";


        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //hide other user control
            recentCase1.Hide();
            indexFile1.Hide();
            //profile.Hide();

            EvidenceProcess evidenceProcess = new EvidenceProcess();
            evidenceProcess.ShowDialog();
            evidenceProcess.BringToFront();
            //show current user control
            newCase1.Show(); 
            newCase1.BringToFront();
        }

       /* private void recentButton_Click(object sender, EventArgs e)
        {
            //hide other user control
            newCase1.Hide();
            indexFile1.Hide();
            //profile.Hide();
            //show current user control
            recentCase1.Show();
            recentCase1.BringToFront();
        }*/

        private void indexButton_Click(object sender, EventArgs e)
        {
            //hide other user control
            newCase1.Hide();
            recentCase1.Hide();
           // profile.Hide();
            //show current user control
            indexFile1.Show();
            indexFile1.BringToFront();
        }

        private void examiner_Click(object sender, EventArgs e)
        {
            //hide other user control
            indexFile1.Hide();
            newCase1.Hide();
            recentCase1.Hide();
            //show current user control
            //profile.Show();
           // profile.BringToFront();
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void profile_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

            
            string mysqlSelect = "SELECT * FROM mysqlcsharp.mysqlcsharp WHERE username ='" + dUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(mysqlSelect, conDataBase);
            MySqlDataReader dr;
            try {
                conDataBase.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    fullname.Text = (dr["fullname"].ToString());
                    email.Text = (dr["email"].ToString());
                    ic.Text = (dr["ic"].ToString());
                    phone.Text = (dr["phone_num"].ToString());
                    address.Text = (dr["address"].ToString());
                    gender.Text = (dr["Gender"].ToString());
                    status.Text = (dr["Marital_status"].ToString());
                    dob.Text= (dr["Date"].ToString());

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            BasicInformation info = new BasicInformation(dUsername.Text);
            info.ShowDialog();
        }

        private void changePasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpsswd changepassword = new forgotpsswd();
            changepassword.Show();
        }

        private void newCase1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManual userManual = new UserManual();
            userManual.ShowDialog();
        }
    }
}
