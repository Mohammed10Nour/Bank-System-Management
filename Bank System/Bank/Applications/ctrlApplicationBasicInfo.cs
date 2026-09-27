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
    public partial class ctrlApplicationBasicInfo : UserControl
    {    
        public clsApplication.enApplicationType enAppType { get; set; }
        public void LoadApplicationData()
        {   
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;
            lblDate.Text = DateTime.Now.ToString("dd-mm-yyyy");
            lblStatus.Text = clsApplication.enApplicationStatus.New.ToString();
            lblType.Text = enAppType.ToString();
            lblFees.Text = clsApplicationType.FindApplicationTypeByApplicationTypeId((byte)enAppType).Fees.ToString();
        }
        public void UpdateApplicationData(int ApplicationID,clsApplication.enApplicationStatus ApplicationStatus)
        {
            lblApplicationID.Text = ApplicationID.ToString();
            lblStatus.Text = ApplicationStatus.ToString();
        }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }
    }
}
