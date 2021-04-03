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
    public partial class ViewRegistrationsForm : Form
    {
        EventCoordinator eCoord;
        public ViewRegistrationsForm()
        {
            InitializeComponent();
        }
        public ViewRegistrationsForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomeMenuReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRegistrationsForm_Load(object sender, EventArgs e)
        {
            txtViewReg.Text = eCoord.getRSVPconfList();
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
