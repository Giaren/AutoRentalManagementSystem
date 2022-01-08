using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //Declare object of ERP Form
            frmCreditCardList objERP = new frmCreditCardList();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();
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
            //Declare object of ERP Form
            frmCreditCardSearch objERP = new frmCreditCardSearch();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //Declare object of ERP Form
            frmCreditCardRegistration objERP = new frmCreditCardRegistration();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Declare object of ERP Form
            frmCreditCardUpdate objERP = new frmCreditCardUpdate();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Declare object of ERP Form
            frmCreditCardDelete objERP = new frmCreditCardDelete();
            //Hide this form (frmMainWelcomeForm)
            this.Hide();
            //Display ERP System Form as Dialog Form
            //Dialog mode means program flow will STOP until the
            //Customer Management form Closes or Hides 
            objERP.ShowDialog();
            //Once the ERP System Form closes or hides,
            //Control goes back to this form and this form 
            //needs to Display itself since ERP System Form is
            //either hidden or cloased.
            this.Show();
        }
    }
}
