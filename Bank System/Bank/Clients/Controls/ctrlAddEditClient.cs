using Bank.Global_Class;
using Bank.Properties;
using Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bank.Client.Controls
{
    public partial class ctrlAddEditClient : UserControl
    {
        public delegate void DataBackEventHandler(int ClientID);

        public event DataBackEventHandler DataBack;

        private enum enMode { AddNew = 0, Update }
        private enMode _Mode = enMode.AddNew;

        public event Action OnFinishOperation;
        protected virtual void FinishSelected(int PersonID)
        {
            Action handler = OnFinishOperation;
            if (handler != null)
            {
                handler(); // Raise the event with the parameter
            }
        }
    
        private int _ClientID = -1;
        public int ClientID
        { 
            get
            {
                return _ClientID;
            } 
            set {
                _ClientID = value;
            }
        }
        public clsClient Client { get; set; }

        private DataTable _dtCountries = new DataTable();

        private void _FillComboBoxWithCountryInformation()
        {
            _dtCountries = clsCountry.GetAllData();

            foreach (DataRow row in _dtCountries.Rows)
                cbCountry.Items.Add(row["CountryName"].ToString());

            cbCountry.SelectedIndex = cbCountry.FindString("Syria");
        }

        public void CreateNewClient()
        {
            Client = new clsClient();
            _Mode = enMode.AddNew;
        }

        public void LoadData()
        {
            Client = clsClient.FindClientByClientID(ClientID);

            if (Client == null)
            {
                MessageBox.Show("Client object not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Mode = enMode.Update;
            _LoadDataFromObjectToControls();
        }

        private bool _HandleImage()
        {
            if (Client.ImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(Client.ImagePath))
                {
                    try
                    {
                        File.Delete(Client.ImagePath);
                    }
                    catch { }
                }

                if (!string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                {
                    string SourceImage = pbPersonImage.ImageLocation;

                    if (clsUtil.CopyeImageFromCurrentFolderToSpecialFolder(ref SourceImage))
                        pbPersonImage.ImageLocation = SourceImage;
                    else
                        return false;
                }
            }

            return true;
        }

        private void _LoadDataFromControlsToObject()
        {
            Client.FullName = txtFullName.Text;
            Client.NationalNo = txtNationalNo.Text;
            Client.Gender = (cbGender.SelectedItem.ToString() == "Male") ? false : true;
            Client.DateOfBirth = dtpDateOfBirth.Value;
            Client.Address = txtAddress.Text;

            Client.ImagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation)
                ? null
                : pbPersonImage.ImageLocation;

            Client.ContactInformation.Phone = txtPhone.Text;
            Client.ContactInformation.Email = txtEmail.Text;

            Client.NationalityID =
                clsCountry.FindCountryByCountryName(
                    cbCountry.SelectedItem.ToString()
                ).CountryID;
        }

        private void _LoadDataFromObjectToControls()
        {
            txtFullName.Text = Client.FullName;
            txtNationalNo.Text = Client.NationalNo;
            dtpDateOfBirth.Value = Client.DateOfBirth;
            txtAddress.Text = Client.Address;

            cbGender.SelectedIndex = (Client.Gender == false) ? 0 : 1;

            if (!string.IsNullOrEmpty(Client.ImagePath))
                pbPersonImage.ImageLocation = Client.ImagePath;
            else
                pbPersonImage.Image =
                    Client.Gender == false
                    ? Resources.icons8_person_100
                    : Resources.icons8_Female_100__1_;

            txtPhone.Text = Client.ContactInformation.Phone;
            txtEmail.Text = Client.ContactInformation.Email;

            cbCountry.Text = Client.Country.CountryName;
            txtDialingCode.Text = Client.Country.DialingCode;
        }

        public ctrlAddEditClient()
        {
            InitializeComponent();
            _FillComboBoxWithCountryInformation();
        }

        private void ctrlAddEditClient_Load(object sender, EventArgs e)
        {
            txtFullName.Select();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!_HandleImage())
                return;

            _LoadDataFromControlsToObject();

            if (Client.ContactInformation.Save())
            {
                Client.ContactInfoID = Client.ContactInformation.CInfoID;

                if (Client.Save())
                {
                    if (_Mode == enMode.AddNew)
                    {
                        MessageBox.Show(
                            $"New client has been added successfully with ID: {Client.ClientID}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        if (OnFinishOperation!= null)                           
                            OnFinishOperation();
                        DataBack?.Invoke(Client.ClientID);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Client data has been updated successfully for ID: {Client.ClientID}",
                            "Update Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show(
                        "Failed to save client",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(txtNationalNo,
                    "!يجب ملأ هذا الحقل أولاً");
                return;
            }

            bool exists =
                clsClient.IsClientExist(txtNationalNo.Text.Trim());

            if (txtNationalNo.Text != Client.NationalNo && exists)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo,
                    "!هذا الرقم مستخدم");
                    }
            else
                errorProvider1.SetError(txtNationalNo, null);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName,
                    "!يجب ملأ هذا الحقل أولاً");
                
            }
            else
                errorProvider1.SetError(txtFullName, null);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone,
                    "!يجب ملأ هذا الحقل أولاً");
                
                return;
            }

            if (!clsValidate.ValidatePhone(txtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone,
                    "!رقم غير صالح");
               
            }

            else
                errorProvider1.SetError(txtPhone, null);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail,
                    "!يجب ملأ هذا الحقل أولاً");
                
                return;
            }

            if (!clsValidate.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail,
                    "!إيميل غير صالح");
                
            }
            else
                errorProvider1.SetError(txtEmail, null);
        }

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cbCountry.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbCountry,
                    "!اختر دولة");
              
            }
            else
                errorProvider1.SetError(cbCountry, null);
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow c in _dtCountries.Rows)
            {
                if (c["CountryName"].ToString()
                    == cbCountry.SelectedItem?.ToString())
                {
                    txtDialingCode.Text =
                        c["DialingCode"].ToString();
                }
            }
        }

        private void llSetImage_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation =
                    openFileDialog1.FileName;

                lbRemoveImage.Visible = true;
            }
        }

        private void lbRemoveImage_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.Image =
                Resources.icons8_person_100;

            lbRemoveImage.Visible = false;
        }

        private void cbGender_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            pbPersonImage.Image =
                cbGender.SelectedItem.ToString() == "Male"
                ? Resources.icons8_person_100
                : Resources.icons8_Female_100__1_;
        }
    }
}