using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Client
{
    public partial class frmEditClient : Form
    {
        private int _ClientID;
        public int ClientID
        {
            get
            {
                return _ClientID;
            }
            set
            {
                _ClientID = value;
            }
        }
        public frmEditClient(int ClientID)
        {
            InitializeComponent();
            ctrlAddEditClient1.ClientID = ClientID;
        }

        private void frmEditClient_Load(object sender, EventArgs e)
        {
            ctrlAddEditClient1.LoadData();
        }
    }
}
