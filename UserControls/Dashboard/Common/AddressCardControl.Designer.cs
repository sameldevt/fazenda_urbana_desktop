namespace fazenda_verdeviva.UserControls.Dashboard.Common
{
    partial class AddressCardControl
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
            label23 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Street = new Label();
            Number = new Label();
            City = new Label();
            PostalCode = new Label();
            Complement = new Label();
            State = new Label();
            SuspendLayout();
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(13, 12);
            label23.Name = "label23";
            label23.Size = new Size(95, 21);
            label23.TabIndex = 151;
            label23.Text = "Logradouro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 152;
            label1.Text = "Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 153;
            label2.Text = "Cidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 75);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 154;
            label3.Text = "CEP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 96);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 155;
            label4.Text = "Complemento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(13, 117);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 156;
            label5.Text = "Estado:";
            // 
            // Street
            // 
            Street.AutoSize = true;
            Street.Font = new Font("Segoe UI", 12F);
            Street.ForeColor = Color.Green;
            Street.Location = new Point(135, 12);
            Street.Name = "Street";
            Street.Size = new Size(49, 21);
            Street.TabIndex = 157;
            Street.Text = "street";
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Font = new Font("Segoe UI", 12F);
            Number.ForeColor = Color.Green;
            Number.Location = new Point(135, 33);
            Number.Name = "Number";
            Number.Size = new Size(65, 21);
            Number.TabIndex = 158;
            Number.Text = "number";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Font = new Font("Segoe UI", 12F);
            City.ForeColor = Color.Green;
            City.Location = new Point(135, 54);
            City.Name = "City";
            City.Size = new Size(34, 21);
            City.TabIndex = 159;
            City.Text = "city";
            // 
            // PostalCode
            // 
            PostalCode.AutoSize = true;
            PostalCode.Font = new Font("Segoe UI", 12F);
            PostalCode.ForeColor = Color.Green;
            PostalCode.Location = new Point(135, 75);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(85, 21);
            PostalCode.TabIndex = 160;
            PostalCode.Text = "postalcode";
            // 
            // Complement
            // 
            Complement.AutoSize = true;
            Complement.Font = new Font("Segoe UI", 12F);
            Complement.ForeColor = Color.Green;
            Complement.Location = new Point(135, 96);
            Complement.Name = "Complement";
            Complement.Size = new Size(97, 21);
            Complement.TabIndex = 161;
            Complement.Text = "complement";
            // 
            // State
            // 
            State.AutoSize = true;
            State.Font = new Font("Segoe UI", 12F);
            State.ForeColor = Color.Green;
            State.Location = new Point(135, 117);
            State.Name = "State";
            State.Size = new Size(43, 21);
            State.TabIndex = 162;
            State.Text = "state";
            // 
            // AddressCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(State);
            Controls.Add(Complement);
            Controls.Add(PostalCode);
            Controls.Add(City);
            Controls.Add(Number);
            Controls.Add(Street);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label23);
            Name = "AddressCardControl";
            Size = new Size(450, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label23;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public Label Street;
        public Label Number;
        public Label City;
        public Label PostalCode;
        public Label Complement;
        public Label State;
    }
}
