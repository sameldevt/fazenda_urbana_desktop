namespace fazenda_verdeviva.UserControls
{
    partial class DashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            toolStrip1 = new ToolStrip();
            StockButton = new ToolStripButton();
            OrdersButton = new ToolStripButton();
            ClientsButton = new ToolStripButton();
            SuppliersButton = new ToolStripButton();
            ReportsButton = new ToolStripButton();
            ContentPanel = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { StockButton, OrdersButton, ClientsButton, SuppliersButton, ReportsButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1200, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // StockButton
            // 
            StockButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            StockButton.Image = (Image)resources.GetObject("StockButton.Image");
            StockButton.ImageTransparentColor = Color.Magenta;
            StockButton.Name = "StockButton";
            StockButton.Size = new Size(113, 22);
            StockButton.Text = "Produtos e estoque";
            StockButton.Click += StockButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OrdersButton.Image = (Image)resources.GetObject("OrdersButton.Image");
            OrdersButton.ImageTransparentColor = Color.Magenta;
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(53, 22);
            OrdersButton.Text = "Pedidos";
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ClientsButton.Image = (Image)resources.GetObject("ClientsButton.Image");
            ClientsButton.ImageTransparentColor = Color.Magenta;
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(53, 22);
            ClientsButton.Text = "Clientes";
            ClientsButton.Click += ClientsButton_Click;
            // 
            // SuppliersButton
            // 
            SuppliersButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SuppliersButton.Image = (Image)resources.GetObject("SuppliersButton.Image");
            SuppliersButton.ImageTransparentColor = Color.Magenta;
            SuppliersButton.Name = "SuppliersButton";
            SuppliersButton.Size = new Size(82, 22);
            SuppliersButton.Text = "Fornecedores";
            SuppliersButton.Click += SuppliersButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ReportsButton.Image = (Image)resources.GetObject("ReportsButton.Image");
            ReportsButton.ImageTransparentColor = Color.Magenta;
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(63, 22);
            ReportsButton.Text = "Relatórios";
            ReportsButton.Click += ReportsButton_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(3, 28);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1194, 669);
            ContentPanel.TabIndex = 1;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Controls.Add(toolStrip1);
            Name = "DashboardControl";
            Size = new Size(1200, 700);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton StockButton;
        private ToolStripButton OrdersButton;
        private ToolStripButton ClientsButton;
        private ToolStripButton SuppliersButton;
        private ToolStripButton ReportsButton;
        private Panel ContentPanel;
    }
}
