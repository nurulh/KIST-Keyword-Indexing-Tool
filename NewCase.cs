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
    public partial class NewCase : UserControl
    {
        string constring = "server=localhost;uid=root;database=mysqlcsharp;password=;";
        public NewCase()
        {
            InitializeComponent();
        }
        /*************************************************************LOAD BUTTON TO DISPLAY ALL KEYWORDS LIST*********************************************************/
        private void ALoad_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.assaulttable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dgv.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BLoad_Click(object sender, EventArgs e)                //Load BRIBE keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.bribetable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Bribe.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CLoad_Click(object sender, EventArgs e)                        //Load CYBERCRIME keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.cybertable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Cyber.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DLoad_Click(object sender, EventArgs e)                    //Load DRUG keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.drugtable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Drug.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MLoad_Click(object sender, EventArgs e)                        //Load MURDER keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.murdertable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Murder.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PdLoad_Click(object sender, EventArgs e)                           //Load PEDOPHILE keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.pedotable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Pedophile.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PnLoad_Click(object sender, EventArgs e)                           //Load PORNO keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.porntable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Pornography.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RLoad_Click(object sender, EventArgs e)                                //Load RAPE keywords
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.rapetable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Rape.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FLoad_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.fraudtable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Fraud.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HLoad_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.harasstable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Harassment.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TLoad_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.traffictable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Trafficking.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HateLoad_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT keyword FROM mysqlcsharp.hatetable;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                Hate.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*************************************************************************************END OF LOAD BUTTON CODE****************************************************/

        /*************************************************************************************CODE TO UPLOAD FILE********************************************************/
        public void upload_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "Text Files (*txt)| *txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                richTextBox1.Text = read.ReadToEnd();
                read.Dispose();
            }
        }
        /*************************************************************************************END OF CODE TO UPLOAD FILE********************************************************/
        private void analyzebtn_Click(object sender, EventArgs e)                   //ANALYZE BUTTON
        {
            Report generate_report = new Report();
            generate_report.ShowDialog();
        }
        /*************************************************************************************CODE FOR SEARCH BUTTON****************************************************/
        private void search1_Click(object sender, EventArgs e)                             //BRIBE
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(searchBox.Text.ToString());
        }

        private void searchBtnA1_Click(object sender, EventArgs e)              //Assault SEARCH BOX
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(searchBox1.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(searchBox1.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(searchBox1.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(searchBox1.Text.ToString());
            //  listBox3.Items.Add(startIndex.ToString());
            
        }
        private void searchBtnC_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(cyber_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(cyber_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(cyber_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(cyber_searchBox.Text.ToString());

            
    }

        private void searchBtnD_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(drug_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(drug_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(drug_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(drug_searchBox.Text.ToString());
        }

        private void searchBtnM_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(murder_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(murder_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(murder_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(murder_searchBox.Text.ToString());
            


        }
        private void searchBtnPd_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(pedo_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(pedo_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(pedo_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(pedo_searchBox.Text.ToString());
        }

        private void searchBtnPorn_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(porno_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(porno_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(porno_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(porno_searchBox.Text.ToString());
        }

        private void searchBtnR_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(rape_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(rape_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(rape_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(rape_searchBox.Text.ToString());
        }

        private void searchBtnF_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(fraud_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(fraud_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(fraud_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(fraud_searchBox.Text.ToString());
        }

        private void searchBtnH_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(harass_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(harass_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(harass_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(harass_searchBox.Text.ToString());
        }
            private void searchBtnT_Click(object sender, EventArgs e)
            {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(traffic_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(traffic_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(traffic_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(traffic_searchBox.Text.ToString());
            }

        private void searchBtnHate_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            string userInput = richTextBox1.Text;
            //richTextBox1.Text = "";
            // richTextBox1.Text = userInput;
            int counter = 0;

            while (startIndex < richTextBox1.Text.LastIndexOf(hate_searchBox.Text))
            {
                //search the text in a richtextbox control for a string within
                int wordStartIndex = richTextBox1.Find(hate_searchBox.Text, startIndex, richTextBox1.TextLength, RichTextBoxFinds.None);
                if (wordStartIndex != 1)
                {
                    richTextBox1.SelectionStart = wordStartIndex;
                    richTextBox1.SelectionBackColor = Color.Yellow;
                    startIndex = richTextBox1.Text.IndexOf(hate_searchBox.Text, startIndex) + 1;
                }
                counter += 1;
            }
            listBox2.Items.Add(counter.ToString());
            listBox1.Items.Add(hate_searchBox.Text.ToString());
        }
        /*************************************************************************************END OF SEARCH BUTTON CODE****************************************************/

        /*************************************************************************************CODE FOR CLICK ON DATAGRIDVIEW****************************************************/

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)          //click row to search keyword
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                searchBox1.Text = dgv.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Bribe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Bribe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Bribe.CurrentRow.Selected = true;
                searchBox.Text = Bribe.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Cyber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cyber.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Cyber.CurrentRow.Selected = true;
                cyber_searchBox.Text = Cyber.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Drug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Drug.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Drug.CurrentRow.Selected = true;
                drug_searchBox.Text = Drug.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Murder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Murder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Murder.CurrentRow.Selected = true;
                murder_searchBox.Text = Murder.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Pedophile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pedophile.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pedophile.CurrentRow.Selected = true;
                pedo_searchBox.Text = Pedophile.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Pornography_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Pornography.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Pornography.CurrentRow.Selected = true;
                porno_searchBox.Text = Pornography.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Rape_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Rape.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Rape.CurrentRow.Selected = true;
                rape_searchBox.Text = Rape.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Fraud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Fraud.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Fraud.CurrentRow.Selected = true;
                fraud_searchBox.Text = Fraud.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Harassment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Harassment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Harassment.CurrentRow.Selected = true;
                harass_searchBox.Text = Harassment.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Trafficking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Trafficking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Trafficking.CurrentRow.Selected = true;
                traffic_searchBox.Text = Trafficking.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void Hate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Hate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Hate.CurrentRow.Selected = true;
                hate_searchBox.Text = Hate.Rows[e.RowIndex].Cells["keyword"].FormattedValue.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Danrabbit_Elementary_Window_new__2_;
            Image newimg = bmp;
            e.Graphics.DrawImage(newimg, 10, 18, newimg.Width, newimg.Height);

            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black,90,140);
            //e.Graphics.DrawString(listBox2.Items.Add(counter.ToString()), new Font("Arial", 11, FontStyle.Regular), Brushes.Yellow, 140, 200);
            //e.Graphics.DrawString(listBox2.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, 300, 450);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text);
            }
        }








        /*************************************************************************************END OF DATAGRIDVIEW CLICK CODE****************************************************/
    }
}
   