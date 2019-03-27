namespace Final_Exam
{
    partial class VehiclesEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesEdit));
            System.Windows.Forms.Label vehicleIDLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label dateRecievedLabel;
            System.Windows.Forms.Label dateReturnedLabel;
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label invoicesLabel;
            System.Windows.Forms.Label partsAvailableLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label photosLabel;
            this.databaseDataSet = new Final_Exam.DatabaseDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Final_Exam.DatabaseDataSetTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new Final_Exam.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.vehicleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicleIDTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.dateRecievedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.invoicesTextBox = new System.Windows.Forms.TextBox();
            this.partsAvailableTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.photosTextBox = new System.Windows.Forms.TextBox();
            vehicleIDLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            dateRecievedLabel = new System.Windows.Forms.Label();
            dateReturnedLabel = new System.Windows.Forms.Label();
            ownerLabel = new System.Windows.Forms.Label();
            invoicesLabel = new System.Windows.Forms.Label();
            partsAvailableLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            photosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).BeginInit();
            this.vehicleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.databaseDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PartTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Exam.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicleBindingNavigator
            // 
            this.vehicleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehicleBindingNavigator.BindingSource = this.vehicleBindingSource;
            this.vehicleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehicleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehicleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vehicleBindingNavigatorSaveItem});
            this.vehicleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehicleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehicleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehicleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehicleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehicleBindingNavigator.Name = "vehicleBindingNavigator";
            this.vehicleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehicleBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.vehicleBindingNavigator.TabIndex = 0;
            this.vehicleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vehicleBindingNavigatorSaveItem
            // 
            this.vehicleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehicleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleBindingNavigatorSaveItem.Image")));
            this.vehicleBindingNavigatorSaveItem.Name = "vehicleBindingNavigatorSaveItem";
            this.vehicleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vehicleBindingNavigatorSaveItem.Text = "Save Data";
            this.vehicleBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehicleBindingNavigatorSaveItem_Click);
            // 
            // vehicleIDLabel
            // 
            vehicleIDLabel.AutoSize = true;
            vehicleIDLabel.Location = new System.Drawing.Point(12, 37);
            vehicleIDLabel.Name = "vehicleIDLabel";
            vehicleIDLabel.Size = new System.Drawing.Size(59, 13);
            vehicleIDLabel.TabIndex = 1;
            vehicleIDLabel.Text = "Vehicle ID:";
            // 
            // vehicleIDTextBox
            // 
            this.vehicleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "VehicleID", true));
            this.vehicleIDTextBox.Location = new System.Drawing.Point(100, 34);
            this.vehicleIDTextBox.Name = "vehicleIDTextBox";
            this.vehicleIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleIDTextBox.TabIndex = 2;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(12, 63);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(100, 60);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 20);
            this.makeTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(12, 89);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(100, 86);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 115);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(100, 112);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(200, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(12, 141);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 9;
            mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(100, 138);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(200, 20);
            this.mileageTextBox.TabIndex = 10;
            // 
            // dateRecievedLabel
            // 
            dateRecievedLabel.AutoSize = true;
            dateRecievedLabel.Location = new System.Drawing.Point(12, 168);
            dateRecievedLabel.Name = "dateRecievedLabel";
            dateRecievedLabel.Size = new System.Drawing.Size(82, 13);
            dateRecievedLabel.TabIndex = 11;
            dateRecievedLabel.Text = "Date Recieved:";
            // 
            // dateRecievedDateTimePicker
            // 
            this.dateRecievedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleBindingSource, "DateRecieved", true));
            this.dateRecievedDateTimePicker.Location = new System.Drawing.Point(100, 164);
            this.dateRecievedDateTimePicker.Name = "dateRecievedDateTimePicker";
            this.dateRecievedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRecievedDateTimePicker.TabIndex = 12;
            // 
            // dateReturnedLabel
            // 
            dateReturnedLabel.AutoSize = true;
            dateReturnedLabel.Location = new System.Drawing.Point(12, 194);
            dateReturnedLabel.Name = "dateReturnedLabel";
            dateReturnedLabel.Size = new System.Drawing.Size(80, 13);
            dateReturnedLabel.TabIndex = 13;
            dateReturnedLabel.Text = "Date Returned:";
            // 
            // dateReturnedDateTimePicker
            // 
            this.dateReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleBindingSource, "DateReturned", true));
            this.dateReturnedDateTimePicker.Location = new System.Drawing.Point(100, 190);
            this.dateReturnedDateTimePicker.Name = "dateReturnedDateTimePicker";
            this.dateReturnedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateReturnedDateTimePicker.TabIndex = 14;
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(12, 219);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(41, 13);
            ownerLabel.TabIndex = 15;
            ownerLabel.Text = "Owner:";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(100, 216);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ownerTextBox.TabIndex = 16;
            // 
            // invoicesLabel
            // 
            invoicesLabel.AutoSize = true;
            invoicesLabel.Location = new System.Drawing.Point(12, 245);
            invoicesLabel.Name = "invoicesLabel";
            invoicesLabel.Size = new System.Drawing.Size(50, 13);
            invoicesLabel.TabIndex = 17;
            invoicesLabel.Text = "Invoices:";
            // 
            // invoicesTextBox
            // 
            this.invoicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Invoices", true));
            this.invoicesTextBox.Location = new System.Drawing.Point(100, 242);
            this.invoicesTextBox.Name = "invoicesTextBox";
            this.invoicesTextBox.Size = new System.Drawing.Size(200, 20);
            this.invoicesTextBox.TabIndex = 18;
            // 
            // partsAvailableLabel
            // 
            partsAvailableLabel.AutoSize = true;
            partsAvailableLabel.Location = new System.Drawing.Point(12, 271);
            partsAvailableLabel.Name = "partsAvailableLabel";
            partsAvailableLabel.Size = new System.Drawing.Size(80, 13);
            partsAvailableLabel.TabIndex = 19;
            partsAvailableLabel.Text = "Parts Available:";
            // 
            // partsAvailableTextBox
            // 
            this.partsAvailableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "PartsAvailable", true));
            this.partsAvailableTextBox.Location = new System.Drawing.Point(100, 268);
            this.partsAvailableTextBox.Name = "partsAvailableTextBox";
            this.partsAvailableTextBox.Size = new System.Drawing.Size(200, 20);
            this.partsAvailableTextBox.TabIndex = 20;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(12, 297);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 21;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(100, 294);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(200, 20);
            this.notesTextBox.TabIndex = 22;
            // 
            // photosLabel
            // 
            photosLabel.AutoSize = true;
            photosLabel.Location = new System.Drawing.Point(12, 323);
            photosLabel.Name = "photosLabel";
            photosLabel.Size = new System.Drawing.Size(43, 13);
            photosLabel.TabIndex = 23;
            photosLabel.Text = "Photos:";
            // 
            // photosTextBox
            // 
            this.photosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Photos", true));
            this.photosTextBox.Location = new System.Drawing.Point(100, 320);
            this.photosTextBox.Name = "photosTextBox";
            this.photosTextBox.Size = new System.Drawing.Size(200, 20);
            this.photosTextBox.TabIndex = 24;
            // 
            // VehiclesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 351);
            this.Controls.Add(vehicleIDLabel);
            this.Controls.Add(this.vehicleIDTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(dateRecievedLabel);
            this.Controls.Add(this.dateRecievedDateTimePicker);
            this.Controls.Add(dateReturnedLabel);
            this.Controls.Add(this.dateReturnedDateTimePicker);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(invoicesLabel);
            this.Controls.Add(this.invoicesTextBox);
            this.Controls.Add(partsAvailableLabel);
            this.Controls.Add(this.partsAvailableTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(photosLabel);
            this.Controls.Add(this.photosTextBox);
            this.Controls.Add(this.vehicleBindingNavigator);
            this.Name = "VehiclesEdit";
            this.Text = "Edit Vehicles";
            this.Load += new System.EventHandler(this.VehiclesEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingNavigator)).EndInit();
            this.vehicleBindingNavigator.ResumeLayout(false);
            this.vehicleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private DatabaseDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehicleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vehicleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehicleIDTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.DateTimePicker dateRecievedDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateReturnedDateTimePicker;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox invoicesTextBox;
        private System.Windows.Forms.TextBox partsAvailableTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox photosTextBox;
    }
}