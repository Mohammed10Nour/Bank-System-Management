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

namespace Bank.Users.Controls
{
    public partial class ctrlUserCardInfo : UserControl
    {
        private int _UserID;
        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        private clsUser _User;
        public clsUser User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
        }
        private void _ResetControls()
        {
            UserID = -1;
            lblUserID.Text = "????";
            lblUsername.Text = "????";
            lblPassword.Text = "????";
            txtPermission.Clear();
            chboxIsActive.Checked = false;
        }
        private void _LoadUserData()
        {
            lblUsername.Text = User.UserName;
            lblPassword.Text = User.Password;
            lblUserID.Text = User.UserID.ToString();
            chboxIsActive.Checked = (User.IsActive == true) ? true : false;
            txtPermission.Clear();
            if((User.Permission &(int)clsUser.enPermission.AddEditUsers)==(int)clsUser.enPermission.AddEditUsers)
            {
                txtPermission.Text += "Add and Edit Users." + Environment.NewLine;
            }
            if ((User.Permission & (int)clsUser.enPermission.DeleteUsers) == (int)clsUser.enPermission.DeleteUsers)
            {
                txtPermission.Text += "Delete Users." + Environment.NewLine;
            }
            if ((User.Permission & (int)clsUser.enPermission.ShowDetailsUsersInformation) == (int)clsUser.enPermission.ShowDetailsUsersInformation)
            {
                txtPermission.Text += "Show Users Information." + Environment.NewLine;
            }
           

        }
        public ctrlUserCardInfo()
        {
            InitializeComponent();
        }
        public bool LoadData()
        {
            User = clsUser.FindUserByUserID(UserID);
            if(User==null)
            {
              MessageBox.Show("User not found!", "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
              _ResetControls();
               return false;
            }
             _LoadUserData();
                return true;
          
        }

        private void lblEditInformatin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!clsGlobal.hasPermission((int)clsUser.enPermission.AddEditUsers))
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية إجراء هذه العملية.",
                "تنبيه الصلاحيات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            Form frm = new frmAddEditUser(UserID);
            frm.ShowDialog();
            LoadData();
        }
    }
}
