using Business_Layer;
using System;
using System.CodeDom;
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

namespace Bank.Client
{
    public partial class frmListClients : Form
    {
        public static DataTable _AllData = clsClient.GetAllData();// contain all data from data base 
        private DataTable _dtAllClient = _AllData.DefaultView.ToTable(false, "ClientID", "NationalNo", "FullName", "DateOfBirth", "GenderCaption", "CountryName");
        public frmListClients()
        {
            InitializeComponent();
        }
       

        private void frmListClients_Load_1(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _AllData = clsClient.GetAllData();
            _dtAllClient = _AllData.DefaultView.ToTable(false, "ClientID", "NationalNo", "FullName", "DateOfBirth", "GenderCaption", "CountryName");
            dgvAllClients.DataSource = _dtAllClient;

            dgvAllClients.Columns[0].HeaderText = "Client ID";
            dgvAllClients.Columns[0].Width = 100;

            dgvAllClients.Columns[1].HeaderText = "   National NO";
            dgvAllClients.Columns[1].Width = 120;

            dgvAllClients.Columns[2].HeaderText = " Full Name";
            dgvAllClients.Columns[2].Width = 220;

            dgvAllClients.Columns[3].HeaderText = "Date Of Birth";
            dgvAllClients.Columns[3].Width = 125;

            dgvAllClients.Columns[4].HeaderText = "Gender Caption";
            dgvAllClients.Columns[4].Width = 120;

            dgvAllClients.Columns[5].HeaderText = "Country";
            dgvAllClients.Columns[5].Width = 135;


        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
        
            string FilterBy = "";
            switch (cbFilterBy.Text)
            {
                case "Client ID":
                    {
                        FilterBy = "ClientID";
                        break;
                    }
                case "National No":
                    {
                        FilterBy = "NationalNo";
                        break;
                    }
                case "Full Name":
                    {
                        FilterBy = "FullName";
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
                _dtAllClient.DefaultView.RowFilter = " ";
            }
            else if (FilterBy == "ClientID")
            {
                if(string.IsNullOrEmpty(txtFilterValue .Text ))
                {
                    _dtAllClient.DefaultView.RowFilter = " ";
                }
               else  _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, txtFilterValue.Text.Trim());
            }
            else
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBy, txtFilterValue.Text.Trim());


        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Client ID")
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewClient();
            frm.ShowDialog();
            frmListClients_Load_1(null, null);
            
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditClient((int)dgvAllClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClients_Load_1(null, null);
        }

        private void showClientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmClientInfo((int)dgvAllClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListClients_Load_1(null, null);
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
     $"Are you sure you want to delete client with ID = {(int)dgvAllClients.CurrentRow.Cells[0].Value} ?",
     "Confirm Delete",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (clsClient.DeleteClient((int)dgvAllClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(
                        "Client deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    frmListClients_Load_1(null, null);
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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
        }
    }
}
