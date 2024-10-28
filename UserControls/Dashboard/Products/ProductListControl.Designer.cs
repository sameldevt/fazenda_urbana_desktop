namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductListControl
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
            ProductsList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // ProductsList
            // 
            ProductsList.Location = new Point(3, 3);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(954, 552);
            ProductsList.TabIndex = 2;
            // 
            // ProductListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductsList);
            Name = "ProductListControl";
            Size = new Size(960, 558);
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel ProductsList;
    }
}
