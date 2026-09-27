using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bank.Users
{
    public partial class frmListUsers : Form
    {
        public static DataTable _AllData = clsUser.GetAllData();// contain all data from data base 
        private DataTable _dtAllUsers = _AllData.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive", "RoleName");
        public frmListUsers()
        {
            InitializeComponent();
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbFilterByIsActive.SelectedIndex = 0;
            cbFilterByIsAdmin.SelectedIndex = 0;
            _AllData = clsUser.GetAllData();
            _dtAllUsers = _AllData.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive", "RoleName");
            dgvAllUsers.DataSource = _dtAllUsers;

            dgvAllUsers.Columns[0].HeaderText = "User ID";
            dgvAllUsers.Columns[0].Width = 90;

            dgvAllUsers.Columns[1].HeaderText = "Full Name";
            dgvAllUsers.Columns[1].Width = 200;

            dgvAllUsers.Columns[2].HeaderText = "User Name";
            dgvAllUsers.Columns[2].Width = 193;

            dgvAllUsers.Columns[3].HeaderText = "Is Active";
            dgvAllUsers.Columns[3].Width = 85;

            dgvAllUsers.Columns[4].HeaderText = "User Role";
            dgvAllUsers.Columns[4].Width = 105;


        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            cbFilterByIsActive.Visible = (cbFilterBy.Text == "Is Active");
            cbFilterByIsAdmin.Visible = (cbFilterBy.Text == "User Role");
            txtFilterValue.Visible = (cbFilterBy.Text == "None" || cbFilterBy.Text == "Is Active" || cbFilterBy.Text == "User Role") ? false : true;

        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "None";
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    {
                        FilterBy = "UserID";
                        break;
                    }
                case "Full Name":
                    {
                        FilterBy = "FullName";
                        break;
                    }
                case "User Name":
                    {
                        FilterBy = "UserName";
                        break;
                    }

            }

            if (string.IsNullOrEmpty(FilterBy) || FilterBy == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                return;
            }
            if (FilterBy != "UserID")
            {
                _dtAllUsers.DefaultView.RowFilter = $"{FilterBy} LIKE '{txtFilterValue.Text.Trim()}";
            }

            else
            {
                if (string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtAllUsers.DefaultView.RowFilter = "";
                }
                else _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, txtFilterValue.Text.Trim());
            }

        }
        private void cbFilterByIsAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {


            string FilterValue = "";
            string FilterColumn = "RoleName";
            switch (cbFilterByIsAdmin.Text)
            {
                case "Admin User":
                    {
                        FilterValue = "Admin User";
                        break;
                    }
                case "Regular User":
                    {
                        FilterValue = "Regular User";
                        break;
                    }
            }
            if (FilterValue == "" || FilterValue == "All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
            }
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] Like '%{1}'", FilterColumn, FilterValue);


        }
        private void cbFilterByIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = "All";
            string FilterColumn = "IsActive";
            switch (cbFilterByIsActive.Text)
            {
                case "Is Active":
                    {
                        FilterValue = "1";
                        break;
                    }
                case "Is Not Active":
                    {
                        FilterValue = "0";
                        break;
                    }
            }
            if (FilterValue == "All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
            }
            else if (FilterValue == "1")
            {

                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            }
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {0}", FilterColumn, FilterValue);
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID")
                e.Handled = (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back);
        }
        private void editUserItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.hasPermission((int)clsUser.enPermission.AddEditUsers))
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية إجراء هذه العملية.",
                "تنبيه الصلاحيات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            Form frm = new frmAddEditUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.hasPermission((int)clsUser.enPermission.AddEditUsers))
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية إجراء هذه العملية.",
                "تنبيه الصلاحيات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            Form frm = new frmAddEditUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }
        private void showUserInfoItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.hasPermission((int)clsUser.enPermission.ShowDetailsUsersInformation))
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية إجراء هذه العملية.",
                "تنبيه الصلاحيات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            Form frm = new frmUserInfo((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.Show();
            frmListUsers_Load(null, null);
        }
        private void deleteUserItem_Click(object sender, EventArgs e)
        {
            if ((int)dgvAllUsers.CurrentRow.Cells[0].Value==clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("لا يمكنك حذف حسابك نفسه أثناء تسجيل الدخول.",
                                "عملية غير مسموحة",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!clsGlobal.hasPermission((int)clsUser.enPermission.DeleteUsers))
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية إجراء هذه العملية.",
                "تنبيه الصلاحيات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
    $"Are you sure you want to delete client with ID = {(int)dgvAllUsers.CurrentRow.Cells[0].Value} ?",
    "Confirm Delete",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((int)dgvAllUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(
                        "Client deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);
                }
                else
                {
                    MessageBox.Show(
                        "Client could not be deleted.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }
}

