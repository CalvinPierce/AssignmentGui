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
    public partial class EventForm : Form
    {
        EventCoordinator eCoord;
        public EventForm()
        {
            InitializeComponent();
        }
        public EventForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }
        private void btnHomeMenuEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventForm aef = new AddEventForm(eCoord);
            aef.ShowDialog();
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            ViewEventsForm vef = new ViewEventsForm(eCoord);
            vef.ShowDialog();
        }

        private void btnViewEventDetails_Click(object sender, EventArgs e)
        {
            ViewSpecificEventForm vsef = new ViewSpecificEventForm(eCoord);
            vsef.ShowDialog();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DeleteEventForm def = new DeleteEventForm(eCoord);
            def.ShowDialog();
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
