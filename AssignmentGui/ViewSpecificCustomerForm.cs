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
    public partial class ViewSpecificCustomerForm : Form
    {
        EventCoordinator eCoord;
        public ViewSpecificCustomerForm()
        {
            InitializeComponent();
        }
        public ViewSpecificCustomerForm(EventCoordinator ec)
        {
            eCoord = ec;
            InitializeComponent();
            txtViewCustomers.Text = eCoord.customerList();
        }

        private void ViewSpecificCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHomeMenuCust_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtGetId.Text);
            txtViewCustomers.Text = eCoord.getCustomerInfoById(id);
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
