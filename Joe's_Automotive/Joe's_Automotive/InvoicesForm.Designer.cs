﻿namespace Final_Exam
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
            this.SuspendLayout();
            // 
            // BtnCreateInvoice
            // 
            this.BtnCreateInvoice.Location = new System.Drawing.Point(13, 13);
            this.BtnCreateInvoice.Name = "BtnCreateInvoice";
            this.BtnCreateInvoice.Size = new System.Drawing.Size(125, 30);
            this.BtnCreateInvoice.TabIndex = 0;
            this.BtnCreateInvoice.Text = "Create Invoice";
            this.BtnCreateInvoice.UseVisualStyleBackColor = true;
            // 
            // InvoicesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCreateInvoice);
            this.Name = "InvoicesEdit";
            this.Text = "Edit Invoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateInvoice;
    }
}