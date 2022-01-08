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
using System.IO;

namespace ARMSClientApp
{
    public partial class frmCreditCardSearch : Form
    {
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCreditCardSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CreditCard search = new CreditCard();
            search.CreditCardNumber = txtCardNumberSearch.Text;
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
            txtActivationStatus.Text = search.ActivationStatus.ToString();
            cbCountry.Text = search.Country;
            cbState.Text = search.StateCode;
            dtpExpDate.Text = search.ExpDate.ToString();



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = @"Network_Printer.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Credit Card Information:");
                    sw.WriteLine("");

                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Credit Card Number= " + txtCreditCardNumber.Text);
                sw.WriteLine("Credit Card Owner Name= "+ txtCardOwner.Text);
                sw.WriteLine("Merchant Company Name= " + txtCardCompany.Text);
                sw.WriteLine("Expiration Date= " + dtpExpDate.Text);
                sw.WriteLine("Billing Address 1= " + txtAddressLine1.Text);
                sw.WriteLine("Billing Address 2= " + txtAddressLine2.Text);
                sw.WriteLine("City= " + txtCity.Text);
                sw.WriteLine("State= " + cbState.Text);
                sw.WriteLine("ZipCode= " + txtZipCode.Text);
                sw.WriteLine("Country= " + cbCountry.Text);
                sw.WriteLine("Credit Card Limit= " + txtCreditCardLimit.Text);
                sw.WriteLine("Credit Card Balance= " + txtCreditLimitBalance.Text);
                sw.WriteLine("Activation Status= " + txtActivationStatus.Text);

                sw.WriteLine("");
                sw.WriteLine("");
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            MessageBox.Show("Record saved");
        }
    }
}
