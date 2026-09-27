using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Client
{
    public partial class frmAddNewClient : Form
    {
        private int _NewClientID = -1;
        public int ClientID { get { return _NewClientID; } set { _NewClientID = value; } }
        public frmAddNewClient()
        {
            InitializeComponent();
        }
        public void NewClientID(int ClientID)
        {
            this.ClientID = ClientID;
        }
        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            ctrlAddEditClient1.CreateNewClient();
            ctrlAddEditClient1.DataBack += NewClientID;
          }
        private void ctrlAddEditClient1_OnFinishOperation_1()
        {
            this.Close();
        }
    }
}
