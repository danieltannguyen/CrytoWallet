using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrytoWallet
{
    class Program
    {
        public static void Main(String[] arg)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            frmMain main = new frmMain();
            
        }
    }
}
