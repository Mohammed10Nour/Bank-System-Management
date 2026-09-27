using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Users;

namespace Bank
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
            clsGlobal.CurrentUser = clsUser.FindUserByUserNameAndPassword(txtUserName.Text, txtPassword.Text);
            if (clsGlobal.CurrentUser == null)
            {
                return;
            }
      
            
            if (chRememberMe.Checked)
            {
                clsGlobal.SotrageUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            else clsGlobal.SotrageUserNameAndPassword(string.Empty, string.Empty,true);
         
            
            
            this.Hide();
           Form frm = new frmMain(this);
           frm.ShowDialog();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "";
            string Password = "";

            if (clsGlobal.LoadUserNameAndPassword(ref UserName, ref Password))
            {
                chRememberMe.Checked = true;
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
            }
           


        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            if(chRememberMe.Checked)
            {
                frmLogin_Load(null, null);
            }
            else
            {
                chRememberMe.Checked = false;
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.FillColor == Color.Red)
            {
                guna2Button1.FillColor = Color.White;
                txtPassword.PasswordChar = '*';
                return;
            }
            guna2Button1.FillColor = Color.Red;
            txtPassword.PasswordChar = '\0';
        }
    }
}
