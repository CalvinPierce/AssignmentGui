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
    public partial class CustomerForm : Form
    {
        EventCoordinator eCoord;
        public CustomerForm()
        {
            InitializeComponent();
        }
        public CustomerForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
        }

        private void btnHomeMenuCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AddCustomerForm acf = new AddCustomerForm(eCoord);
            acf.ShowDialog();
        }

        private void btnViewCust_Click(object sender, EventArgs e)
        {
            ViewCustomersForm vcf = new ViewCustomersForm(eCoord);
            vcf.ShowDialog();
        }

        private void btnViewCustDetails_Click(object sender, EventArgs e)
        {
            ViewSpecificCustomerForm vscf = new ViewSpecificCustomerForm(eCoord);
            vscf.ShowDialog();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm dcf = new DeleteCustomerForm(eCoord);
            dcf.ShowDialog();
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
