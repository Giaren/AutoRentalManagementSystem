using System;
using ARMSBOLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARMSClientApp
{
    public partial class frmCreditCardUpdate : Form
    {
        public frmCreditCardUpdate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
           
            CreditCard update = new CreditCard(txtCreditCardSearch.Text, txtCardOwner.Text, txtCardCompany.Text, dtpExpDate.Value.ToShortDateString(), txtAddressLine1.Text, txtAddressLine2.Text
                    , txtCity.Text, cbState.Text, txtZipCode.Text, cbCountry.Text, Convert.ToDecimal(txtCreditCardLimit.Text), Convert.ToDecimal(txtCreditLimitBalance.Text));

            update.Update();
            MessageBox.Show("Record Updated");

        }

        private void frmCreditCardUpdate_Load(object sender, EventArgs e)
        {
            //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
            cbState.DataSource = USState.GetAllUSStates();
            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property is GOTTEN to used in the code
            cbState.DisplayMember = "StateCode";
            cbState.ValueMember = "StateCode"; //in this case we return the state code
                                               //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
            cbCountry.DataSource = Country.GetAllCountries();
            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property is GOTTEN to used in the code
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryName"; //in this case we return the country name
                                                   //setting activation status property to activated programmatically
            cbActivationStatus.Text = "Activated";
            //Other Code needed insided the Form_Loa()Event Handler

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

            CreditCard search = new CreditCard();
            search.CreditCardNumber = txtCreditCardSearch.Text;
            search.Load(search.CreditCardNumber);
            txtCardOwner.Text = search.CreditCardOwnerName;
            txtCreditCardNumber.Text = search.CreditCardNumber;
            txtCity.Text = search.City;
            txtCreditCardLimit.Text = search.CreditCardLimit.ToString();
            txtCreditLimitBalance.Text = search.CreditCardLimit.ToString();
            txtZipCode.Text = search.ZipCode;
            txtCardCompany.Text = search.CreditCardCompany;
            txtAddressLine1.Text = search.AddressLine1;
            txtAddressLine2.Text = search.AddressLine2;
            cbActivationStatus.Text = search.ActivationStatus.ToString();
            cbCountry.Text = search.Country;
            cbState.Text = search.StateCode;
            dtpExpDate.Text = search.ExpDate.ToString();

        }
    }
}
