namespace Final_Exam
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomersEdit = new System.Windows.Forms.Button();
            this.btnCustomersView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvoicesEdit = new System.Windows.Forms.Button();
            this.btnInvoicesView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVehiclesEdit = new System.Windows.Forms.Button();
            this.btnVehiclesView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPartsEdit = new System.Windows.Forms.Button();
            this.btnPartsView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCustomersEdit
            // 
            this.btnCustomersEdit.Location = new System.Drawing.Point(263, 33);
            this.btnCustomersEdit.Name = "btnCustomersEdit";
            this.btnCustomersEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCustomersEdit.TabIndex = 1;
            this.btnCustomersEdit.Text = "Edit";
            this.btnCustomersEdit.UseVisualStyleBackColor = true;
            this.btnCustomersEdit.Click += new System.EventHandler(this.btnCustomersEdit_Click);
            // 
            // btnCustomersView
            // 
            this.btnCustomersView.Location = new System.Drawing.Point(344, 33);
            this.btnCustomersView.Name = "btnCustomersView";
            this.btnCustomersView.Size = new System.Drawing.Size(75, 23);
            this.btnCustomersView.TabIndex = 2;
            this.btnCustomersView.Text = "View";
            this.btnCustomersView.UseVisualStyleBackColor = true;
            this.btnCustomersView.Click += new System.EventHandler(this.btnCustomersView_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(263, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invoices";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInvoicesEdit
            // 
            this.btnInvoicesEdit.Location = new System.Drawing.Point(263, 82);
            this.btnInvoicesEdit.Name = "btnInvoicesEdit";
            this.btnInvoicesEdit.Size = new System.Drawing.Size(75, 23);
            this.btnInvoicesEdit.TabIndex = 4;
            this.btnInvoicesEdit.Text = "Edit";
            this.btnInvoicesEdit.UseVisualStyleBackColor = true;
            this.btnInvoicesEdit.Click += new System.EventHandler(this.btnInvoicesEdit_Click);
            // 
            // btnInvoicesView
            // 
            this.btnInvoicesView.Location = new System.Drawing.Point(344, 82);
            this.btnInvoicesView.Name = "btnInvoicesView";
            this.btnInvoicesView.Size = new System.Drawing.Size(75, 23);
            this.btnInvoicesView.TabIndex = 5;
            this.btnInvoicesView.Text = "View";
            this.btnInvoicesView.UseVisualStyleBackColor = true;
            this.btnInvoicesView.Click += new System.EventHandler(this.btnInvoicesView_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(263, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehicles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVehiclesEdit
            // 
            this.btnVehiclesEdit.Location = new System.Drawing.Point(263, 131);
            this.btnVehiclesEdit.Name = "btnVehiclesEdit";
            this.btnVehiclesEdit.Size = new System.Drawing.Size(75, 23);
            this.btnVehiclesEdit.TabIndex = 7;
            this.btnVehiclesEdit.Text = "Edit";
            this.btnVehiclesEdit.UseVisualStyleBackColor = true;
            this.btnVehiclesEdit.Click += new System.EventHandler(this.btnVehiclesEdit_Click);
            // 
            // btnVehiclesView
            // 
            this.btnVehiclesView.Location = new System.Drawing.Point(344, 131);
            this.btnVehiclesView.Name = "btnVehiclesView";
            this.btnVehiclesView.Size = new System.Drawing.Size(75, 23);
            this.btnVehiclesView.TabIndex = 8;
            this.btnVehiclesView.Text = "View";
            this.btnVehiclesView.UseVisualStyleBackColor = true;
            this.btnVehiclesView.Click += new System.EventHandler(this.btnVehiclesView_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(263, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPartsEdit
            // 
            this.btnPartsEdit.Location = new System.Drawing.Point(263, 180);
            this.btnPartsEdit.Name = "btnPartsEdit";
            this.btnPartsEdit.Size = new System.Drawing.Size(75, 23);
            this.btnPartsEdit.TabIndex = 10;
            this.btnPartsEdit.Text = "Edit";
            this.btnPartsEdit.UseVisualStyleBackColor = true;
            this.btnPartsEdit.Click += new System.EventHandler(this.btnPartsEdit_Click);
            // 
            // btnPartsView
            // 
            this.btnPartsView.Location = new System.Drawing.Point(344, 180);
            this.btnPartsView.Name = "btnPartsView";
            this.btnPartsView.Size = new System.Drawing.Size(75, 23);
            this.btnPartsView.TabIndex = 11;
            this.btnPartsView.Text = "View";
            this.btnPartsView.UseVisualStyleBackColor = true;
            this.btnPartsView.Click += new System.EventHandler(this.btnPartsView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(89, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Final_Exam.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(12, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(233, 164);
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 214);
            this.ControlBox = false;
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPartsView);
            this.Controls.Add(this.btnPartsEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVehiclesView);
            this.Controls.Add(this.btnVehiclesEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInvoicesView);
            this.Controls.Add(this.btnInvoicesEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCustomersView);
            this.Controls.Add(this.btnCustomersEdit);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Joe\'s Automotive CRM";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomersEdit;
        private System.Windows.Forms.Button btnCustomersView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvoicesEdit;
        private System.Windows.Forms.Button btnInvoicesView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVehiclesEdit;
        private System.Windows.Forms.Button btnVehiclesView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPartsEdit;
        private System.Windows.Forms.Button btnPartsView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

