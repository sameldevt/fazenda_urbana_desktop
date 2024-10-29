namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    partial class EditClientControl
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
            NameTextBox = new TextBox();
            Email = new Label();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            Phone = new Label();
            label1 = new Label();
            label11 = new Label();
            label23 = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            EditSupplierLabel = new Label();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(32, 151);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(190, 23);
            NameTextBox.TabIndex = 242;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(32, 264);
            Email.Name = "Email";
            Email.Size = new Size(54, 21);
            Email.TabIndex = 237;
            Email.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(32, 288);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(190, 23);
            EmailTextBox.TabIndex = 236;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(32, 238);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(190, 23);
            PhoneTextBox.TabIndex = 235;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 12F);
            Phone.Location = new Point(32, 214);
            Phone.Name = "Phone";
            Phone.Size = new Size(67, 21);
            Phone.TabIndex = 234;
            Phone.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(30, 189);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 233;
            label1.Text = "Informações de contato";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(30, 102);
            label11.Name = "label11";
            label11.Size = new Size(190, 25);
            label11.TabIndex = 232;
            label11.Text = "Informações básicas";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(32, 127);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 231;
            label23.Text = "Nome";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(756, 458);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 229;
            SaveButton.Text = "Salvar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(581, 458);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 230;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EditSupplierLabel
            // 
            EditSupplierLabel.AutoSize = true;
            EditSupplierLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditSupplierLabel.Location = new Point(30, 24);
            EditSupplierLabel.Name = "EditSupplierLabel";
            EditSupplierLabel.Size = new Size(186, 37);
            EditSupplierLabel.TabIndex = 228;
            EditSupplierLabel.Text = "Editar cliente";
            // 
            // EditClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NameTextBox);
            Controls.Add(Email);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(Phone);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label23);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(EditSupplierLabel);
            Name = "EditClientControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTextBox;
        private Label Email;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Label Phone;
        private Label label1;
        private Label label11;
        private Label label23;
        private Button SaveButton;
        private Button BackButton;
        private Label EditSupplierLabel;
    }
}
