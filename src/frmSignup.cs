using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CrytoWallet
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
            RemoteConnection remoteConn = new RemoteConnection();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {

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
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = C:\USERS\FAMILY\SOURCE\REPOS\CRYTOWALLET\DATABASE.MDF;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE txtUsername.Text = @Username AND txtPassword.Text = @Password", sqlconn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Email", txtPassword.Text);
                   
                    int reuslt = (int)cmd.ExecuteScalar();
                   
                    if (reuslt > 0)
                    {
                        MessageBox.Show(string.Format("{0}, your register is successfully!", txtUsername.Text));
                    }
                    else
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
