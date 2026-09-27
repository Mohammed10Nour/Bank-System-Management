using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Bank.Users
{
    public partial class frmAddEditUser : Form
    {

        private enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private int _UserID = -1;
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

        private void _LoadUserData()
        {
            lblUserID.Text = User.UserID.ToString();
            txtUserName.Text = User.UserName;
            txtPassword.Text = User.Password;
            txtConfirmPassword.Text = User.Password;
            chboxIsActive.Checked = User.IsActive;
           
            for (int i = 0; i < chlistPermission.Items.Count; i++)
            {
                if (chlistPermission.Items[i].ToString()=="Add and Edit Users")
                {
                    chlistPermission.SetItemChecked(i,(User.Permission & (int)clsUser.enPermission.AddEditUsers) == (int)clsUser.enPermission.AddEditUsers);
                }
                 if (chlistPermission.Items[i].ToString()=="Delete Users")
                {
                    chlistPermission.SetItemChecked(i, (User.Permission & (int)clsUser.enPermission.DeleteUsers) == (int)clsUser.enPermission.DeleteUsers);
                }
                 if (chlistPermission.Items[i].ToString()=="Show Users Information")
                {
                    chlistPermission.SetItemChecked(i, (User.Permission & (int)clsUser.enPermission.ShowDetailsUsersInformation) == (int)clsUser.enPermission.ShowDetailsUsersInformation);
                }
               
            }
        }
        private void _LoadClientData()
        {

            ctrlClientCardInfoWithFilter1.ClientID = User.ClientID;
            ctrlClientCardInfoWithFilter1.LoadData();


        }
        private void _LoadDataFromObjectsToControls()
        {
            User = clsUser.FindUserByUserID(UserID);
            _LoadUserData();
            _LoadClientData();
        }
        private void _LoadDataFromControlsToObject()
        {
            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.ClientID = ctrlClientCardInfoWithFilter1.ClientID;
            User.IsActive = (chboxIsActive.Checked) ? true : false;
            User.Permission = 0;
            foreach (var item in chlistPermission.CheckedItems)
            {
                if (item.ToString() == "Add and Edit Users")
                {
                    User.Permission += (int)(clsUser.enPermission.AddEditUsers); //| clsUser.enPermission.DeleteUsers | clsUser.enPermission.ShowDetailsUsersInformation);//);
                }
                if (item.ToString() == "Delete Users")
                {
                    User.Permission+= (int)(clsUser.enPermission.DeleteUsers);

                }
                if (item.ToString() == "Show Users Information.")
                {
                    User.Permission += (int)(clsUser.enPermission.ShowDetailsUsersInformation);
                }
            }
        }



        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            lblUserID.Select();
            lblUserID.Focus();

        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            this.UserID = UserID;
        }   
        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            tcUserInfo.Enabled = false;
            btnBack.Enabled = false;
            btnBack.Visible = false;
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        User = new clsUser();
                        lblMain.Text = "إضافة مسخدم جديد";
                        lblSecondary.Text = "أدخل بيانات المستخدم الجديد لإضافته في النظام";

                        break;
                    }
                case enMode.Update:
                    {
                        _LoadDataFromObjectsToControls();
                        
                        lblMain.Text = "تحديث بيانات مستخدم";
                        lblSecondary.Text = "قم بتعديل بيانات العميل الحالية في النظام";
                        break;
                    }
            }
            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsUser.IsClientExistAsUser(ctrlClientCardInfoWithFilter1.ClientID)&&_Mode==enMode.AddNew)

            {
                MessageBox.Show("This client is already a user in the system. Cannot be added again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tcUserInfo.Enabled = true;
            btnNext.Visible = false;
            btnNext.Enabled = false;

            btnBack.Visible = true;
            btnBack.Enabled = true;

            tabControl.SelectedTab = tabControl.TabPages["tcUserInfo"];
          
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages["tpClientInformation"];

            btnBack.Enabled = false;
            btnBack.Visible = false;

            btnNext.Visible = true;
            btnNext.Enabled = true;

        }
        private void btnEye_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = '\0';
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlClientCardInfoWithFilter1.ClientID == -1)
                return;
           
            if(User.UserID==clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("لا يمكن اتمام هذه العملية ,لانه لايمكن التعديل على بيانات المستخدم الحالي", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.ValidateChildren())
            {
                
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           _LoadDataFromControlsToObject();
          
            
            if (User.Save())
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (_Mode)
                {
                    case enMode.AddNew:
                    {
                            lblUserID.Text = User.UserID.ToString();
                            lblMain.Text = "تحديث بياناتمستخدم";
                            lblSecondary.Text = "قم بتعديل بيانات المستخدم في النظام";
                            _Mode = enMode.Update;
                            break;
                    }
                    case enMode.Update:
                        {
                          //  أدخل بيانات المستخدم الجديد لإضافته في النظام
                            break;
                        }
            }
               
            }
            else
                MessageBox.Show("Failed to save user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                MessageBox.Show("كلمة المرور غير متطابقة. يرجى المحاولة مرة أخرى.",
                                "خطأ في التأكيد",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                //txtConfirmPassword.Focus();
                return;
            }           
 
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, $"Password field is required");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
                lblScorePassword.Text = (txtPassword.Text.Length < 6) ? "Weak" : "Strong";
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, $"UserName field is required");
            }
            else
                errorProvider1.SetError(txtUserName, null);

            if (clsUser.IsUserExist(txtUserName.Text)&&_Mode!=enMode.Update)
            {
                MessageBox.Show("اسم المستخدم موجود بالفعل، الرجاء اختيار اسم جديد.",
                          "خطأ: اسم مكرر",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Exclamation);
                txtUserName.Clear();
                txtUserName.Focus();
            }

            return;
        }
   
    }
}
