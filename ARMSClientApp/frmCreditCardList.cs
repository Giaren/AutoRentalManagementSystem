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
    public partial class frmCreditCardList : Form
    {
        public frmCreditCardList()
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
        private void frmCreditCardList_Load(object sender, EventArgs e)
        {
            dgvCreditCardList.AutoGenerateColumns = true;
        }

        private void dgvCreditCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListCreditCards_Click(object sender, EventArgs e)
        {
            string constring = "Data Source =.\\SQLExpress; Initial Catalog = RentalDB; Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CreditCard", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvCreditCardList.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //Close this form
            //program flow automatically goes back to Main Form
            //which opened this form aa a dialog form.
            this.Close();
        }
    } //End of Form Class
} //End of Namespace