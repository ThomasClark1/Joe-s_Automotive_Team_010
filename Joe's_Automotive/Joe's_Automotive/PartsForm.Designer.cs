namespace Final_Exam
{
    partial class PartsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsEdit));
            System.Windows.Forms.Label partsIDLabel;
            System.Windows.Forms.Label partNameLabel;
            System.Windows.Forms.Label partsInStockLabel;
            System.Windows.Forms.Label partsOnOrderLabel;
            System.Windows.Forms.Label partPhotoLabel;
            System.Windows.Forms.Label partCostLabel;
            System.Windows.Forms.Label compatibleVehiclesLabel;
            this.databaseDataSet = new Final_Exam.DatabaseDataSet();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partTableAdapter = new Final_Exam.DatabaseDataSetTableAdapters.PartTableAdapter();
            this.tableAdapterManager = new Final_Exam.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.partBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.partBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partsIDTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partsInStockTextBox = new System.Windows.Forms.TextBox();
            this.partsOnOrderTextBox = new System.Windows.Forms.TextBox();
            this.partPhotoTextBox = new System.Windows.Forms.TextBox();
            this.partCostTextBox = new System.Windows.Forms.TextBox();
            this.compatibleVehiclesTextBox = new System.Windows.Forms.TextBox();
            partsIDLabel = new System.Windows.Forms.Label();
            partNameLabel = new System.Windows.Forms.Label();
            partsInStockLabel = new System.Windows.Forms.Label();
            partsOnOrderLabel = new System.Windows.Forms.Label();
            partPhotoLabel = new System.Windows.Forms.Label();
            partCostLabel = new System.Windows.Forms.Label();
            compatibleVehiclesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingNavigator)).BeginInit();
            this.partBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.databaseDataSet;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PartTableAdapter = this.partTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Exam.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // partBindingNavigator
            // 
            this.partBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partBindingNavigator.BindingSource = this.partBindingSource;
            this.partBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partBindingNavigatorSaveItem});
            this.partBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partBindingNavigator.Name = "partBindingNavigator";
            this.partBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partBindingNavigator.Size = new System.Drawing.Size(281, 25);
            this.partBindingNavigator.TabIndex = 0;
            this.partBindingNavigator.Text = "bindingNavigator1";
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
            // partBindingNavigatorSaveItem
            // 
            this.partBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partBindingNavigatorSaveItem.Image")));
            this.partBindingNavigatorSaveItem.Name = "partBindingNavigatorSaveItem";
            this.partBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.partBindingNavigatorSaveItem.Text = "Save Data";
            this.partBindingNavigatorSaveItem.Click += new System.EventHandler(this.partBindingNavigatorSaveItem_Click);
            // 
            // partsIDLabel
            // 
            partsIDLabel.AutoSize = true;
            partsIDLabel.Location = new System.Drawing.Point(12, 38);
            partsIDLabel.Name = "partsIDLabel";
            partsIDLabel.Size = new System.Drawing.Size(48, 13);
            partsIDLabel.TabIndex = 1;
            partsIDLabel.Text = "Parts ID:";
            // 
            // partsIDTextBox
            // 
            this.partsIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartsID", true));
            this.partsIDTextBox.Location = new System.Drawing.Point(123, 35);
            this.partsIDTextBox.Name = "partsIDTextBox";
            this.partsIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsIDTextBox.TabIndex = 2;
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Location = new System.Drawing.Point(12, 64);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new System.Drawing.Size(60, 13);
            partNameLabel.TabIndex = 3;
            partNameLabel.Text = "Part Name:";
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartName", true));
            this.partNameTextBox.Location = new System.Drawing.Point(123, 61);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNameTextBox.TabIndex = 4;
            // 
            // partsInStockLabel
            // 
            partsInStockLabel.AutoSize = true;
            partsInStockLabel.Location = new System.Drawing.Point(12, 90);
            partsInStockLabel.Name = "partsInStockLabel";
            partsInStockLabel.Size = new System.Drawing.Size(77, 13);
            partsInStockLabel.TabIndex = 5;
            partsInStockLabel.Text = "Parts In Stock:";
            // 
            // partsInStockTextBox
            // 
            this.partsInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartsInStock", true));
            this.partsInStockTextBox.Location = new System.Drawing.Point(123, 87);
            this.partsInStockTextBox.Name = "partsInStockTextBox";
            this.partsInStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsInStockTextBox.TabIndex = 6;
            // 
            // partsOnOrderLabel
            // 
            partsOnOrderLabel.AutoSize = true;
            partsOnOrderLabel.Location = new System.Drawing.Point(12, 116);
            partsOnOrderLabel.Name = "partsOnOrderLabel";
            partsOnOrderLabel.Size = new System.Drawing.Size(80, 13);
            partsOnOrderLabel.TabIndex = 7;
            partsOnOrderLabel.Text = "Parts On Order:";
            // 
            // partsOnOrderTextBox
            // 
            this.partsOnOrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartsOnOrder", true));
            this.partsOnOrderTextBox.Location = new System.Drawing.Point(123, 113);
            this.partsOnOrderTextBox.Name = "partsOnOrderTextBox";
            this.partsOnOrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsOnOrderTextBox.TabIndex = 8;
            // 
            // partPhotoLabel
            // 
            partPhotoLabel.AutoSize = true;
            partPhotoLabel.Location = new System.Drawing.Point(12, 142);
            partPhotoLabel.Name = "partPhotoLabel";
            partPhotoLabel.Size = new System.Drawing.Size(60, 13);
            partPhotoLabel.TabIndex = 9;
            partPhotoLabel.Text = "Part Photo:";
            // 
            // partPhotoTextBox
            // 
            this.partPhotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartPhoto", true));
            this.partPhotoTextBox.Location = new System.Drawing.Point(123, 139);
            this.partPhotoTextBox.Name = "partPhotoTextBox";
            this.partPhotoTextBox.Size = new System.Drawing.Size(100, 20);
            this.partPhotoTextBox.TabIndex = 10;
            // 
            // partCostLabel
            // 
            partCostLabel.AutoSize = true;
            partCostLabel.Location = new System.Drawing.Point(12, 168);
            partCostLabel.Name = "partCostLabel";
            partCostLabel.Size = new System.Drawing.Size(53, 13);
            partCostLabel.TabIndex = 11;
            partCostLabel.Text = "Part Cost:";
            // 
            // partCostTextBox
            // 
            this.partCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "PartCost", true));
            this.partCostTextBox.Location = new System.Drawing.Point(123, 165);
            this.partCostTextBox.Name = "partCostTextBox";
            this.partCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.partCostTextBox.TabIndex = 12;
            // 
            // compatibleVehiclesLabel
            // 
            compatibleVehiclesLabel.AutoSize = true;
            compatibleVehiclesLabel.Location = new System.Drawing.Point(12, 194);
            compatibleVehiclesLabel.Name = "compatibleVehiclesLabel";
            compatibleVehiclesLabel.Size = new System.Drawing.Size(105, 13);
            compatibleVehiclesLabel.TabIndex = 13;
            compatibleVehiclesLabel.Text = "Compatible Vehicles:";
            // 
            // compatibleVehiclesTextBox
            // 
            this.compatibleVehiclesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partBindingSource, "CompatibleVehicles", true));
            this.compatibleVehiclesTextBox.Location = new System.Drawing.Point(123, 191);
            this.compatibleVehiclesTextBox.Name = "compatibleVehiclesTextBox";
            this.compatibleVehiclesTextBox.Size = new System.Drawing.Size(100, 20);
            this.compatibleVehiclesTextBox.TabIndex = 14;
            // 
            // PartsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 223);
            this.Controls.Add(partsIDLabel);
            this.Controls.Add(this.partsIDTextBox);
            this.Controls.Add(partNameLabel);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(partsInStockLabel);
            this.Controls.Add(this.partsInStockTextBox);
            this.Controls.Add(partsOnOrderLabel);
            this.Controls.Add(this.partsOnOrderTextBox);
            this.Controls.Add(partPhotoLabel);
            this.Controls.Add(this.partPhotoTextBox);
            this.Controls.Add(partCostLabel);
            this.Controls.Add(this.partCostTextBox);
            this.Controls.Add(compatibleVehiclesLabel);
            this.Controls.Add(this.compatibleVehiclesTextBox);
            this.Controls.Add(this.partBindingNavigator);
            this.Name = "PartsEdit";
            this.Text = "Edit Parts";
            this.Load += new System.EventHandler(this.PartsEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingNavigator)).EndInit();
            this.partBindingNavigator.ResumeLayout(false);
            this.partBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private DatabaseDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partsIDTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partsInStockTextBox;
        private System.Windows.Forms.TextBox partsOnOrderTextBox;
        private System.Windows.Forms.TextBox partPhotoTextBox;
        private System.Windows.Forms.TextBox partCostTextBox;
        private System.Windows.Forms.TextBox compatibleVehiclesTextBox;
    }
}