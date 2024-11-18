namespace fazenda_verdeviva.UserControls.Dashboard.Supplies
{
    partial class EditSupplyControl
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
            ExpirationDate = new DateTimePicker();
            label9 = new Label();
            ManufacturingDate = new DateTimePicker();
            label8 = new Label();
            SupplierComboBox = new ComboBox();
            label7 = new Label();
            PurchaseDate = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            UnitPrice = new TextBox();
            CategoryComboBox = new ComboBox();
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            SupplyImage = new PictureBox();
            ImageLinkLabel = new Label();
            RegisterButton = new Button();
            BackButton = new Button();
            ImageUrl = new TextBox();
            StockQuantity = new TextBox();
            SupplyDescription = new TextBox();
            SupplyName = new TextBox();
            NewProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SupplyImage).BeginInit();
            SuspendLayout();
            // 
            // ExpirationDate
            // 
            ExpirationDate.Location = new Point(422, 228);
            ExpirationDate.Name = "ExpirationDate";
            ExpirationDate.Size = new Size(190, 23);
            ExpirationDate.TabIndex = 228;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(422, 204);
            label9.Name = "label9";
            label9.Size = new Size(148, 21);
            label9.TabIndex = 227;
            label9.Text = "Data de vencimento";
            // 
            // ManufacturingDate
            // 
            ManufacturingDate.Location = new Point(422, 178);
            ManufacturingDate.Name = "ManufacturingDate";
            ManufacturingDate.Size = new Size(190, 23);
            ManufacturingDate.TabIndex = 226;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(422, 154);
            label8.Name = "label8";
            label8.Size = new Size(138, 21);
            label8.TabIndex = 225;
            label8.Text = "Data de fabricação";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            SupplierComboBox.Location = new Point(209, 376);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(190, 23);
            SupplierComboBox.TabIndex = 224;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(209, 352);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 223;
            label7.Text = "Fornecedor";
            // 
            // PurchaseDate
            // 
            PurchaseDate.Location = new Point(422, 128);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(190, 23);
            PurchaseDate.TabIndex = 222;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(422, 104);
            label13.Name = "label13";
            label13.Size = new Size(120, 21);
            label13.TabIndex = 221;
            label13.Text = "Data da compra";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(209, 302);
            label12.Name = "label12";
            label12.Size = new Size(107, 21);
            label12.TabIndex = 220;
            label12.Text = "Preço unitário";
            // 
            // UnitPrice
            // 
            UnitPrice.Location = new Point(209, 326);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(190, 23);
            UnitPrice.TabIndex = 219;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            CategoryComboBox.Location = new Point(209, 228);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(190, 23);
            CategoryComboBox.TabIndex = 218;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(207, 79);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 217;
            label11.Text = "Informações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(209, 252);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 214;
            label5.Text = "Quantidade em estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(209, 204);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 216;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(207, 154);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 213;
            label2.Text = "Descricao";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(209, 104);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 215;
            label23.Text = "Nome";
            // 
            // SupplyImage
            // 
            SupplyImage.InitialImage = null;
            SupplyImage.Location = new Point(26, 79);
            SupplyImage.Name = "SupplyImage";
            SupplyImage.Size = new Size(150, 150);
            SupplyImage.SizeMode = PictureBoxSizeMode.Zoom;
            SupplyImage.TabIndex = 212;
            SupplyImage.TabStop = false;
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(207, 402);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(121, 21);
            ImageLinkLabel.TabIndex = 208;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(759, 462);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 210;
            RegisterButton.Text = "Editar";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(584, 462);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 211;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // ImageUrl
            // 
            ImageUrl.Location = new Point(207, 426);
            ImageUrl.Name = "ImageUrl";
            ImageUrl.Size = new Size(190, 23);
            ImageUrl.TabIndex = 209;
            // 
            // StockQuantity
            // 
            StockQuantity.Location = new Point(209, 276);
            StockQuantity.Name = "StockQuantity";
            StockQuantity.Size = new Size(190, 23);
            StockQuantity.TabIndex = 207;
            // 
            // SupplyDescription
            // 
            SupplyDescription.Location = new Point(209, 178);
            SupplyDescription.Multiline = true;
            SupplyDescription.Name = "SupplyDescription";
            SupplyDescription.Size = new Size(190, 23);
            SupplyDescription.TabIndex = 206;
            // 
            // SupplyName
            // 
            SupplyName.Location = new Point(209, 128);
            SupplyName.Name = "SupplyName";
            SupplyName.Size = new Size(190, 23);
            SupplyName.TabIndex = 205;
            // 
            // NewProductLabel
            // 
            NewProductLabel.AutoSize = true;
            NewProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewProductLabel.Location = new Point(27, 20);
            NewProductLabel.Name = "NewProductLabel";
            NewProductLabel.Size = new Size(271, 37);
            NewProductLabel.TabIndex = 204;
            NewProductLabel.Text = "Detalhes do insumo";
            // 
            // EditSupplyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ExpirationDate);
            Controls.Add(label9);
            Controls.Add(ManufacturingDate);
            Controls.Add(label8);
            Controls.Add(SupplierComboBox);
            Controls.Add(label7);
            Controls.Add(PurchaseDate);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(UnitPrice);
            Controls.Add(CategoryComboBox);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(SupplyImage);
            Controls.Add(ImageLinkLabel);
            Controls.Add(RegisterButton);
            Controls.Add(BackButton);
            Controls.Add(ImageUrl);
            Controls.Add(StockQuantity);
            Controls.Add(SupplyDescription);
            Controls.Add(SupplyName);
            Controls.Add(NewProductLabel);
            Name = "EditSupplyControl";
            Size = new Size(954, 519);
            ((System.ComponentModel.ISupportInitialize)SupplyImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ExpirationDate;
        private Label label9;
        private DateTimePicker ManufacturingDate;
        private Label label8;
        private ComboBox SupplierComboBox;
        private Label label7;
        private DateTimePicker PurchaseDate;
        private Label label13;
        private Label label12;
        private TextBox UnitPrice;
        private ComboBox CategoryComboBox;
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label23;
        private PictureBox SupplyImage;
        private Label ImageLinkLabel;
        private Button RegisterButton;
        private Button BackButton;
        private TextBox ImageUrl;
        private TextBox StockQuantity;
        private TextBox SupplyDescription;
        private TextBox SupplyName;
        private Label NewProductLabel;
    }
}
