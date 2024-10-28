namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    partial class EditSupplierControl
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
            label2 = new Label();
            label23 = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            EditSupplierLabel = new Label();
            label1 = new Label();
            Phone = new Label();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            Email = new Label();
            label3 = new Label();
            CnpjTextBox = new TextBox();
            Addresses = new FlowLayoutPanel();
            label4 = new Label();
            NameTextBox = new TextBox();
            RegistrationDateTextBox = new TextBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(35, 106);
            label11.Name = "label11";
            label11.Size = new Size(190, 25);
            label11.TabIndex = 182;
            label11.Text = "Informações básicas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 181);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 172;
            label2.Text = "Data de cadastro";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(37, 131);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 180;
            label23.Text = "Nome";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(756, 494);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 154;
            SaveButton.Text = "Salvar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(581, 494);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 155;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EditSupplierLabel
            // 
            EditSupplierLabel.AutoSize = true;
            EditSupplierLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditSupplierLabel.Location = new Point(35, 28);
            EditSupplierLabel.Name = "EditSupplierLabel";
            EditSupplierLabel.Size = new Size(242, 37);
            EditSupplierLabel.TabIndex = 153;
            EditSupplierLabel.Text = "Editar fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(35, 299);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 183;
            label1.Text = "Informações de contato";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 12F);
            Phone.Location = new Point(37, 324);
            Phone.Name = "Phone";
            Phone.Size = new Size(67, 21);
            Phone.TabIndex = 184;
            Phone.Text = "Telefone";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(37, 348);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(190, 23);
            PhoneTextBox.TabIndex = 185;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(37, 398);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(190, 23);
            EmailTextBox.TabIndex = 186;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(37, 374);
            Email.Name = "Email";
            Email.Size = new Size(54, 21);
            Email.TabIndex = 187;
            Email.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(35, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 188;
            label3.Text = "CNPJ";
            // 
            // CnpjTextBox
            // 
            CnpjTextBox.Location = new Point(37, 255);
            CnpjTextBox.Multiline = true;
            CnpjTextBox.Name = "CnpjTextBox";
            CnpjTextBox.Size = new Size(190, 23);
            CnpjTextBox.TabIndex = 189;
            // 
            // Addresses
            // 
            Addresses.Location = new Point(293, 131);
            Addresses.Name = "Addresses";
            Addresses.Size = new Size(470, 315);
            Addresses.TabIndex = 190;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(293, 106);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 191;
            label4.Text = "Endereços";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(37, 155);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(190, 23);
            NameTextBox.TabIndex = 192;
            // 
            // RegistrationDateTextBox
            // 
            RegistrationDateTextBox.Location = new Point(35, 205);
            RegistrationDateTextBox.Multiline = true;
            RegistrationDateTextBox.Name = "RegistrationDateTextBox";
            RegistrationDateTextBox.Size = new Size(190, 23);
            RegistrationDateTextBox.TabIndex = 193;
            // 
            // EditSupplierControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RegistrationDateTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label4);
            Controls.Add(Addresses);
            Controls.Add(CnpjTextBox);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(Phone);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(EditSupplierLabel);
            Name = "EditSupplierControl";
            Size = new Size(960, 558);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label2;
        private Label label23;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
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
        private ComboBox SupplierComboBox;
        private Label ManufacturerLabel;
        private ComboBox CategoryComboBox;
        private Button SaveButton;
        private Button BackButton;
        private Label EditSupplierLabel;
        private Label label1;
        private Label Phone;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private Label Email;
        private Label label3;
        private TextBox CnpjTextBox;
        private FlowLayoutPanel Addresses;
        private Label label4;
        private TextBox NameTextBox;
        private TextBox RegistrationDateTextBox;
    }
}
