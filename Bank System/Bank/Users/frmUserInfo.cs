using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Users
{
    public partial class frmUserInfo : Form
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
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            ctrlUserCardInfo1.UserID = UserID;
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
           if( ctrlUserCardInfo1.LoadData())
            {
                ctrlClientInfoCard1.ClientID = ctrlUserCardInfo1.User.ClientID;
                ctrlClientInfoCard1.GetClientInfoByClientID();
            }
        }
    }
}
