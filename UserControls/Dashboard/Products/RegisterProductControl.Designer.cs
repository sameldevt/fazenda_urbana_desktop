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
            ImageLinkLabel = new Label();
            FibersLabel = new Label();
            CategoryLabel = new Label();
            ManufacturerLabel = new Label();
            ManufacturerComboBox = new ComboBox();
            CategoryComboBox = new ComboBox();
            NewProductLabel = new Label();
            ProductNameTextBox = new TextBox();
            ProductDescriptionTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            ProductQuantityTextBox = new TextBox();
            ProductImageUrlTextBox = new TextBox();
            RegisterButton = new Button();
            BackButton = new Button();
            panel2 = new Panel();
            ProductProteinsTextBox = new TextBox();
            ProteinsLabel = new Label();
            ProductFibersTextBox = new TextBox();
            ProductFatsTextBox = new TextBox();
            FatsLabel = new Label();
            CarbsLabel = new Label();
            ProductCarbsTextBox = new TextBox();
            ProductCaloriesTextBox = new TextBox();
            CaloriesLabel = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(141, 95);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(40, 15);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Nome";
            // 
            // ProductDescriptionLabel
            // 
            ProductDescriptionLabel.AutoSize = true;
            ProductDescriptionLabel.Location = new Point(141, 156);
            ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            ProductDescriptionLabel.Size = new Size(53, 15);
            ProductDescriptionLabel.TabIndex = 1;
            ProductDescriptionLabel.Text = "Decrição";
            // 
            // ProductValueLabel
            // 
            ProductValueLabel.AutoSize = true;
            ProductValueLabel.Location = new Point(364, 95);
            ProductValueLabel.Name = "ProductValueLabel";
            ProductValueLabel.Size = new Size(88, 15);
            ProductValueLabel.TabIndex = 2;
            ProductValueLabel.Text = "Preço por quilo";
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.Location = new Point(364, 156);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(93, 15);
            ProductQuantityLabel.TabIndex = 3;
            ProductQuantityLabel.Text = "Quantidade (kg)";
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Location = new Point(141, 221);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(91, 15);
            ImageLinkLabel.TabIndex = 4;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // FibersLabel
            // 
            FibersLabel.AutoSize = true;
            FibersLabel.Location = new Point(236, 112);
            FibersLabel.Name = "FibersLabel";
            FibersLabel.Size = new Size(38, 15);
            FibersLabel.TabIndex = 8;
            FibersLabel.Text = "Fibras";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(590, 95);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 11;
            CategoryLabel.Text = "Categoria";
            // 
            // ManufacturerLabel
            // 
            ManufacturerLabel.AutoSize = true;
            ManufacturerLabel.Location = new Point(590, 156);
            ManufacturerLabel.Name = "ManufacturerLabel";
            ManufacturerLabel.Size = new Size(67, 15);
            ManufacturerLabel.TabIndex = 12;
            ManufacturerLabel.Text = "Fornecedor";
            // 
            // ManufacturerComboBox
            // 
            ManufacturerComboBox.FormattingEnabled = true;
            ManufacturerComboBox.Items.AddRange(new object[] { "Empresa 1", "Empresa 2", "Empresa 3" });
            ManufacturerComboBox.Location = new Point(590, 174);
            ManufacturerComboBox.Name = "ManufacturerComboBox";
            ManufacturerComboBox.Size = new Size(190, 23);
            ManufacturerComboBox.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            CategoryComboBox.Location = new Point(590, 113);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(192, 23);
            CategoryComboBox.TabIndex = 10;
            // 
            // NewProductLabel
            // 
            NewProductLabel.AutoSize = true;
            NewProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewProductLabel.Location = new Point(44, 31);
            NewProductLabel.Name = "NewProductLabel";
            NewProductLabel.Size = new Size(200, 37);
            NewProductLabel.TabIndex = 14;
            NewProductLabel.Text = "Novo produto";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(141, 113);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(190, 23);
            ProductNameTextBox.TabIndex = 15;
            // 
            // ProductDescriptionTextBox
            // 
            ProductDescriptionTextBox.Location = new Point(141, 174);
            ProductDescriptionTextBox.Multiline = true;
            ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            ProductDescriptionTextBox.Size = new Size(190, 23);
            ProductDescriptionTextBox.TabIndex = 16;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(364, 113);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(190, 23);
            ProductPriceTextBox.TabIndex = 17;
            ProductPriceTextBox.KeyPress += ProductPriceTextBox_KeyPress;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.Location = new Point(364, 174);
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(190, 23);
            ProductQuantityTextBox.TabIndex = 18;
            ProductQuantityTextBox.KeyPress += ProductQuantityTextBox_KeyPress;
            // 
            // ProductImageUrlTextBox
            // 
            ProductImageUrlTextBox.Location = new Point(141, 239);
            ProductImageUrlTextBox.Name = "ProductImageUrlTextBox";
            ProductImageUrlTextBox.Size = new Size(190, 23);
            ProductImageUrlTextBox.TabIndex = 19;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(763, 475);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 26;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(588, 475);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 27;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(RegisterButton);
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 558);
            panel2.TabIndex = 28;
            // 
            // ProductProteinsTextBox
            // 
            ProductProteinsTextBox.Location = new Point(13, 130);
            ProductProteinsTextBox.Name = "ProductProteinsTextBox";
            ProductProteinsTextBox.Size = new Size(190, 23);
            ProductProteinsTextBox.TabIndex = 21;
            ProductProteinsTextBox.KeyPress += ProductProteinsTextBox_KeyPress;
            // 
            // ProteinsLabel
            // 
            ProteinsLabel.AutoSize = true;
            ProteinsLabel.Location = new Point(14, 112);
            ProteinsLabel.Name = "ProteinsLabel";
            ProteinsLabel.Size = new Size(56, 15);
            ProteinsLabel.TabIndex = 6;
            ProteinsLabel.Text = "Proteinas";
            // 
            // ProductFibersTextBox
            // 
            ProductFibersTextBox.Location = new Point(236, 130);
            ProductFibersTextBox.Name = "ProductFibersTextBox";
            ProductFibersTextBox.Size = new Size(190, 23);
            ProductFibersTextBox.TabIndex = 23;
            ProductFibersTextBox.KeyPress += ProductFibersTextBox_KeyPress;
            // 
            // ProductFatsTextBox
            // 
            ProductFatsTextBox.Location = new Point(462, 55);
            ProductFatsTextBox.Name = "ProductFatsTextBox";
            ProductFatsTextBox.Size = new Size(190, 23);
            ProductFatsTextBox.TabIndex = 24;
            ProductFatsTextBox.KeyPress += ProductFatsTextBox_KeyPress;
            // 
            // FatsLabel
            // 
            FatsLabel.AutoSize = true;
            FatsLabel.Location = new Point(462, 37);
            FatsLabel.Name = "FatsLabel";
            FatsLabel.Size = new Size(55, 15);
            FatsLabel.TabIndex = 9;
            FatsLabel.Text = "Gorduras";
            // 
            // CarbsLabel
            // 
            CarbsLabel.AutoSize = true;
            CarbsLabel.Location = new Point(236, 37);
            CarbsLabel.Name = "CarbsLabel";
            CarbsLabel.Size = new Size(75, 15);
            CarbsLabel.TabIndex = 7;
            CarbsLabel.Text = "Carboidratos";
            // 
            // ProductCarbsTextBox
            // 
            ProductCarbsTextBox.Location = new Point(236, 55);
            ProductCarbsTextBox.Name = "ProductCarbsTextBox";
            ProductCarbsTextBox.Size = new Size(190, 23);
            ProductCarbsTextBox.TabIndex = 22;
            ProductCarbsTextBox.KeyPress += ProductCarbsTextBox_KeyPress;
            // 
            // ProductCaloriesTextBox
            // 
            ProductCaloriesTextBox.Location = new Point(13, 55);
            ProductCaloriesTextBox.Name = "ProductCaloriesTextBox";
            ProductCaloriesTextBox.Size = new Size(190, 23);
            ProductCaloriesTextBox.TabIndex = 20;
            ProductCaloriesTextBox.KeyPress += ProductCaloriesTextBox_KeyPress;
            // 
            // CaloriesLabel
            // 
            CaloriesLabel.AutoSize = true;
            CaloriesLabel.Location = new Point(13, 37);
            CaloriesLabel.Name = "CaloriesLabel";
            CaloriesLabel.Size = new Size(49, 15);
            CaloriesLabel.TabIndex = 5;
            CaloriesLabel.Text = "Calorias";
            // 
            // panel1
            // 
            panel1.Controls.Add(ProductFibersTextBox);
            panel1.Controls.Add(ProductFatsTextBox);
            panel1.Controls.Add(FibersLabel);
            panel1.Controls.Add(ProductProteinsTextBox);
            panel1.Controls.Add(CaloriesLabel);
            panel1.Controls.Add(ProductCarbsTextBox);
            panel1.Controls.Add(ProductCaloriesTextBox);
            panel1.Controls.Add(CarbsLabel);
            panel1.Controls.Add(FatsLabel);
            panel1.Controls.Add(ProteinsLabel);
            panel1.Location = new Point(124, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 178);
            panel1.TabIndex = 25;
            // 
            // RegisterProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductImageUrlTextBox);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductDescriptionTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(NewProductLabel);
            Controls.Add(ManufacturerComboBox);
            Controls.Add(ManufacturerLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryComboBox);
            Controls.Add(ImageLinkLabel);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductValueLabel);
            Controls.Add(ProductDescriptionLabel);
            Controls.Add(ProductNameLabel);
            Controls.Add(panel2);
            Name = "RegisterProductControl";
            Size = new Size(960, 558);
            Load += RegisterProductControl_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductNameLabel;
        private Label ProductDescriptionLabel;
        private Label ProductValueLabel;
        private Label ProductQuantityLabel;
        private Label ImageLinkLabel;
        private Label FibersLabel;
        private Label CategoryLabel;
        private Label ManufacturerLabel;
        private ComboBox ManufacturerComboBox;
        private ComboBox CategoryComboBox;
        private Label NewProductLabel;
        private TextBox ProductNameTextBox;
        private TextBox ProductDescriptionTextBox;
        private TextBox ProductPriceTextBox;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductImageUrlTextBox;
        private Button RegisterButton;
        private Button BackButton;
        private Panel panel2;
        private TextBox ProductProteinsTextBox;
        private Label ProteinsLabel;
        private TextBox ProductFibersTextBox;
        private TextBox ProductFatsTextBox;
        private Label FatsLabel;
        private Label CarbsLabel;
        private TextBox ProductCarbsTextBox;
        private TextBox ProductCaloriesTextBox;
        private Label CaloriesLabel;
        private Panel panel1;
    }
}
