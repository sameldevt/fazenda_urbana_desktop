namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    partial class SupplierDetailsControl
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
            label13 = new Label();
            WebsiteTextBox = new TextBox();
            NameTextBox = new TextBox();
            label4 = new Label();
            Addresses = new FlowLayoutPanel();
            CnpjTextBox = new TextBox();
            label3 = new Label();
            Email = new Label();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            Phone = new Label();
            label1 = new Label();
            label11 = new Label();
            label23 = new Label();
            BackButton = new Button();
            EditSupplierLabel = new Label();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(31, 232);
            label13.Name = "label13";
            label13.Size = new Size(65, 21);
            label13.TabIndex = 243;
            label13.Text = "Website";
            // 
            // WebsiteTextBox
            // 
            WebsiteTextBox.Location = new Point(33, 255);
            WebsiteTextBox.Multiline = true;
            WebsiteTextBox.Name = "WebsiteTextBox";
            WebsiteTextBox.Size = new Size(190, 23);
            WebsiteTextBox.TabIndex = 242;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(33, 156);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(190, 23);
            NameTextBox.TabIndex = 241;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(289, 107);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 240;
            label4.Text = "Endereços";
            // 
            // Addresses
            // 
            Addresses.Location = new Point(289, 132);
            Addresses.Name = "Addresses";
            Addresses.Size = new Size(470, 315);
            Addresses.TabIndex = 239;
            // 
            // CnpjTextBox
            // 
            CnpjTextBox.Location = new Point(33, 206);
            CnpjTextBox.Multiline = true;
            CnpjTextBox.Name = "CnpjTextBox";
            CnpjTextBox.Size = new Size(190, 23);
            CnpjTextBox.TabIndex = 238;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(31, 182);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 237;
            label3.Text = "CNPJ";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(33, 375);
            Email.Name = "Email";
            Email.Size = new Size(54, 21);
            Email.TabIndex = 236;
            Email.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(33, 399);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(190, 23);
            EmailTextBox.TabIndex = 235;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(33, 349);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(190, 23);
            PhoneTextBox.TabIndex = 234;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 12F);
            Phone.Location = new Point(33, 325);
            Phone.Name = "Phone";
            Phone.Size = new Size(67, 21);
            Phone.TabIndex = 233;
            Phone.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(31, 300);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 232;
            label1.Text = "Informações de contato";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(31, 107);
            label11.Name = "label11";
            label11.Size = new Size(190, 25);
            label11.TabIndex = 231;
            label11.Text = "Informações básicas";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(33, 132);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 230;
            label23.Text = "Nome";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(582, 463);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 229;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // EditSupplierLabel
            // 
            EditSupplierLabel.AutoSize = true;
            EditSupplierLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditSupplierLabel.Location = new Point(31, 29);
            EditSupplierLabel.Name = "EditSupplierLabel";
            EditSupplierLabel.Size = new Size(319, 37);
            EditSupplierLabel.TabIndex = 228;
            EditSupplierLabel.Text = "Detalhes do fornecedor";
            // 
            // SupplierDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(WebsiteTextBox);
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
            Controls.Add(label23);
            Controls.Add(BackButton);
            Controls.Add(EditSupplierLabel);
            Name = "SupplierDetailsControl";
            Size = new Size(954, 519);
            Load += SupplierDetailsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private TextBox WebsiteTextBox;
        private TextBox NameTextBox;
        private Label label4;
        private FlowLayoutPanel Addresses;
        private TextBox CnpjTextBox;
        private Label label3;
        private Label Email;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Label Phone;
        private Label label1;
        private Label label11;
        private Label label23;
        private Button BackButton;
        private Label EditSupplierLabel;
    }
}
