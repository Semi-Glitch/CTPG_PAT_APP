using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace PAT_TEST_APP_DB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public SQLiteConnection myconnect;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbltitle.Text = "CTPG Pat Test Application";
            lblconnect.Text = "Connecting";
            try
            {
                myconnect = new SQLiteConnection("Data Source = pat.db");
                myconnect.Open();
                pbconnect.BackColor = Color.Green;
                lblconnect.Text = "Connected";
            }
            catch
            {
                MessageBox.Show("This is a connection issue. Please contact admin for assistance.");
                myconnect.Close();
                this.Close();
            }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            formview viewform = new formview(myconnect);
            viewform.Show();
                
        }
    }
}
