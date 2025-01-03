﻿namespace fazenda_verdeviva.UserControls.Dashboard.Products
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
            CategoryComboBox = new ComboBox();
            NewProductLabel = new Label();
            ProductNameTextBox = new TextBox();
            ProductDescriptionTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            ProductQuantityTextBox = new TextBox();
            ProductFibersTextBox = new TextBox();
            ProductFatsTextBox = new TextBox();
            ProductProteinsTextBox = new TextBox();
            ProductCarbsTextBox = new TextBox();
            ProductCaloriesTextBox = new TextBox();
            ImageLinkLabel = new Label();
            RegisterButton = new Button();
            BackButton = new Button();
            ProductImageUrlTextBox = new TextBox();
            ProductImage = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label23 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label11 = new Label();
            RegisterCategoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            CategoryComboBox.Location = new Point(211, 378);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(190, 23);
            CategoryComboBox.TabIndex = 10;
            // 
            // NewProductLabel
            // 
            NewProductLabel.AutoSize = true;
            NewProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewProductLabel.Location = new Point(28, 19);
            NewProductLabel.Name = "NewProductLabel";
            NewProductLabel.Size = new Size(254, 37);
            NewProductLabel.TabIndex = 14;
            NewProductLabel.Text = "Cadastrar produto";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(211, 128);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(190, 23);
            ProductNameTextBox.TabIndex = 15;
            // 
            // ProductDescriptionTextBox
            // 
            ProductDescriptionTextBox.Location = new Point(211, 178);
            ProductDescriptionTextBox.Multiline = true;
            ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            ProductDescriptionTextBox.Size = new Size(190, 23);
            ProductDescriptionTextBox.TabIndex = 16;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(211, 226);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(190, 23);
            ProductPriceTextBox.TabIndex = 17;
            ProductPriceTextBox.KeyPress += ProductPriceTextBox_KeyPress;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.Location = new Point(211, 276);
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(190, 23);
            ProductQuantityTextBox.TabIndex = 18;
            ProductQuantityTextBox.KeyPress += ProductQuantityTextBox_KeyPress;
            // 
            // ProductFibersTextBox
            // 
            ProductFibersTextBox.Location = new Point(442, 276);
            ProductFibersTextBox.Name = "ProductFibersTextBox";
            ProductFibersTextBox.Size = new Size(190, 23);
            ProductFibersTextBox.TabIndex = 50;
            // 
            // ProductFatsTextBox
            // 
            ProductFatsTextBox.Location = new Point(442, 326);
            ProductFatsTextBox.Name = "ProductFatsTextBox";
            ProductFatsTextBox.Size = new Size(190, 23);
            ProductFatsTextBox.TabIndex = 51;
            // 
            // ProductProteinsTextBox
            // 
            ProductProteinsTextBox.Location = new Point(442, 226);
            ProductProteinsTextBox.Name = "ProductProteinsTextBox";
            ProductProteinsTextBox.Size = new Size(190, 23);
            ProductProteinsTextBox.TabIndex = 48;
            // 
            // ProductCarbsTextBox
            // 
            ProductCarbsTextBox.Location = new Point(442, 178);
            ProductCarbsTextBox.Name = "ProductCarbsTextBox";
            ProductCarbsTextBox.Size = new Size(190, 23);
            ProductCarbsTextBox.TabIndex = 49;
            // 
            // ProductCaloriesTextBox
            // 
            ProductCaloriesTextBox.Location = new Point(442, 128);
            ProductCaloriesTextBox.Name = "ProductCaloriesTextBox";
            ProductCaloriesTextBox.Size = new Size(190, 23);
            ProductCaloriesTextBox.TabIndex = 47;
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(211, 304);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(121, 21);
            ImageLinkLabel.TabIndex = 38;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(761, 462);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 40;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click_1;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(586, 462);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 41;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ProductImageUrlTextBox
            // 
            ProductImageUrlTextBox.Location = new Point(209, 328);
            ProductImageUrlTextBox.Name = "ProductImageUrlTextBox";
            ProductImageUrlTextBox.Size = new Size(190, 23);
            ProductImageUrlTextBox.TabIndex = 39;
            ProductImageUrlTextBox.Leave += LoadProductImage;
            // 
            // ProductImage
            // 
            ProductImage.InitialImage = null;
            ProductImage.Location = new Point(28, 79);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(150, 150);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 100;
            ProductImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(442, 79);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 103;
            label1.Text = "Tabela nutricional";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(442, 104);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 118;
            label6.Text = "Calorias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(442, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 119;
            label7.Text = "Carboidratos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(442, 204);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 120;
            label8.Text = "Proteinas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(442, 252);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 121;
            label9.Text = "Fibras";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(442, 302);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 122;
            label10.Text = "Gorduras";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(211, 104);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 123;
            label23.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(209, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 114;
            label2.Text = "Descricao";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(211, 204);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 124;
            label3.Text = "Valor por quilo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(211, 354);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 117;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(211, 252);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 117;
            label5.Text = "Quantidade em estoque";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(209, 79);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 125;
            label11.Text = "Informações";
            // 
            // RegisterCategoryButton
            // 
            RegisterCategoryButton.Location = new Point(211, 404);
            RegisterCategoryButton.Name = "RegisterCategoryButton";
            RegisterCategoryButton.Size = new Size(190, 23);
            RegisterCategoryButton.TabIndex = 126;
            RegisterCategoryButton.Text = "Cadastrar";
            RegisterCategoryButton.UseVisualStyleBackColor = true;
            RegisterCategoryButton.Click += RegisterCategoryButton_Click;
            // 
            // RegisterProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RegisterCategoryButton);
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
            Controls.Add(RegisterButton);
            Controls.Add(BackButton);
            Controls.Add(ProductImageUrlTextBox);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductDescriptionTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(NewProductLabel);
            Controls.Add(CategoryComboBox);
            Name = "RegisterProductControl";
            Size = new Size(954, 519);
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CategoryComboBox;
        private Label NewProductLabel;
        private TextBox ProductNameTextBox;
        private TextBox ProductDescriptionTextBox;
        private TextBox ProductPriceTextBox;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductFibersTextBox;
        private TextBox ProductFatsTextBox;
        private TextBox ProductProteinsTextBox;
        private TextBox ProductCarbsTextBox;
        private TextBox ProductCaloriesTextBox;
        private Label ImageLinkLabel;
        private Button RegisterButton;
        private Button BackButton;
        private TextBox ProductImageUrlTextBox;
        private PictureBox ProductImage;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label23;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label11;
        private Button RegisterCategoryButton;
    }
}
