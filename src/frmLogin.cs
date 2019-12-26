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
        static string connString = ConfigurationManager.ConnectionStrings["CrytoWalletDatabaseSQL"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Account WHERE txtUsername.Text = @Username AND txtPassword.Text = @Password";
            SqlDataAdapter sda = new SqlDataAdapter(query, connString);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                txtLoginError.Visible = true;
            }
        }
    }
}
