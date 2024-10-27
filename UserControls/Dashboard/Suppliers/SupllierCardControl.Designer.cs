namespace fazenda_verdeviva.UserControls.Dashboard.Suppliers
{
    partial class SupllierCardControl
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
            SupplierWebsite = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            SupllierCnoj = new Label();
            SupplierName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(SupplierWebsite);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(SupllierCnoj);
            ContentPanel.Controls.Add(SupplierName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 104);
            ContentPanel.TabIndex = 0;
            // 
            // SupplierWebsite
            // 
            SupplierWebsite.AutoSize = true;
            SupplierWebsite.Font = new Font("Segoe UI", 14F);
            SupplierWebsite.ForeColor = Color.DarkGray;
            SupplierWebsite.Location = new Point(0, 37);
            SupplierWebsite.Name = "SupplierWebsite";
            SupplierWebsite.Size = new Size(290, 25);
            SupplierWebsite.TabIndex = 7;
            SupplierWebsite.Text = "www.fazendadealimentos.com.br";
            // 
            // EditButton
            // 
            EditButton.Location = new Point(858, 14);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 6;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(777, 14);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SupllierCnoj
            // 
            SupllierCnoj.AutoSize = true;
            SupllierCnoj.Font = new Font("Segoe UI", 14F);
            SupllierCnoj.ForeColor = Color.DarkGray;
            SupllierCnoj.Location = new Point(0, 62);
            SupllierCnoj.Name = "SupllierCnoj";
            SupllierCnoj.Size = new Size(769, 25);
            SupllierCnoj.TabIndex = 3;
            SupllierCnoj.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SupplierName.Location = new Point(0, 0);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(368, 37);
            SupplierName.TabIndex = 2;
            SupplierName.Text = "Fazenda de alimentos LTDA";
            // 
            // SupllierCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "SupllierCardControl";
            Size = new Size(946, 111);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label SupplierName;
        private Label SupllierCnoj;
        private Button DeleteButton;
        private Label SupplierWebsite;
        private Button EditButton;
    }
}
