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
                "the text here using the text boxes and the 'Update Text' button before creating a new invoice for a preview. Use 'File Name' for both " +
                "naming your invoice file and selecting the file name of the invoice you would like to open.";
        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtName.Text + ".txt";
                string vehicleInfo = txtVehicleInfo.Text;
                string laborCosts = txtLaborCosts.Text;
                string partsUsed = txtPartsUsed.Text;
                string subtotalStr = txtSubtotal.Text;
                string fluidCheckup;
                if (!FluidCheckupCheckBox.Checked)
                {
                    fluidCheckup = "$0.00";
                }
                else
                {
                    fluidCheckup = "$24.99";
                }
                double subtotalNum = double.Parse(txtSubtotal.Text);
                double taxNum = subtotalNum * 0.06;
                double totalNum = subtotalNum + taxNum;
                string taxStr = taxNum.ToString();
                string totalStr = totalNum.ToString();
                string customer = txtCustomer.Text;

                StreamWriter newFile = File.CreateText(fileName);

                newFile.WriteLine(customer);
                newFile.WriteLine(vehicleInfo);
                newFile.WriteLine(laborCosts);
                newFile.WriteLine(partsUsed);
                newFile.WriteLine(subtotalStr);
                newFile.WriteLine(fluidCheckup);
                newFile.WriteLine(taxStr);
                newFile.WriteLine(totalStr);

                newFile.Close();

            }
            catch
            {
                MessageBox.Show("Please use valid input.");
            }
            
        }

        private void BtnViewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtName.Text + ".txt";
                string[] invoice = System.IO.File.ReadAllLines(fileName);
                
                InvoicesLabel.Text = "Joe's Automotive - Invoice" +
                    "\nCustomer Name: " + invoice[0] +
                    "\nVehicle Info: " + invoice[1] +
                    "\nLabor Costs: $" + invoice[2] +
                    "\nParts Used: " + invoice[3] +
                    "\nSubtotal: $" + invoice[4] +
                    "\nFluid Checkup: " + invoice[5] +
                    "\nTax: $" + invoice[6] +
                    "\nTotal: $" + invoice[7];
            }
            catch
            {
                MessageBox.Show("Please use a valid file name. Invoice files are in Joe's_Automotive/bin/Debug. Do not include the filename extension.");
            }
            
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleInfo = txtVehicleInfo.Text;
                string laborCosts = txtLaborCosts.Text;
                string partsUsed = txtPartsUsed.Text;
                string subtotalStr = txtSubtotal.Text;
                string fluidCheckup;
                if (FluidCheckupCheckBox.Checked)
                {
                    fluidCheckup = "$24.99";
                }
                else
                {
                    fluidCheckup = "$0.00";
                }
                double subtotalNum = double.Parse(txtSubtotal.Text);
                double taxNum = subtotalNum * 0.06;
                double totalNum = subtotalNum + taxNum;
                string taxStr = taxNum.ToString();
                string totalStr = totalNum.ToString();
                string customer = txtCustomer.Text;

                InvoicesLabel.Text = "Joe's Automotive - Invoice" +
                    "\nCustomer Name: " + customer +
                    "\nVehicle Info: " + vehicleInfo +
                    "\nLabor Costs: $" + laborCosts +
                    "\nParts Used: " + partsUsed +
                    "\nSubtotal: $" + subtotalStr +
                    "\nFluid Checkup: " + fluidCheckup +
                    "\nTax: $" + taxStr +
                    "\nTotal: $" + totalStr;
            }
            catch
            {
                MessageBox.Show("Please use valid input.");
            }
        }
    }
}
