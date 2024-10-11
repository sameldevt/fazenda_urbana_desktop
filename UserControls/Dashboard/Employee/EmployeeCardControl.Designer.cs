namespace fazenda_verdeviva.UserControls.Dashboard.Employee
{
    partial class EmployeeCardControl
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
            ManufacturerWebsite = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            ManufacturerDescription = new Label();
            EmployeeName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(ManufacturerWebsite);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(ManufacturerDescription);
            ContentPanel.Controls.Add(EmployeeName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(934, 134);
            ContentPanel.TabIndex = 1;
            // 
            // ManufacturerWebsite
            // 
            ManufacturerWebsite.AutoSize = true;
            ManufacturerWebsite.Font = new Font("Segoe UI", 14F);
            ManufacturerWebsite.ForeColor = Color.DarkGray;
            ManufacturerWebsite.Location = new Point(0, 37);
            ManufacturerWebsite.Name = "ManufacturerWebsite";
            ManufacturerWebsite.Size = new Size(290, 25);
            ManufacturerWebsite.TabIndex = 7;
            ManufacturerWebsite.Text = "www.fazendadealimentos.com.br";
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
            // ManufacturerDescription
            // 
            ManufacturerDescription.AutoSize = true;
            ManufacturerDescription.Font = new Font("Segoe UI", 14F);
            ManufacturerDescription.ForeColor = Color.DarkGray;
            ManufacturerDescription.Location = new Point(0, 62);
            ManufacturerDescription.Name = "ManufacturerDescription";
            ManufacturerDescription.Size = new Size(769, 25);
            ManufacturerDescription.TabIndex = 3;
            ManufacturerDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSize = true;
            EmployeeName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EmployeeName.Location = new Point(0, 0);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.Size = new Size(135, 37);
            EmployeeName.TabIndex = 2;
            EmployeeName.Text = "Demonio";
            // 
            // EmployeeCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "EmployeeCardControl";
            Size = new Size(940, 140);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ManufacturerWebsite;
        private Button EditButton;
        private Button DeleteButton;
        private Label ManufacturerDescription;
        private Label EmployeeName;
    }
}
