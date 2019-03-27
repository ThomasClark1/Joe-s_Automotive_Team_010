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
    public partial class PartsView : Form
    {
        public PartsView()
        {
            InitializeComponent();
        }

        private void partBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void PartsView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.databaseDataSet.Part);

        }
    }
}
