﻿namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 100);
            panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(982, 574);
            listBox1.TabIndex = 1;
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "ProductsControl";
            Size = new Size(991, 694);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
    }
}
