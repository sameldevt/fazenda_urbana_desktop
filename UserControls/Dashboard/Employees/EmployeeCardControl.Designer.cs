namespace fazenda_verdeviva.UserControls.Dashboard.Employees
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
            EmployeeEmail = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            EmployeeName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EmployeeEmail);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(EmployeeName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(948, 134);
            ContentPanel.TabIndex = 1;
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.AutoSize = true;
            EmployeeEmail.Font = new Font("Segoe UI", 14F);
            EmployeeEmail.ForeColor = Color.DarkGray;
            EmployeeEmail.Location = new Point(0, 37);
            EmployeeEmail.Name = "EmployeeEmail";
            EmployeeEmail.Size = new Size(218, 25);
            EmployeeEmail.TabIndex = 7;
            EmployeeEmail.Text = "email@verdeviva.com.br";
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
            Size = new Size(954, 140);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label EmployeeEmail;
        private Button EditButton;
        private Button DeleteButton;
        private Label EmployeeName;
    }
}
