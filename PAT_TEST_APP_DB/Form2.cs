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
        SQLiteConnection my_connect;

        /****************************
         * Loads data from last form
         ***************************/
        public formview(SQLiteConnection con_name)
        {
            InitializeComponent();
            my_connect = con_name;
        }

        /*******************************
        * View form load functionality
        *******************************/
        private void formview_Load(object sender, EventArgs e)
        {
            lblapplication.Text = "CTPG Pat Test Application";
            try
            {
                my_connect.Open();
                pbconnection.BackColor = Color.Green;
            }
            catch
            {
                MessageBox.Show("This is a connection issue. Please contact admin for assistance.");
                pbconnection.BackColor = Color.Red;
                my_connect.Close();
                this.Close();
            }
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
