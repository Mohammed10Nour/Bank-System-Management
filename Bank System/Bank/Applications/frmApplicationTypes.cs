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

namespace Bank.Applications
{
    public partial class frmApplicationTypes : Form
    {
        private static DataTable _AllApplicationTypes = clsApplicationType.GetAllData();

        public frmApplicationTypes()
        {
            InitializeComponent();
        }
      

        private void frmApplicationTypes2_Load(object sender, EventArgs e)
        {
            _AllApplicationTypes = clsApplicationType.GetAllData();
            _AllApplicationTypes = _AllApplicationTypes.DefaultView.ToTable(false, "ApplicationTypeId", "Description", "Fees");

            dgvAllApplicationTypes.DataSource = _AllApplicationTypes;

            dgvAllApplicationTypes.Columns[0].HeaderText = "Application Type ID";
            dgvAllApplicationTypes.Columns[0].Width = 180;

            dgvAllApplicationTypes.Columns[1].HeaderText = "Description";
            dgvAllApplicationTypes.Columns[1].Width = 300;

            dgvAllApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvAllApplicationTypes.Columns[2].Width = 196;
        }
    }
}
