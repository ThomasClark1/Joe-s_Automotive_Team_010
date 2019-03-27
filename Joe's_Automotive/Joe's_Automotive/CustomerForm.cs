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
    public partial class CustomerEdit : Form
    {
        public CustomerEdit()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.databaseDataSet.Customer);

        }
    }
}
