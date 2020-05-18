using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace LoginProject
{
    public partial class IndexFile : UserControl
    {
        public IndexFile()
        {
            InitializeComponent();
        }

        private void pornBtn_Click(object sender, EventArgs e)
        {
            PornForm porn = new PornForm();
            porn.ShowDialog();
        }

        private void drugBtn_Click(object sender, EventArgs e)
        {
            DrugForm drug = new DrugForm();
            drug.ShowDialog();
        }

        private void IndexFile_Load(object sender, EventArgs e)
        {

        }

        private void murderBtn_Click(object sender, EventArgs e)
        {
            MurderForm murder = new MurderForm();
            murder.ShowDialog();
        }

        private void rapeBtn_Click(object sender, EventArgs e)
        {
            RapeForm rape = new RapeForm();
            rape.ShowDialog();
        }

        private void bribeBtn_Click(object sender, EventArgs e)
        {
            BribeForm bribe = new BribeForm();
            bribe.ShowDialog();
        }

        private void cyberBtn_Click(object sender, EventArgs e)
        {
            CybercrimeForm cybercrime = new CybercrimeForm();
            cybercrime.ShowDialog();
        }

        private void pedoBtn_Click(object sender, EventArgs e)
        {
            PedophileForm pedo = new PedophileForm();
            pedo.ShowDialog();

        }

        private void assaultBtn_Click(object sender, EventArgs e)
        {
            AssaultForm assault = new AssaultForm();
            assault.ShowDialog();
        }

        private void fraudBtn_Click(object sender, EventArgs e)
        {
            Fraud fraud = new Fraud();
            fraud.ShowDialog();
        }

        private void harassBtn_Click(object sender, EventArgs e)
        {
            Harassment harass = new Harassment();
            harass.ShowDialog();
        }

        private void trafficBtn_Click(object sender, EventArgs e)
        {
            Trafficking traffic = new Trafficking();
            traffic.ShowDialog();
        }

        private void hateBtn_Click(object sender, EventArgs e)
        {
            Hate hate = new Hate();
            hate.ShowDialog();
        }
    }

        
        

       
}
       
        
  
