using Business_Layer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Accounts
{
    public partial class frmListAccounts : Form
    {
        public static DataTable _AllData = clsAccount.GetAllData();// contain all data from data base 
        private DataTable _dtAllAccounts = _AllData.DefaultView.ToTable(false,"AccountID","AccountNumber","AccountName","ClientName","Balance","AccountState","UpdatedAt");
        public frmListAccounts()
        {
            InitializeComponent();

        }
        private void frmListAccounts_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _AllData = clsAccount.GetAllData();
            _dtAllAccounts = _AllData.DefaultView.ToTable(false, "AccountID", "AccountNumber", "AccountName", "ClientName", "Balance", "AccountState", "UpdatedAt");

            dgvAllAccounts.DataSource = _dtAllAccounts;

            dgvAllAccounts.Columns[0].HeaderText = "ID ";
            dgvAllAccounts.Columns[0].Width = 80;

            dgvAllAccounts.Columns[1].HeaderText = "Account Number";
            dgvAllAccounts.Columns[1].Width = 130;
                 
            dgvAllAccounts.Columns[2].HeaderText = "Account Name";
            dgvAllAccounts.Columns[2].Width =145;
                
            dgvAllAccounts.Columns[3].HeaderText = "Client Name";
            dgvAllAccounts.Columns[3].Width = 230;
                
            dgvAllAccounts.Columns[4].HeaderText = "Balance";
            dgvAllAccounts.Columns[4].Width = 120;
                 
            dgvAllAccounts.Columns[5].HeaderText = "Account State";
            dgvAllAccounts.Columns[5].Width = 85;
        
            dgvAllAccounts.Columns[6].HeaderText = "Updated At";
            dgvAllAccounts.Columns[6].Width = 120;

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
           string FilterBy = "";
            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    {
                        FilterBy = "AccountID";
                        break;
                    }               
                case "Account Number":
                    {
                        FilterBy = "AccountNumber";
                        break;
                    }
                case "Client Name":
                    {
                        FilterBy = "ClientName";
                        break;
                    }
                case "Account Name":
                    {
                        FilterBy = "AccountName";
                        break;
                    }

                default:
                    {
                        FilterBy = "None";
                        break;
                    }


            }

            if (string.IsNullOrEmpty(FilterBy) || FilterBy == "None")
            {
                _dtAllAccounts.DefaultView.RowFilter = " ";
            }
            else if (FilterBy == "AccountID"||FilterBy=="AccountNumber")
            {
                if (string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _dtAllAccounts.DefaultView.RowFilter = " ";
                }
                else
                    _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, txtFilterValue.Text.Trim());
            }
            else
                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBy, txtFilterValue.Text.Trim());

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Account ID"|| cbFilterBy.Text=="Account Number")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void cbFilterByAccountState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = "All";
            string FilterColumn = "NewAccountState";
            switch (cbFilterByAccountState.Text)
            {
                case "Active":
                    {
                        FilterValue = "Active";
                        break;
                    }
                case "Forzen":
                    {
                        FilterValue = "Forzen";
                        break;
                    }
                case "Closed":
                    {
                        FilterValue = "Closed";
                        break;
                    }
            }
            if (FilterValue == "All")
            {
                _dtAllAccounts.DefaultView.RowFilter = " ";
            }
            else 
            {

                _dtAllAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, FilterValue);
            }
           
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            cbFilterByAccountState.Visible = (cbFilterBy.Text == "Account State");
            txtFilterValue.Visible = (cbFilterBy.Text == "None" || cbFilterBy.Text == "Account State") ? false : true;

        }

        private void showAccountInformation_Click(object sender, EventArgs e)
        {
            Form frm = new frmAccountInfo((int)dgvAllAccounts.CurrentRow.Cells[0].Value);//, (string)dgvAllAccounts.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditAccount();
            frm.ShowDialog();
            frmListAccounts_Load(null, null);
        }

        private void editAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditAccount((int)dgvAllAccounts.CurrentRow.Cells[0].Value);//, (string)dgvAllAccounts.CurrentRow.Cells[2].Value);
            frm.ShowDialog();
            frmListAccounts_Load(null, null);
        }

        private void deleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
$"Are you sure you want to delete Account with ID = {(int)dgvAllAccounts.CurrentRow.Cells[0].Value} ?",
"Confirm Delete",
MessageBoxButtons.YesNo,
MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (clsAccount.DeleteAccount((int)dgvAllAccounts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(
                        "Account deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    frmListAccounts_Load(null, null);
                }
                else
                {
                    MessageBox.Show(
                        "Account could not be deleted.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
