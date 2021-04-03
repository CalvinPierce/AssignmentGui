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
    public partial class ViewSpecificEventForm : Form
    {
        EventCoordinator eCoord;
        public ViewSpecificEventForm()
        {
            InitializeComponent();
        }
        public ViewSpecificEventForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
            txtViewEvents.Text = eCoord.eventList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomeMenuEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewEvent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtGetId.Text);
            txtViewEvents.Text = eCoord.getEventInfoById(id);
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
