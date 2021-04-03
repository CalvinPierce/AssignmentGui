using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentGui
{
    public partial class AddCustomerForm : Form
    {
        EventCoordinator eCoord;
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        public AddCustomerForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGetFirstName.Text) || string.IsNullOrWhiteSpace(txtGetLastName.Text) || string.IsNullOrWhiteSpace(txtGetPhoneNumber.Text))
            {
                txtGetFirstName.Text = "";
                txtGetLastName.Text = "";
                txtGetPhoneNumber.Text = "";
                lblAddOutcome.Text = "Customer was not added.";
            }
            else
            {
                eCoord.addCustomer(txtGetFirstName.Text, txtGetLastName.Text, txtGetPhoneNumber.Text);
                txtGetFirstName.Text = "";
                txtGetLastName.Text = "";
                txtGetPhoneNumber.Text = "";
                lblAddOutcome.Text = "Customer successfully added.";
            }
        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(eCoord);
            cf.ShowDialog();
        }

        private void eventOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm(eCoord);
            ef.ShowDialog();
        }

        private void registrationOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(eCoord);
            rf.ShowDialog();
        }
    }
}
