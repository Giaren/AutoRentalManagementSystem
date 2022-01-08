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
    public partial class frmCreditCardRegistration : Form
    {
        public frmCreditCardRegistration()
        {
            InitializeComponent();
        }
        private void frmCreditCardRegistration_Load(object sender, EventArgs e)
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
            dtpExpDate.Format = DateTimePickerFormat.Custom;
            dtpExpDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
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
            CreditCard Insert = new CreditCard(txtCardNumber.Text, txtCardOwnerName.Text, txtCreditCardCompany.Text, dtpExpDate.Value.ToShortDateString(), txtAddress1.Text, txtAddress2.Text
                    , txtCity.Text, cbState.Text, txtZipCodeNumber.Text, cbCountry.Text, Convert.ToDecimal(txtCreditCardlimit.Text), Convert.ToDecimal(txtCreditCardBalance.Text));

            Insert.Insert();
            MessageBox.Show("Credit Card Registereds");
        }

        private void dtpExpDate_ValueChanged(object sender, EventArgs e)
        {

        }
        //Other Event Handler in this Form such as Apply_Click, Exit_Click etc.
    } //End of Form Class
} //End of Namespace