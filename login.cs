using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class login : Form
    {
        HashCode hc = new HashCode();
        public login()
        {
            InitializeComponent();
        }

        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value; }

        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            if(connct.querylogin("SELECT username,password FROM mysqlcsharp WHERE username='"+Username.Text+"'AND password='" + hc.GetMD5(Password.Text) + "'") <=0)
            {
                MessageBox.Show("Login failed!");
                Username.Text = "";
                Password.Text = "";
            }
            else
            {
                recby = Username.Text;
                MessageBox.Show("Login successful!");
                Username.Text = "";
                Password.Text = "";
                Home f = new Home(Username.Text);
                
                f.ShowDialog();
                this.Close();
            }
          
        }
        private void create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register f = new Register();
            f.ShowDialog();
        }

        private void Create_new_Click(object sender, EventArgs e)
        {
            
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void forgotpsswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpsswd fp = new forgotpsswd();
            fp.ShowDialog();
        }
    }
    
}
