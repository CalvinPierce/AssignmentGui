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
    public partial class RegistrationForm : Form
    {
        EventCoordinator eCoord;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public RegistrationForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void btnHomeMenuReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewRegs_Click(object sender, EventArgs e)
        {
            ViewRegistrationsForm vrf = new ViewRegistrationsForm(eCoord);
            vrf.ShowDialog();
        }

        private void btnRegEvent_Click(object sender, EventArgs e)
        {
            AddRegistrationForm arf = new AddRegistrationForm(eCoord);
            arf.ShowDialog();
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
