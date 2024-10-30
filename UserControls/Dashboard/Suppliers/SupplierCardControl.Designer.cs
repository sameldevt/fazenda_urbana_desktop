namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    partial class SupplierCardControl
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
            ContentPanel = new Panel();
            EditButton = new Button();
            DeleteButton = new Button();
            Details = new Button();
            SupplierWebsite = new Label();
            SupllierCnpj = new Label();
            SupplierName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(Details);
            ContentPanel.Controls.Add(SupplierWebsite);
            ContentPanel.Controls.Add(SupllierCnpj);
            ContentPanel.Controls.Add(SupplierName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(948, 144);
            ContentPanel.TabIndex = 0;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(826, 90);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(95, 35);
            EditButton.TabIndex = 12;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(826, 51);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Details
            // 
            Details.BackColor = Color.White;
            Details.Location = new Point(826, 12);
            Details.Name = "Details";
            Details.Size = new Size(95, 33);
            Details.TabIndex = 8;
            Details.Text = "Ver detalhes";
            Details.UseVisualStyleBackColor = false;
            Details.Click += Details_Click;
            // 
            // SupplierWebsite
            // 
            SupplierWebsite.AutoSize = true;
            SupplierWebsite.Font = new Font("Segoe UI", 14F);
            SupplierWebsite.ForeColor = Color.DarkGray;
            SupplierWebsite.Location = new Point(3, 40);
            SupplierWebsite.Name = "SupplierWebsite";
            SupplierWebsite.Size = new Size(290, 25);
            SupplierWebsite.TabIndex = 7;
            SupplierWebsite.Text = "www.fazendadealimentos.com.br";
            // 
            // SupllierCnpj
            // 
            SupllierCnpj.AutoSize = true;
            SupllierCnpj.Font = new Font("Segoe UI", 14F);
            SupllierCnpj.ForeColor = Color.DarkGray;
            SupllierCnpj.Location = new Point(3, 65);
            SupllierCnpj.Name = "SupllierCnpj";
            SupllierCnpj.Size = new Size(769, 25);
            SupllierCnpj.TabIndex = 3;
            SupllierCnpj.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SupplierName.Location = new Point(3, 3);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(368, 37);
            SupplierName.TabIndex = 2;
            SupplierName.Text = "Fazenda de alimentos LTDA";
            // 
            // SupplierCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "SupplierCardControl";
            Size = new Size(954, 150);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label SupplierName;
        private Label SupllierCnpj;
        private Label SupplierWebsite;
        private Button Details;
        private Button DeleteButton;
        private Button EditButton;
    }
}
