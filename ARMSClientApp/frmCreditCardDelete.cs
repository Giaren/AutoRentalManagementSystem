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
    public partial class frmCreditCardDelete : Form
    {
        public frmCreditCardDelete()
        {
            InitializeComponent();
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
            CreditCard delete = new CreditCard();
            delete.CreditCardNumber = txtCardNumber.Text;
            delete.Delete(delete.CreditCardNumber);
            MessageBox.Show("Record Deleted");
        }
    }
}
