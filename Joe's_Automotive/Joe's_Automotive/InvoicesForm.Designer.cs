namespace Final_Exam
{
    partial class InvoicesEdit
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
            this.BtnCreateInvoice = new System.Windows.Forms.Button();
            this.BtnViewInvoice = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.InvoicesLabel = new System.Windows.Forms.Label();
            this.FluidCheckupCheckBox = new System.Windows.Forms.CheckBox();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.txtVehicleInfo = new System.Windows.Forms.TextBox();
            this.txtLaborCosts = new System.Windows.Forms.TextBox();
            this.txtPartsUsed = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblLaborCosts = new System.Windows.Forms.Label();
            this.lblPartsUsed = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnUpdateText = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateInvoice
            // 
            this.BtnCreateInvoice.Location = new System.Drawing.Point(12, 12);
            this.BtnCreateInvoice.Name = "BtnCreateInvoice";
            this.BtnCreateInvoice.Size = new System.Drawing.Size(125, 30);
            this.BtnCreateInvoice.TabIndex = 0;
            this.BtnCreateInvoice.Text = "Create Invoice";
            this.BtnCreateInvoice.UseVisualStyleBackColor = true;
            this.BtnCreateInvoice.Click += new System.EventHandler(this.BtnCreateInvoice_Click);
            // 
            // BtnViewInvoice
            // 
            this.BtnViewInvoice.Location = new System.Drawing.Point(155, 12);
            this.BtnViewInvoice.Name = "BtnViewInvoice";
            this.BtnViewInvoice.Size = new System.Drawing.Size(125, 30);
            this.BtnViewInvoice.TabIndex = 1;
            this.BtnViewInvoice.Text = "View Saved Invoice";
            this.BtnViewInvoice.UseVisualStyleBackColor = true;
            this.BtnViewInvoice.Click += new System.EventHandler(this.BtnViewInvoice_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.Location = new System.Drawing.Point(296, 12);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(125, 30);
            this.btnEditInvoice.TabIndex = 2;
            this.btnEditInvoice.Text = "Edit Invoice";
            this.btnEditInvoice.UseVisualStyleBackColor = true;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // InvoicesLabel
            // 
            this.InvoicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvoicesLabel.Location = new System.Drawing.Point(427, 12);
            this.InvoicesLabel.Name = "InvoicesLabel";
            this.InvoicesLabel.Size = new System.Drawing.Size(235, 221);
            this.InvoicesLabel.TabIndex = 3;
            this.InvoicesLabel.Text = "Loading";
            // 
            // FluidCheckupCheckBox
            // 
            this.FluidCheckupCheckBox.AutoSize = true;
            this.FluidCheckupCheckBox.Location = new System.Drawing.Point(13, 49);
            this.FluidCheckupCheckBox.Name = "FluidCheckupCheckBox";
            this.FluidCheckupCheckBox.Size = new System.Drawing.Size(130, 17);
            this.FluidCheckupCheckBox.TabIndex = 4;
            this.FluidCheckupCheckBox.Text = "$24.99 Fluid Checkup";
            this.FluidCheckupCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Location = new System.Drawing.Point(12, 76);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(66, 13);
            this.lblVehicleInfo.TabIndex = 5;
            this.lblVehicleInfo.Text = "Vehicle Info:";
            // 
            // txtVehicleInfo
            // 
            this.txtVehicleInfo.Location = new System.Drawing.Point(86, 73);
            this.txtVehicleInfo.Name = "txtVehicleInfo";
            this.txtVehicleInfo.Size = new System.Drawing.Size(335, 20);
            this.txtVehicleInfo.TabIndex = 6;
            // 
            // txtLaborCosts
            // 
            this.txtLaborCosts.Location = new System.Drawing.Point(84, 99);
            this.txtLaborCosts.Name = "txtLaborCosts";
            this.txtLaborCosts.Size = new System.Drawing.Size(337, 20);
            this.txtLaborCosts.TabIndex = 7;
            // 
            // txtPartsUsed
            // 
            this.txtPartsUsed.Location = new System.Drawing.Point(80, 125);
            this.txtPartsUsed.Name = "txtPartsUsed";
            this.txtPartsUsed.Size = new System.Drawing.Size(341, 20);
            this.txtPartsUsed.TabIndex = 8;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(67, 151);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(354, 20);
            this.txtSubtotal.TabIndex = 9;
            // 
            // lblLaborCosts
            // 
            this.lblLaborCosts.AutoSize = true;
            this.lblLaborCosts.Location = new System.Drawing.Point(12, 102);
            this.lblLaborCosts.Name = "lblLaborCosts";
            this.lblLaborCosts.Size = new System.Drawing.Size(66, 13);
            this.lblLaborCosts.TabIndex = 10;
            this.lblLaborCosts.Text = "Labor Costs:";
            // 
            // lblPartsUsed
            // 
            this.lblPartsUsed.AutoSize = true;
            this.lblPartsUsed.Location = new System.Drawing.Point(12, 128);
            this.lblPartsUsed.Name = "lblPartsUsed";
            this.lblPartsUsed.Size = new System.Drawing.Size(62, 13);
            this.lblPartsUsed.TabIndex = 11;
            this.lblPartsUsed.Text = "Parts Used:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(12, 154);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnUpdateText
            // 
            this.btnUpdateText.Location = new System.Drawing.Point(12, 249);
            this.btnUpdateText.Name = "btnUpdateText";
            this.btnUpdateText.Size = new System.Drawing.Size(409, 30);
            this.btnUpdateText.TabIndex = 13;
            this.btnUpdateText.Text = "Update Text";
            this.btnUpdateText.UseVisualStyleBackColor = true;
            this.btnUpdateText.Click += new System.EventHandler(this.btnUpdateText_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 203);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 20);
            this.txtName.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 206);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name of File:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(116, 177);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(306, 20);
            this.txtCustomer.TabIndex = 16;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 180);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(97, 13);
            this.lblCustomer.TabIndex = 17;
            this.lblCustomer.Text = "Name of Customer:";
            // 
            // InvoicesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 291);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateText);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblPartsUsed);
            this.Controls.Add(this.lblLaborCosts);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPartsUsed);
            this.Controls.Add(this.txtLaborCosts);
            this.Controls.Add(this.txtVehicleInfo);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.FluidCheckupCheckBox);
            this.Controls.Add(this.InvoicesLabel);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.BtnViewInvoice);
            this.Controls.Add(this.BtnCreateInvoice);
            this.Name = "InvoicesEdit";
            this.Text = "Edit Invoices";
            this.Load += new System.EventHandler(this.InvoicesEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateInvoice;
        private System.Windows.Forms.Button BtnViewInvoice;
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Label InvoicesLabel;
        private System.Windows.Forms.CheckBox FluidCheckupCheckBox;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.TextBox txtVehicleInfo;
        private System.Windows.Forms.TextBox txtLaborCosts;
        private System.Windows.Forms.TextBox txtPartsUsed;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblLaborCosts;
        private System.Windows.Forms.Label lblPartsUsed;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnUpdateText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
    }
}