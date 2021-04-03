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
    public partial class Form1 : Form
    {
        EventCoordinator eCoord;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomeExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustMenu_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(eCoord);
            cf.ShowDialog();
        }

        private void customerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm(eCoord);
            cf.ShowDialog();
        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm(eCoord);
            ef.ShowDialog();
        }

        private void eventOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm ef = new EventForm(eCoord);
            ef.ShowDialog();
        }

        private void btnRegMenu_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(eCoord);
            rf.ShowDialog();
        }

        private void registrationOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(eCoord);
            rf.ShowDialog();
        }
    }
}
