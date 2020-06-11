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
    public partial class formview : Form
    {
        /**************************
         * All connection objects
         *************************/
        public SQLiteConnection myconnect = new SQLiteConnection("Data Source = pat.db");
        //define ADO.NET objects
        SQLiteDataAdapter daItems;
        DataTable dtItems = new DataTable();
        int rowAt;
        bool isadd;

        /****************************
         * Loads data from last form
         ***************************/
        public formview()
        {
            InitializeComponent();
        }

        /*******************************
        * View form load functionality
        *******************************/
        private void formview_Load(object sender, EventArgs e)
        {
            lblapplication.Text = "CTPG Pat Test Application";
            try
            {
                myconnect.Open();
                string sqlcommand = @"select * from customer";
                //create DataAdapter and use to fill DataTable
                daItems = new SQLiteDataAdapter(sqlcommand, myconnect);
                daItems.Fill(dtItems);
                //display first row of DataTable information
                rowAt = 0;
                showrecord();

                pbconnection.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("This is a connection issue. Please contact admin for assistance.");
                pbconnection.BackColor = Color.Red;
                myconnect.Close();
                this.Close();
            }
        }

        private void showrecord()
        {
            //Display data in row "rowAT" of the DataTable
            DataRow row = dtItems.Rows[rowAt];
            lblcustid.Text = "Customer Identification number:" + row["custid"].ToString();
            lbltitle.Text = "Title: " + row["title"].ToString();
            lblfname.Text = "First Name: " + row["firstname"].ToString();
            lbllname.Text = "Last Name: " + row["lastname"].ToString();
            lblemail.Text = "Customer Contact Email: " + row["email"].ToString();
            lblallowance.Text = "Customer allowance: " + row["allowance"].ToString();
        }

        /*******************************
        * Close button funtionality
        *******************************/
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
