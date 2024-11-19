﻿namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    partial class RegisterEquipmentControl
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
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            EquipmentImage = new PictureBox();
            ImageLinkLabel = new Label();
            RegisterButton = new Button();
            BackButton = new Button();
            ImageUrl = new TextBox();
            EquipmentBrand = new TextBox();
            EquipmentDescription = new TextBox();
            EquipmentName = new TextBox();
            NewProductLabel = new Label();
            TypeComboBox = new ComboBox();
            label12 = new Label();
            EquipmentModel = new TextBox();
            label13 = new Label();
            PurchaseDate = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            AcquisitionValue = new TextBox();
            ManufacturingYear = new TextBox();
            LocationComboBox = new ComboBox();
            label6 = new Label();
            SupplierComboBox = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)EquipmentImage).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(207, 78);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 157;
            label11.Text = "Informações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(209, 251);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 149;
            label5.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(209, 203);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 156;
            label3.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(207, 153);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 147;
            label2.Text = "Descricao";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(209, 103);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 155;
            label23.Text = "Nome";
            // 
            // EquipmentImage
            // 
            EquipmentImage.InitialImage = null;
            EquipmentImage.Location = new Point(26, 78);
            EquipmentImage.Name = "EquipmentImage";
            EquipmentImage.Size = new Size(150, 150);
            EquipmentImage.SizeMode = PictureBoxSizeMode.Zoom;
            EquipmentImage.TabIndex = 145;
            EquipmentImage.TabStop = false;
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(209, 401);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(121, 21);
            ImageLinkLabel.TabIndex = 136;
            ImageLinkLabel.Text = "URL da imagem";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(759, 461);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 138;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(584, 461);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 139;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ImageUrl
            // 
            ImageUrl.Location = new Point(209, 425);
            ImageUrl.Name = "ImageUrl";
            ImageUrl.Size = new Size(190, 23);
            ImageUrl.TabIndex = 137;
            ImageUrl.Leave += LoadEquipmentImage;
            // 
            // EquipmentBrand
            // 
            EquipmentBrand.Location = new Point(209, 275);
            EquipmentBrand.Name = "EquipmentBrand";
            EquipmentBrand.Size = new Size(190, 23);
            EquipmentBrand.TabIndex = 135;
            // 
            // EquipmentDescription
            // 
            EquipmentDescription.Location = new Point(209, 177);
            EquipmentDescription.Multiline = true;
            EquipmentDescription.Name = "EquipmentDescription";
            EquipmentDescription.Size = new Size(190, 23);
            EquipmentDescription.TabIndex = 133;
            // 
            // EquipmentName
            // 
            EquipmentName.Location = new Point(209, 127);
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Size = new Size(190, 23);
            EquipmentName.TabIndex = 132;
            // 
            // NewProductLabel
            // 
            NewProductLabel.AutoSize = true;
            NewProductLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewProductLabel.Location = new Point(26, 18);
            NewProductLabel.Name = "NewProductLabel";
            NewProductLabel.Size = new Size(320, 37);
            NewProductLabel.TabIndex = 131;
            NewProductLabel.Text = "Cadastrar equipamento";
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            TypeComboBox.Location = new Point(209, 227);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(190, 23);
            TypeComboBox.TabIndex = 160;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(209, 301);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 162;
            label12.Text = "Modelo";
            // 
            // EquipmentModel
            // 
            EquipmentModel.Location = new Point(209, 325);
            EquipmentModel.Name = "EquipmentModel";
            EquipmentModel.Size = new Size(190, 23);
            EquipmentModel.TabIndex = 161;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(209, 351);
            label13.Name = "label13";
            label13.Size = new Size(120, 21);
            label13.TabIndex = 163;
            label13.Text = "Data da compra";
            // 
            // PurchaseDate
            // 
            PurchaseDate.Format = DateTimePickerFormat.Short;
            PurchaseDate.Location = new Point(209, 375);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(190, 23);
            PurchaseDate.TabIndex = 164;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(416, 153);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 167;
            label1.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(418, 103);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 168;
            label4.Text = "Ano de fabricação";
            // 
            // AcquisitionValue
            // 
            AcquisitionValue.Location = new Point(418, 177);
            AcquisitionValue.Multiline = true;
            AcquisitionValue.Name = "AcquisitionValue";
            AcquisitionValue.Size = new Size(190, 23);
            AcquisitionValue.TabIndex = 166;
            // 
            // ManufacturingYear
            // 
            ManufacturingYear.Location = new Point(418, 127);
            ManufacturingYear.Name = "ManufacturingYear";
            ManufacturingYear.Size = new Size(190, 23);
            ManufacturingYear.TabIndex = 165;
            // 
            // LocationComboBox
            // 
            LocationComboBox.FormattingEnabled = true;
            LocationComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            LocationComboBox.Location = new Point(418, 227);
            LocationComboBox.Name = "LocationComboBox";
            LocationComboBox.Size = new Size(190, 23);
            LocationComboBox.TabIndex = 170;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(418, 203);
            label6.Name = "label6";
            label6.Size = new Size(127, 21);
            label6.TabIndex = 169;
            label6.Text = "Localização atual";
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            SupplierComboBox.Location = new Point(418, 277);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(190, 23);
            SupplierComboBox.TabIndex = 172;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(418, 253);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 171;
            label7.Text = "Fornecedor";
            // 
            // RegisterEquipmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SupplierComboBox);
            Controls.Add(label7);
            Controls.Add(LocationComboBox);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(AcquisitionValue);
            Controls.Add(ManufacturingYear);
            Controls.Add(PurchaseDate);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(EquipmentModel);
            Controls.Add(TypeComboBox);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(EquipmentImage);
            Controls.Add(ImageLinkLabel);
            Controls.Add(RegisterButton);
            Controls.Add(BackButton);
            Controls.Add(ImageUrl);
            Controls.Add(EquipmentBrand);
            Controls.Add(EquipmentDescription);
            Controls.Add(EquipmentName);
            Controls.Add(NewProductLabel);
            Name = "RegisterEquipmentControl";
            Size = new Size(954, 519);
            ((System.ComponentModel.ISupportInitialize)EquipmentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label23;
        private PictureBox EquipmentImage;
        private Label ImageLinkLabel;
        private Button RegisterButton;
        private Button BackButton;
        private TextBox ImageUrl;
        private TextBox EquipmentBrand;
        private TextBox EquipmentDescription;
        private TextBox EquipmentName;
        private Label NewProductLabel;
        private ComboBox TypeComboBox;
        private Label label12;
        private TextBox EquipmentModel;
        private Label label13;
        private DateTimePicker PurchaseDate;
        private Label label1;
        private Label label4;
        private TextBox AcquisitionValue;
        private TextBox ManufacturingYear;
        private ComboBox LocationComboBox;
        private Label label6;
        private ComboBox SupplierComboBox;
        private Label label7;
    }
}
