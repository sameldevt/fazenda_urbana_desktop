namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    partial class SupplierListControl
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
            SupplierList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // SupplierList
            // 
            SupplierList.Location = new Point(3, 3);
            SupplierList.Name = "SupplierList";
            SupplierList.Size = new Size(948, 513);
            SupplierList.TabIndex = 4;
            // 
            // SupplierListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SupplierList);
            Name = "SupplierListControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
        }

        #endregion
        public FlowLayoutPanel SupplierList;
    }
}
