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
        SQLiteConnection dbCon;
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
                string sqlcommand = @"select * from Pat test xml table";
                //create DataAdapter and use to fill DataTable
                daItems = new SQLiteDataAdapter(sqlcommand, myconnect);
                daItems.Fill(dtItems);
                //display first row of DataTable information
                rowAt = 0;
                showrecord();

                myconnect.Open();
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

            //Reflbl.Text = "Refereance number:"           + row["Ref No"].ToString();
            //lstknwnloclbl.Text = "Last Known Location: " + row["Last Known Locations"].ToString();
            //desclbl.Text = "Description: "               + row["Description"].ToString();
            //manafactlbl.Text = "Manafacture: "           + row["Manafacturer"].ToString();
            //modeltypelbl.Text = "Model Type: "           + row["Model/Type"].ToString();
            //voltslbl.Text = "Volts: "                    + row["Volts"].ToString();
            //wattsamplbl.Text = "Watts/Amps: "            + row["Watts/Amps"].ToString();
            //classlbl.Text = "Class: "                    + row["Class"].ToString();
            //testdatelbl.Text = "Test Date: "             + row["Test Date"].ToString();
            //retestlbl.Text = "Retest interval: "         + row["Re-test Interval"].ToString();
            //expirylbl.Text = "Expiry date: "             + row["Expiry Date"].ToString();
            //newctpglbl.Text = "Newt to CTPG: "           + row["New to CTPG"].ToString();
            //commentlbl.Text = "Comments: "               + row["Comments"].ToString();
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
