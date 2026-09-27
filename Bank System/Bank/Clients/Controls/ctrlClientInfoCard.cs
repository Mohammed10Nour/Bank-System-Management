using Bank.Properties;
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

namespace Bank.Client.Controls
{
    public partial class ctrlClientInfoCard : UserControl
    {
        private int _ClientID = -1;
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

        private string _NationalNo = "";
        public string NationalNo
        {
            get { return _NationalNo; }
            set { _NationalNo = value; }
        }
        public clsClient Client { get; set; }
        private void _LoadData()
        {
            ClientID = Client.ClientID;
            lblClientID.Text = Client.ClientID.ToString();
            lblFullName.Text = Client.FullName;
            lblNationalNo.Text = Client.NationalNo;
            lblBirthDate.Text = Client.DateOfBirth.ToString();
            lblEmail.Text = Client.ContactInformation.Email;
            lblPhone.Text = Client.ContactInformation.Phone;
            lblGender.Text = (Client.Gender == false) ? "Male" : "Female";
        
            if (!string.IsNullOrEmpty(Client.ImagePath))
               pbClientImage.ImageLocation = Client.ImagePath;
            else
                pbClientImage.Image =
                    Client.Gender == false
                    ? Resources.icons8_person_100
                    : Resources.icons8_Female_100__1_;

            lblCountry.Text = Client.Country.CountryName;
            lblDialingCode.Text = Client.Country.DialingCode;
        }
        private void _ResetControls()
        {
            
            ClientID = -1;
            lblClientID.Text = "????";
            lblFullName.Text = "????";
            lblNationalNo.Text = "????";
            lblBirthDate.Text = "????";
            lblEmail.Text = "????";
            lblPhone.Text = "????";
            lblGender.Text = "????";
            pbClientImage.Image = Resources.icons8_person_100;       
            lblCountry.Text = "????";
            lblDialingCode.Text = "????";
        }
        public bool GetClientInfoByClientID()
        {
            Client = clsClient.FindClientByClientID(ClientID);
            if (Client == null)
            {
                MessageBox.Show("Client not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetControls();
                return false;
            }
            _LoadData();
            return true;
        }
        public bool GetClientInfoByNationalNo()
        {
            Client = clsClient.FindClientByNationalNo(NationalNo);
            if (Client == null)
            {
                MessageBox.Show("Client not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetControls();
                return false;
            }
            _LoadData();
            return true;
        }
        public ctrlClientInfoCard()
        {
            InitializeComponent();
        }
        private void lblEditInformatin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_ClientID == -1)
                return;
            Form frm = new frmEditClient(ClientID);
            frm.ShowDialog();
            GetClientInfoByClientID();
        }
    }
}
