using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class InvoicesEdit : Form
    {
        public InvoicesEdit()
        {
            InitializeComponent();
        }

        private void InvoicesEdit_Load(object sender, EventArgs e)
        {
            InvoicesLabel.Text = "Please select a button. If you choose to create in invoice, update " +
                "the text here using the text boxes and the 'Update Text' button before creating a new invoice for a preview.";
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtName.Text;
                fileName = fileName + ".txt";
                string vehicleInfo = txtVehicleInfo.Text;
                string laborCosts = txtLaborCosts.Text;
                string partsUsed = txtPartsUsed.Text;
                string subtotalStr = txtSubtotal.Text;
                if (!FluidCheckupCheckBox.Checked)
                {
                    string fluidCheckup = "$0.00";
                }
                else
                {
                    string fluidCheckup = "$24.99";
                }
                try
                {
                    double subtotalNum = double.Parse(txtSubtotal.Text);
                    double taxNum = subtotalNum * 0.06;
                    double totalNum = subtotalNum + taxNum;
                    string taxStr = taxNum.ToString();
                    string totalStr = totalNum.ToString();
                }
                catch
                {
                    MessageBox.Show("Please only use numbers for 'Labor Costs' and 'Subtotal.'");
                }

                StreamWriter newFile = File.CreateText(fileName);

                newFile.Close();

            }
            catch
            {
                MessageBox.Show("Please use a valid File Name");
            }
            
        }

        private void BtnViewInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateText_Click(object sender, EventArgs e)
        {
            string vehicleInfo = txtVehicleInfo.Text;
            string laborCosts = txtLaborCosts.Text;
            string partsUsed = txtPartsUsed.Text;
            string subtotalStr = txtSubtotal.Text;
            if (!FluidCheckupCheckBox.Checked)
            {
                string fluidCheckup = "$0.00";
            }
            else
            {
                string fluidCheckup = "$24.99";
            }
            try
            {
                double subtotalNum = double.Parse(txtSubtotal.Text);
                double taxNum = subtotalNum * 0.06;
                double totalNum = subtotalNum + taxNum;
                string taxStr = taxNum.ToString();
                string totalStr = totalNum.ToString();
            } catch
            {
                MessageBox.Show("Please only use numbers for 'Labor Costs' and 'Subtotal.'");
            }

            InvoicesLabel.Text = "";
        }
    }
}
