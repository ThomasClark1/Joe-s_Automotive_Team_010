using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            CustomerEdit customerEdit = new CustomerEdit();
            customerEdit.Show();
        }

        private void btnCustomersView_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.Show();
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
        {
            InvoicesEdit invoicesEdit = new InvoicesEdit();
            invoicesEdit.Show();
        }

        private void btnInvoicesView_Click(object sender, EventArgs e)
        {
            InvoicesEdit invoicesEdit = new InvoicesEdit();
            invoicesEdit.Show();
        }

        private void btnVehiclesEdit_Click(object sender, EventArgs e)
        {
            VehiclesEdit vehiclesEdit = new VehiclesEdit();
            vehiclesEdit.Show();
        }

        private void btnVehiclesView_Click(object sender, EventArgs e)
        {
            VehicleView vehiclesView = new VehicleView();
            vehiclesView.Show();
        }

        private void btnPartsEdit_Click(object sender, EventArgs e)
        {
            PartsEdit partsEdit = new PartsEdit();
            partsEdit.Show();
        }

        private void btnPartsView_Click(object sender, EventArgs e)
        {
            PartsView partsView = new PartsView();
            partsView.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
