using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
namespace CrytoWallet
{
    public partial class frmSignup : Form
    {
        static string connString = ConfigurationManager.ConnectionStrings["CrytoWallet.Properties.Settings.CrytoWalletDatabaseSQL"].ConnectionString;
        public frmSignup()
        {
            InitializeComponent();
            RemoteConnection remoteConn = new RemoteConnection();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            txtConformationPassword.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool flag = true ;
            //validate passwords
            if (txtPassword.Text != txtConformationPassword.Text)
            {
                txtConfirmPassError.Visible = true;
                flag = false;
            }
            if (txtPassword.Text.Length < 8)
            {
                txtPasswordError.Text = "Your password is too short.";
                flag = false;
            }
            if (!checkPass(txtPassword.Text))
            {
                txtPasswordError.Visible = true;
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text) )
            {
                txtUserError.Visible = true;
                flag = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPasswordError.Visible = true;
                flag = false;
            }
                
            //if all fields are valid
            if (flag == true)
            {
                //add user account
                using (SqlConnection sqlconn = new SqlConnection(connString))
                {
                    sqlconn.Open();
                    SqlCommand SqlComd = new SqlCommand("UserAdd", sqlconn);
                    SqlComd.CommandType = CommandType.StoredProcedure;
                    SqlComd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    SqlComd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlComd.Parameters.AddWithValue("@Email", txtPassword.Text);
                    try{
                        SqlComd.ExecuteNonQuery();
                        MessageBox.Show(string.Format("{0}, your register is successfully!", txtUsername.Text));
                        this.Hide();
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.ShowDialog();
                        this.Close();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Login connection failed!");
                    }
                    sqlconn.Close();
                }
            }
           

        }
        private bool checkPass(string input)
        {
            /**
             * • At least one upper case english letter 
             * • At least one lower case english letter 
             * • At least one digit 
             * • At least one special character 
             * • Minimum 8 in length
             * */
            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
                Regex rgx = new Regex(pattern);
            Match match = rgx.Match(txtPassword.Text);
            if (match.Success)
            {
                return true;
            }
            else return false;

        }
    }
}
