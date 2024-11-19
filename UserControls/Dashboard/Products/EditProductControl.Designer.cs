namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class EditProductControl
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
            SaveButton = new Button();
            BackButton = new Button();
            EditProductLabel = new Label();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            ProductImage = new PictureBox();
            ProductFibersTextBox = new TextBox();
            ProductFatsTextBox = new TextBox();
            ProductProteinsTextBox = new TextBox();
            ProductCarbsTextBox = new TextBox();
            ProductCaloriesTextBox = new TextBox();
            ImageLinkLabel = new Label();
            ProductImageUrlTextBox = new TextBox();
            ProductQuantityTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            ProductDescriptionTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(761, 462);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 67;
            SaveButton.Text = "Salvar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(586, 462);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 68;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EditProductLabel
            // 
            EditProductLabel.AutoSize = true;
            EditProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditProductLabel.Location = new Point(28, 19);
            EditProductLabel.Name = "EditProductLabel";
            EditProductLabel.Size = new Size(206, 37);
            EditProductLabel.TabIndex = 60;
            EditProductLabel.Text = "Editar produto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(218, 79);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 152;
            label11.Text = "Informações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(220, 252);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 144;
            label5.Text = "Quantidade em estoque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(220, 302);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 143;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(220, 204);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 151;
            label3.Text = "Valor por quilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(218, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 142;
            label2.Text = "Descricao";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(220, 104);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 150;
            label23.Text = "Nome";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(451, 302);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 149;
            label10.Text = "Gorduras";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(451, 252);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 148;
            label9.Text = "Fibras";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(451, 204);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 147;
            label8.Text = "Proteinas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(451, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 146;
            label7.Text = "Carboidratos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(451, 104);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 145;
            label6.Text = "Calorias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(451, 79);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 141;
            label1.Text = "Tabela nutricional";
            // 
            // ProductImage
            // 
            ProductImage.InitialImage = null;
            ProductImage.Location = new Point(30, 79);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(150, 150);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 140;
            ProductImage.TabStop = false;
            // 
            // ProductFibersTextBox
            // 
            ProductFibersTextBox.Location = new Point(451, 276);
            ProductFibersTextBox.Name = "ProductFibersTextBox";
            ProductFibersTextBox.Size = new Size(190, 23);
            ProductFibersTextBox.TabIndex = 138;
            // 
            // ProductFatsTextBox
            // 
            ProductFatsTextBox.Location = new Point(451, 326);
            ProductFatsTextBox.Name = "ProductFatsTextBox";
            ProductFatsTextBox.Size = new Size(190, 23);
            ProductFatsTextBox.TabIndex = 139;
            // 
            // ProductProteinsTextBox
            // 
            ProductProteinsTextBox.Location = new Point(451, 226);
            ProductProteinsTextBox.Name = "ProductProteinsTextBox";
            ProductProteinsTextBox.Size = new Size(190, 23);
            ProductProteinsTextBox.TabIndex = 136;
            // 
            // ProductCarbsTextBox
            // 
            ProductCarbsTextBox.Location = new Point(451, 178);
            ProductCarbsTextBox.Name = "ProductCarbsTextBox";
            ProductCarbsTextBox.Size = new Size(190, 23);
            ProductCarbsTextBox.TabIndex = 137;
            // 
            // ProductCaloriesTextBox
            // 
            ProductCaloriesTextBox.Location = new Point(451, 128);
            ProductCaloriesTextBox.Name = "ProductCaloriesTextBox";
            ProductCaloriesTextBox.Size = new Size(190, 23);
            ProductCaloriesTextBox.TabIndex = 135;
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(218, 352);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(121, 21);
            ImageLinkLabel.TabIndex = 133;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // ProductImageUrlTextBox
            // 
            ProductImageUrlTextBox.Location = new Point(218, 376);
            ProductImageUrlTextBox.Name = "ProductImageUrlTextBox";
            ProductImageUrlTextBox.Size = new Size(190, 23);
            ProductImageUrlTextBox.TabIndex = 134;
            ProductImageUrlTextBox.Leave += LoadProductImage;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.Location = new Point(220, 276);
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(190, 23);
            ProductQuantityTextBox.TabIndex = 132;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(220, 226);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(190, 23);
            ProductPriceTextBox.TabIndex = 131;
            // 
            // ProductDescriptionTextBox
            // 
            ProductDescriptionTextBox.Location = new Point(220, 178);
            ProductDescriptionTextBox.Multiline = true;
            ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            ProductDescriptionTextBox.Size = new Size(190, 23);
            ProductDescriptionTextBox.TabIndex = 130;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(220, 128);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(190, 23);
            ProductNameTextBox.TabIndex = 129;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            CategoryComboBox.Location = new Point(220, 326);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(190, 23);
            CategoryComboBox.TabIndex = 126;
            // 
            // EditProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(ProductImage);
            Controls.Add(ProductFibersTextBox);
            Controls.Add(ProductFatsTextBox);
            Controls.Add(ProductProteinsTextBox);
            Controls.Add(ProductCarbsTextBox);
            Controls.Add(ProductCaloriesTextBox);
            Controls.Add(ImageLinkLabel);
            Controls.Add(ProductImageUrlTextBox);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductDescriptionTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(EditProductLabel);
            Name = "EditProductControl";
            Size = new Size(954, 519);
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private Button BackButton;
        private Label EditProductLabel;
        private Label label11;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label23;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
        private PictureBox ProductImage;
        private TextBox ProductFibersTextBox;
        private TextBox ProductFatsTextBox;
        private TextBox ProductProteinsTextBox;
        private TextBox ProductCarbsTextBox;
        private TextBox ProductCaloriesTextBox;
        private Label ImageLinkLabel;
        private TextBox ProductImageUrlTextBox;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductPriceTextBox;
        private TextBox ProductDescriptionTextBox;
        private TextBox ProductNameTextBox;
        private ComboBox CategoryComboBox;
    }
}
