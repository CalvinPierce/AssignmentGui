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
    public partial class AddEventForm : Form
    {
        EventCoordinator eCoord;
        public AddEventForm()
        {
            InitializeComponent();
        }
        public AddEventForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            txtGetDay.Text = "Must be between 1 and 31";
            txtGetMonth.Text = "Must be between 1 and 12";
            txtGetYear.Text = "Must be current year or higher";
            txtGetHour.Text = "Must be between 0 and 23";
            txtGetMinute.Text = "Must be between 0 and 59";
        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Date eventDate;
            if (string.IsNullOrWhiteSpace(txtGetName.Text) || string.IsNullOrWhiteSpace(txtGetVenue.Text) || string.IsNullOrWhiteSpace(txtGetDay.Text)
                || string.IsNullOrWhiteSpace(txtGetMonth.Text) || string.IsNullOrWhiteSpace(txtGetYear.Text) || string.IsNullOrWhiteSpace(txtGetHour.Text)
                || string.IsNullOrWhiteSpace(txtGetMinute.Text) || string.IsNullOrWhiteSpace(txtGetMax.Text))
            {
                txtGetName.Text = "";
                txtGetVenue.Text = "";
                txtGetDay.Text = "Must be between 1 and 31";
                txtGetMonth.Text = "Must be between 1 and 12";
                txtGetYear.Text = "Must be current year or higher";
                txtGetHour.Text = "Must be between 0 and 23";
                txtGetMinute.Text = "Must be between 0 and 59";
                txtGetMax.Text = "";
                lblAddOutcome.Text = "Event not added.";
            }
            else
            {
                int maxAttendee = Convert.ToInt32(txtGetMax.Text);
                eventDate = new Date(Convert.ToInt32(txtGetDay.Text), Convert.ToInt32(txtGetMonth.Text), Convert.ToInt32(txtGetYear.Text), Convert.ToInt32(txtGetHour.Text), Convert.ToInt32(txtGetMinute.Text));
                eCoord.addEvent(txtGetName.Text, txtGetVenue.Text, eventDate, maxAttendee);
                lblAddOutcome.Text = "Event successfully added.";
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
