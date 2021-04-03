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
    public partial class DeleteEventForm : Form
    {
        EventCoordinator eCoord;
        public DeleteEventForm()
        {
            InitializeComponent();
        }
        public DeleteEventForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteEventForm_Load(object sender, EventArgs e)
        {
            txtViewEvent.Text = eCoord.eventList();
        }

        private void btnHomeMenuCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtGetId.Text);
            if (eCoord.deleteEvent(id))
            {
                txtViewEvent.Text = "Event with id " + id + " deleted.";
            }
            else
            {
                txtViewEvent.Text = "Event with id " + id + " was not found.";
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
