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
    public partial class AddRegistrationForm : Form
    {
        EventCoordinator eCoord;
        public AddRegistrationForm()
        {
            InitializeComponent();
        }
        public AddRegistrationForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRegistrationForm_Load(object sender, EventArgs e)
        {
            txtInfoList.Text = eCoord.customerList() + eCoord.eventList();
        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGetCustId.Text) || string.IsNullOrWhiteSpace(txtGetEventId.Text))
            {
                txtGetCustId.Text = "";
                txtGetEventId.Text = "";
                lblAddOutcome.Text = "Registration Unsuccessful";
            }
            else
            {
                int custId = Convert.ToInt32(txtGetCustId.Text);
                int eventId = Convert.ToInt32(txtGetEventId.Text);
                eCoord.rsvpConfirmation(custId, eventId);
                txtGetCustId.Text = "";
                txtGetEventId.Text = "";
                lblAddOutcome.Text = "Attendee Registration Successful";
            }
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
