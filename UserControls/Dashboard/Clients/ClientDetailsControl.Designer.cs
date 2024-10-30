namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    partial class ClientDetailsControl
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
            label4 = new Label();
            Addresses = new FlowLayoutPanel();
            NameTextBox = new TextBox();
            Email = new Label();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            Phone = new Label();
            label1 = new Label();
            label11 = new Label();
            label23 = new Label();
            EditSupplierLabel = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(756, 458);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 269;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(320, 87);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 267;
            label4.Text = "Endereços";
            // 
            // Addresses
            // 
            Addresses.Location = new Point(320, 121);
            Addresses.Name = "Addresses";
            Addresses.Size = new Size(400, 249);
            Addresses.TabIndex = 265;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(30, 136);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(190, 23);
            NameTextBox.TabIndex = 264;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(30, 260);
            Email.Name = "Email";
            Email.Size = new Size(54, 21);
            Email.TabIndex = 263;
            Email.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(30, 284);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.ReadOnly = true;
            EmailTextBox.Size = new Size(190, 23);
            EmailTextBox.TabIndex = 262;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(30, 234);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.ReadOnly = true;
            PhoneTextBox.Size = new Size(190, 23);
            PhoneTextBox.TabIndex = 261;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 12F);
            Phone.Location = new Point(30, 210);
            Phone.Name = "Phone";
            Phone.Size = new Size(67, 21);
            Phone.TabIndex = 260;
            Phone.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(30, 185);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 259;
            label1.Text = "Informações de contato";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(30, 87);
            label11.Name = "label11";
            label11.Size = new Size(190, 25);
            label11.TabIndex = 258;
            label11.Text = "Informações básicas";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(30, 112);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 257;
            label23.Text = "Nome";
            // 
            // EditSupplierLabel
            // 
            EditSupplierLabel.AutoSize = true;
            EditSupplierLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditSupplierLabel.Location = new Point(30, 24);
            EditSupplierLabel.Name = "EditSupplierLabel";
            EditSupplierLabel.Size = new Size(263, 37);
            EditSupplierLabel.TabIndex = 256;
            EditSupplierLabel.Text = "Detalhes do cliente";
            // 
            // ClientDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackButton);
            Controls.Add(label4);
            Controls.Add(Addresses);
            Controls.Add(NameTextBox);
            Controls.Add(Email);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(Phone);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label23);
            Controls.Add(EditSupplierLabel);
            Name = "ClientDetailsControl";
            Size = new Size(954, 519);
            Load += ClientDetailsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label label4;
        private FlowLayoutPanel Addresses;
        private TextBox NameTextBox;
        private Label Email;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Label Phone;
        private Label label1;
        private Label label11;
        private Label label23;
        private Label EditSupplierLabel;
    }
}
