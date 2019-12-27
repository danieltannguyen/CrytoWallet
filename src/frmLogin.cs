using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrytoWallet
{
    public partial class frmLogin : Form
    {
        static string connString = ConfigurationManager.ConnectionStrings["CrytoWallet.Properties.Settings.CrytoWalletDatabaseSQL"].ConnectionString;
      
        public frmLogin()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
             frmSignup signup = new frmSignup();
            signup.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Username FROM Account WHERE Username ='"+username.Text+"' AND Password='"+password.Text+"'", connString);

            DataSet ds = new DataSet();          
            sda.Fill(ds);
            DataTable dataTable = ds.Tables[0];
            if (dataTable.Rows.Count >= 1)
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                txtLoginError.Visible = true;
            }
        }
    }
}
