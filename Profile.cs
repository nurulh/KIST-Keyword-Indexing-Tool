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
    public partial class Profile : UserControl
    {
        
        public Profile()
        {
            InitializeComponent();
        }
        login login = new login();
        //Image File;

        MySqlConnection conDataBase = new MySqlConnection("server=localhost;uid=root;database=mysqlcsharp;password=;");
        MySqlCommand cmdDataBase = new MySqlCommand();

       /* private void okBtn_Click(object sender, EventArgs e)
        {
            
            conDataBase.Open();
            string mysqlSelect = "SELECT * FROM mysqlcsharp.mysqlcsharp WHERE username ='" + dUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(mysqlSelect, conDataBase);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fullname.Text = (dr["fullname"].ToString());
                email.Text = (dr["email"].ToString());
                ic.Text = (dr["ic"].ToString());
                phone.Text = (dr["phone_num"].ToString());
                address.Text = (dr["address"].ToString());
                //pictureBox1.Image= (dr["image"].ToString());

                /*Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])((byte[])dr["image"]);
                MemoryStream ms = new MemoryStream(byteBLOBData);*/

               /* byte[] imgg = (byte[])dr["image"];
                MemoryStream mstream = new MemoryStream(imgg);
                pictureBox1.Image = Image.FromFile(mstream);
                
            }
            conDataBase.Close();
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            BasicInformation info = new BasicInformation(dUsername.Text);
            info.ShowDialog();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            conDataBase.Open();
            string mysqlSelect = "SELECT * FROM mysqlcsharp.mysqlcsharp WHERE username ='" + (dUsername.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(mysqlSelect, conDataBase);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fullname.Text = (dr["fullname"].ToString());
                email.Text = (dr["email"].ToString());
                ic.Text = (dr["ic"].ToString());
                phone.Text = (dr["phone_num"].ToString());
                address.Text = (dr["address"].ToString());
                //pictureBox1.Image= (dr["image"].ToString());

                /*Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])((byte[])dr["image"]);
                MemoryStream ms = new MemoryStream(byteBLOBData);*/

                /* byte[] imgg = (byte[])dr["image"];
                 MemoryStream mstream = new MemoryStream(imgg);
                 pictureBox1.Image = Image.FromFile(mstream);
                 */
            }
            conDataBase.Close();
        }

        private void changePasswd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpsswd changepassword = new forgotpsswd();
            changepassword.Show();
        }

        
    }
}
