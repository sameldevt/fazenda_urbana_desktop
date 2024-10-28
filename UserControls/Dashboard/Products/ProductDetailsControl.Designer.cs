namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductDetailsControl
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
            BackButton = new Button();
            ProductName = new Label();
            ProductDescription = new Label();
            ProductPrice = new Label();
            ProductQuantity = new Label();
            ProductImage = new PictureBox();
            ProductCategory = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ProductCalories = new Label();
            label1 = new Label();
            ProductCarbs = new Label();
            ProductProteins = new Label();
            ProductFibers = new Label();
            ProductFats = new Label();
            SupplierCnpj = new Label();
            SupplierEmail = new Label();
            SupplierName = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(753, 484);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 95;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ProductName.Location = new Point(228, 57);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(123, 37);
            ProductName.TabIndex = 87;
            ProductName.Text = "Produto";
            // 
            // ProductDescription
            // 
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Segoe UI", 14F);
            ProductDescription.Location = new Point(228, 94);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(94, 25);
            ProductDescription.TabIndex = 96;
            ProductDescription.Text = "Descricao";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Font = new Font("Segoe UI", 14F);
            ProductPrice.ForeColor = Color.Green;
            ProductPrice.Location = new Point(436, 73);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(72, 25);
            ProductPrice.TabIndex = 97;
            ProductPrice.Text = "R$ 1,00";
            // 
            // ProductQuantity
            // 
            ProductQuantity.AutoSize = true;
            ProductQuantity.Font = new Font("Segoe UI", 14F);
            ProductQuantity.ForeColor = Color.Green;
            ProductQuantity.Location = new Point(436, 98);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(67, 25);
            ProductQuantity.TabIndex = 98;
            ProductQuantity.Text = "100 kg";
            ProductQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProductImage
            // 
            ProductImage.InitialImage = null;
            ProductImage.Location = new Point(61, 57);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(150, 150);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 99;
            ProductImage.TabStop = false;
            // 
            // ProductCategory
            // 
            ProductCategory.AutoSize = true;
            ProductCategory.Font = new Font("Segoe UI", 14F);
            ProductCategory.ForeColor = Color.Green;
            ProductCategory.Location = new Point(436, 123);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(63, 25);
            ProductCategory.TabIndex = 100;
            ProductCategory.Text = "Frutas";
            ProductCategory.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ProductCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ProductPrice);
            panel1.Controls.Add(ProductQuantity);
            panel1.Location = new Point(48, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 173);
            panel1.TabIndex = 112;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(180, 123);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 116;
            label5.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(180, 98);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 115;
            label4.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(180, 73);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 114;
            label3.Text = "Valor por quilo:";
            // 
            // ProductCalories
            // 
            ProductCalories.AutoSize = true;
            ProductCalories.Font = new Font("Segoe UI", 14F);
            ProductCalories.ForeColor = Color.Green;
            ProductCalories.Location = new Point(180, 39);
            ProductCalories.Name = "ProductCalories";
            ProductCalories.Size = new Size(77, 25);
            ProductCalories.TabIndex = 104;
            ProductCalories.Text = "calorias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 102;
            label1.Text = "Tabela nutricional";
            // 
            // ProductCarbs
            // 
            ProductCarbs.AutoSize = true;
            ProductCarbs.Font = new Font("Segoe UI", 14F);
            ProductCarbs.ForeColor = Color.Green;
            ProductCarbs.Location = new Point(180, 64);
            ProductCarbs.Name = "ProductCarbs";
            ProductCarbs.Size = new Size(118, 25);
            ProductCarbs.TabIndex = 103;
            ProductCarbs.Text = "carboidratos";
            // 
            // ProductProteins
            // 
            ProductProteins.AutoSize = true;
            ProductProteins.Font = new Font("Segoe UI", 14F);
            ProductProteins.ForeColor = Color.Green;
            ProductProteins.Location = new Point(180, 89);
            ProductProteins.Name = "ProductProteins";
            ProductProteins.Size = new Size(91, 25);
            ProductProteins.TabIndex = 105;
            ProductProteins.Text = "proteinas";
            // 
            // ProductFibers
            // 
            ProductFibers.AutoSize = true;
            ProductFibers.Font = new Font("Segoe UI", 14F);
            ProductFibers.ForeColor = Color.Green;
            ProductFibers.Location = new Point(180, 114);
            ProductFibers.Name = "ProductFibers";
            ProductFibers.Size = new Size(59, 25);
            ProductFibers.TabIndex = 106;
            ProductFibers.Text = "fibras";
            // 
            // ProductFats
            // 
            ProductFats.AutoSize = true;
            ProductFats.Font = new Font("Segoe UI", 14F);
            ProductFats.ForeColor = Color.Green;
            ProductFats.Location = new Point(180, 139);
            ProductFats.Name = "ProductFats";
            ProductFats.Size = new Size(88, 25);
            ProductFats.TabIndex = 107;
            ProductFats.Text = "gorduras";
            // 
            // SupplierCnpj
            // 
            SupplierCnpj.AutoSize = true;
            SupplierCnpj.Font = new Font("Segoe UI", 14F);
            SupplierCnpj.ForeColor = Color.Green;
            SupplierCnpj.Location = new Point(513, 89);
            SupplierCnpj.Name = "SupplierCnpj";
            SupplierCnpj.Size = new Size(55, 25);
            SupplierCnpj.TabIndex = 111;
            SupplierCnpj.Text = "CNPJ";
            SupplierCnpj.TextAlign = ContentAlignment.TopRight;
            // 
            // SupplierEmail
            // 
            SupplierEmail.AutoSize = true;
            SupplierEmail.Font = new Font("Segoe UI", 14F);
            SupplierEmail.ForeColor = Color.Green;
            SupplierEmail.Location = new Point(513, 64);
            SupplierEmail.Name = "SupplierEmail";
            SupplierEmail.Size = new Size(156, 25);
            SupplierEmail.TabIndex = 110;
            SupplierEmail.Text = "Email fornecedor";
            SupplierEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Font = new Font("Segoe UI", 14F);
            SupplierName.ForeColor = Color.Green;
            SupplierName.Location = new Point(513, 39);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(161, 25);
            SupplierName.TabIndex = 109;
            SupplierName.Text = "Nome fornecedor";
            SupplierName.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(404, 14);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 108;
            label2.Text = "Fornecedor";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(13, 39);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 117;
            label6.Text = "Calorias:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(13, 64);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 118;
            label7.Text = "Carboidratos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(13, 89);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 119;
            label8.Text = "Proteinas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(13, 114);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 120;
            label9.Text = "Fibras:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(13, 139);
            label10.Name = "label10";
            label10.Size = new Size(94, 25);
            label10.TabIndex = 121;
            label10.Text = "Gorduras:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.Location = new Point(404, 39);
            label11.Name = "label11";
            label11.Size = new Size(67, 25);
            label11.TabIndex = 122;
            label11.Text = "Nome:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F);
            label12.Location = new Point(404, 64);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 123;
            label12.Text = "E-mail:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(404, 89);
            label13.Name = "label13";
            label13.Size = new Size(59, 25);
            label13.TabIndex = 124;
            label13.Text = "CNPJ:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(SupplierName);
            panel2.Controls.Add(SupplierEmail);
            panel2.Controls.Add(SupplierCnpj);
            panel2.Controls.Add(ProductFats);
            panel2.Controls.Add(ProductFibers);
            panel2.Controls.Add(ProductProteins);
            panel2.Controls.Add(ProductCarbs);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ProductCalories);
            panel2.Location = new Point(48, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 173);
            panel2.TabIndex = 113;
            // 
            // ProductDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductImage);
            Controls.Add(ProductDescription);
            Controls.Add(BackButton);
            Controls.Add(ProductName);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ProductDetailsControl";
            Size = new Size(960, 558);
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Label ProductName;
        private Label ProductDescription;
        private Label ProductPrice;
        private Label ProductQuantity;
        private PictureBox ProductImage;
        private Label ProductCategory;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label ProductCalories;
        private Label label1;
        private Label ProductCarbs;
        private Label ProductProteins;
        private Label ProductFibers;
        private Label ProductFats;
        private Label SupplierCnpj;
        private Label SupplierEmail;
        private Label SupplierName;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel2;
    }
}
