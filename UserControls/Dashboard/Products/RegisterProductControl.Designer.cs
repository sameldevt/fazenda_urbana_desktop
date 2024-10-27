namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class RegisterProductControl
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
            ProductNameLabel = new Label();
            ProductDescriptionLabel = new Label();
            ProductValueLabel = new Label();
            ProductQuantityLabel = new Label();
            CategoryLabel = new Label();
            ManufacturerLabel = new Label();
            SupplierComboBox = new ComboBox();
            CategoryComboBox = new ComboBox();
            NewProductLabel = new Label();
            ProductNameTextBox = new TextBox();
            ProductDescriptionTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            ProductQuantityTextBox = new TextBox();
            ProductFibersTextBox = new TextBox();
            ProductFatsTextBox = new TextBox();
            FibersLabel = new Label();
            ProductProteinsTextBox = new TextBox();
            CaloriesLabel = new Label();
            ProductCarbsTextBox = new TextBox();
            ProductCaloriesTextBox = new TextBox();
            CarbsLabel = new Label();
            FatsLabel = new Label();
            ProteinsLabel = new Label();
            ImageLinkLabel = new Label();
            RegisterButton = new Button();
            BackButton = new Button();
            ProductImageUrlTextBox = new TextBox();
            SuspendLayout();
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(125, 104);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(40, 15);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Nome";
            // 
            // ProductDescriptionLabel
            // 
            ProductDescriptionLabel.AutoSize = true;
            ProductDescriptionLabel.Location = new Point(125, 165);
            ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            ProductDescriptionLabel.Size = new Size(53, 15);
            ProductDescriptionLabel.TabIndex = 1;
            ProductDescriptionLabel.Text = "Decrição";
            // 
            // ProductValueLabel
            // 
            ProductValueLabel.AutoSize = true;
            ProductValueLabel.Location = new Point(348, 104);
            ProductValueLabel.Name = "ProductValueLabel";
            ProductValueLabel.Size = new Size(88, 15);
            ProductValueLabel.TabIndex = 2;
            ProductValueLabel.Text = "Preço por quilo";
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.Location = new Point(348, 165);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(93, 15);
            ProductQuantityLabel.TabIndex = 3;
            ProductQuantityLabel.Text = "Quantidade (kg)";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(574, 104);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 11;
            CategoryLabel.Text = "Categoria";
            // 
            // ManufacturerLabel
            // 
            ManufacturerLabel.AutoSize = true;
            ManufacturerLabel.Location = new Point(574, 165);
            ManufacturerLabel.Name = "ManufacturerLabel";
            ManufacturerLabel.Size = new Size(67, 15);
            ManufacturerLabel.TabIndex = 12;
            ManufacturerLabel.Text = "Fornecedor";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Items.AddRange(new object[] { "Empresa 1", "Empresa 2", "Empresa 3" });
            SupplierComboBox.Location = new Point(574, 183);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(190, 23);
            SupplierComboBox.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            CategoryComboBox.Location = new Point(574, 122);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(192, 23);
            CategoryComboBox.TabIndex = 10;
            // 
            // NewProductLabel
            // 
            NewProductLabel.AutoSize = true;
            NewProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewProductLabel.Location = new Point(28, 40);
            NewProductLabel.Name = "NewProductLabel";
            NewProductLabel.Size = new Size(200, 37);
            NewProductLabel.TabIndex = 14;
            NewProductLabel.Text = "Novo produto";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(125, 122);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(190, 23);
            ProductNameTextBox.TabIndex = 15;
            // 
            // ProductDescriptionTextBox
            // 
            ProductDescriptionTextBox.Location = new Point(125, 183);
            ProductDescriptionTextBox.Multiline = true;
            ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            ProductDescriptionTextBox.Size = new Size(190, 23);
            ProductDescriptionTextBox.TabIndex = 16;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(348, 122);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(190, 23);
            ProductPriceTextBox.TabIndex = 17;
            ProductPriceTextBox.KeyPress += ProductPriceTextBox_KeyPress;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.Location = new Point(348, 183);
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(190, 23);
            ProductQuantityTextBox.TabIndex = 18;
            ProductQuantityTextBox.KeyPress += ProductQuantityTextBox_KeyPress;
            // 
            // ProductFibersTextBox
            // 
            ProductFibersTextBox.Location = new Point(348, 411);
            ProductFibersTextBox.Name = "ProductFibersTextBox";
            ProductFibersTextBox.Size = new Size(190, 23);
            ProductFibersTextBox.TabIndex = 50;
            // 
            // ProductFatsTextBox
            // 
            ProductFatsTextBox.Location = new Point(574, 337);
            ProductFatsTextBox.Name = "ProductFatsTextBox";
            ProductFatsTextBox.Size = new Size(190, 23);
            ProductFatsTextBox.TabIndex = 51;
            // 
            // FibersLabel
            // 
            FibersLabel.AutoSize = true;
            FibersLabel.Location = new Point(348, 393);
            FibersLabel.Name = "FibersLabel";
            FibersLabel.Size = new Size(38, 15);
            FibersLabel.TabIndex = 45;
            FibersLabel.Text = "Fibras";
            // 
            // ProductProteinsTextBox
            // 
            ProductProteinsTextBox.Location = new Point(125, 411);
            ProductProteinsTextBox.Name = "ProductProteinsTextBox";
            ProductProteinsTextBox.Size = new Size(190, 23);
            ProductProteinsTextBox.TabIndex = 48;
            // 
            // CaloriesLabel
            // 
            CaloriesLabel.AutoSize = true;
            CaloriesLabel.Location = new Point(125, 319);
            CaloriesLabel.Name = "CaloriesLabel";
            CaloriesLabel.Size = new Size(49, 15);
            CaloriesLabel.TabIndex = 42;
            CaloriesLabel.Text = "Calorias";
            // 
            // ProductCarbsTextBox
            // 
            ProductCarbsTextBox.Location = new Point(348, 337);
            ProductCarbsTextBox.Name = "ProductCarbsTextBox";
            ProductCarbsTextBox.Size = new Size(190, 23);
            ProductCarbsTextBox.TabIndex = 49;
            // 
            // ProductCaloriesTextBox
            // 
            ProductCaloriesTextBox.Location = new Point(125, 337);
            ProductCaloriesTextBox.Name = "ProductCaloriesTextBox";
            ProductCaloriesTextBox.Size = new Size(190, 23);
            ProductCaloriesTextBox.TabIndex = 47;
            // 
            // CarbsLabel
            // 
            CarbsLabel.AutoSize = true;
            CarbsLabel.Location = new Point(348, 319);
            CarbsLabel.Name = "CarbsLabel";
            CarbsLabel.Size = new Size(75, 15);
            CarbsLabel.TabIndex = 44;
            CarbsLabel.Text = "Carboidratos";
            // 
            // FatsLabel
            // 
            FatsLabel.AutoSize = true;
            FatsLabel.Location = new Point(574, 319);
            FatsLabel.Name = "FatsLabel";
            FatsLabel.Size = new Size(55, 15);
            FatsLabel.TabIndex = 46;
            FatsLabel.Text = "Gorduras";
            // 
            // ProteinsLabel
            // 
            ProteinsLabel.AutoSize = true;
            ProteinsLabel.Location = new Point(125, 393);
            ProteinsLabel.Name = "ProteinsLabel";
            ProteinsLabel.Size = new Size(56, 15);
            ProteinsLabel.TabIndex = 43;
            ProteinsLabel.Text = "Proteinas";
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Location = new Point(125, 232);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(91, 15);
            ImageLinkLabel.TabIndex = 38;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(747, 486);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 40;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(572, 486);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 41;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // ProductImageUrlTextBox
            // 
            ProductImageUrlTextBox.Location = new Point(125, 250);
            ProductImageUrlTextBox.Name = "ProductImageUrlTextBox";
            ProductImageUrlTextBox.Size = new Size(190, 23);
            ProductImageUrlTextBox.TabIndex = 39;
            // 
            // RegisterProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductFibersTextBox);
            Controls.Add(ProductFatsTextBox);
            Controls.Add(FibersLabel);
            Controls.Add(ProductProteinsTextBox);
            Controls.Add(CaloriesLabel);
            Controls.Add(ProductCarbsTextBox);
            Controls.Add(ProductCaloriesTextBox);
            Controls.Add(CarbsLabel);
            Controls.Add(FatsLabel);
            Controls.Add(ProteinsLabel);
            Controls.Add(ImageLinkLabel);
            Controls.Add(RegisterButton);
            Controls.Add(BackButton);
            Controls.Add(ProductImageUrlTextBox);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductDescriptionTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(NewProductLabel);
            Controls.Add(SupplierComboBox);
            Controls.Add(ManufacturerLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryComboBox);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductValueLabel);
            Controls.Add(ProductDescriptionLabel);
            Controls.Add(ProductNameLabel);
            Name = "RegisterProductControl";
            Size = new Size(960, 558);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductNameLabel;
        private Label ProductDescriptionLabel;
        private Label ProductValueLabel;
        private Label ProductQuantityLabel;
        private Label CategoryLabel;
        private Label ManufacturerLabel;
        private ComboBox SupplierComboBox;
        private ComboBox CategoryComboBox;
        private Label NewProductLabel;
        private TextBox ProductNameTextBox;
        private TextBox ProductDescriptionTextBox;
        private TextBox ProductPriceTextBox;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductFibersTextBox;
        private TextBox ProductFatsTextBox;
        private Label FibersLabel;
        private TextBox ProductProteinsTextBox;
        private Label CaloriesLabel;
        private TextBox ProductCarbsTextBox;
        private TextBox ProductCaloriesTextBox;
        private Label CarbsLabel;
        private Label FatsLabel;
        private Label ProteinsLabel;
        private Label ImageLinkLabel;
        private Button RegisterButton;
        private Button BackButton;
        private TextBox ProductImageUrlTextBox;
    }
}
