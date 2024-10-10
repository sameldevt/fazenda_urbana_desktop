namespace fazenda_verdeviva.UserControls
{
    partial class StockControl
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
            NavigationPanel = new Panel();
            CategoriesButton = new Button();
            ExitButton = new Button();
            ProductsButton = new Button();
            ContentPanel = new Panel();
            NavigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.Controls.Add(CategoriesButton);
            NavigationPanel.Controls.Add(ExitButton);
            NavigationPanel.Controls.Add(ProductsButton);
            NavigationPanel.Location = new Point(3, 3);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(200, 663);
            NavigationPanel.TabIndex = 0;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Location = new Point(3, 32);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(190, 23);
            CategoriesButton.TabIndex = 3;
            CategoriesButton.Text = "Categorias";
            CategoriesButton.UseVisualStyleBackColor = true;
            CategoriesButton.Click += CategoriesButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(3, 61);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(190, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Sair";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(5, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(190, 23);
            ProductsButton.TabIndex = 1;
            ProductsButton.Text = "Produtos";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(209, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(982, 663);
            ContentPanel.TabIndex = 1;
            // 
            // StockControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Controls.Add(NavigationPanel);
            Name = "StockControl";
            Size = new Size(1194, 669);
            NavigationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavigationPanel;
        private Label OptionTitle;
        private Panel ContentPanel;
        private Button ProductsButton;
        private Button ExitButton;
        private Button CategoriesButton;
    }
}
