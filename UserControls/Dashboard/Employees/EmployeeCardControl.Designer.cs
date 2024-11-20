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
            RegistrationNumberLabel = new Label();
            label2 = new Label();
            PositionLabel = new Label();
            label1 = new Label();
            EmployeeEmail = new Label();
            DeleteButton = new Button();
            EmployeeName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(RegistrationNumberLabel);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(PositionLabel);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(EmployeeEmail);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(EmployeeName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 134);
            ContentPanel.TabIndex = 1;
            // 
            // RegistrationNumberLabel
            // 
            RegistrationNumberLabel.AutoSize = true;
            RegistrationNumberLabel.Font = new Font("Segoe UI", 14F);
            RegistrationNumberLabel.ForeColor = Color.Green;
            RegistrationNumberLabel.Location = new Point(214, 87);
            RegistrationNumberLabel.Name = "RegistrationNumberLabel";
            RegistrationNumberLabel.Size = new Size(82, 25);
            RegistrationNumberLabel.TabIndex = 11;
            RegistrationNumberLabel.Text = "1231312";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 10;
            label2.Text = "Número de registro:";
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Font = new Font("Segoe UI", 14F);
            PositionLabel.ForeColor = Color.Green;
            PositionLabel.Location = new Point(76, 37);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(60, 25);
            PositionLabel.TabIndex = 9;
            PositionLabel.Text = "cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 8;
            label1.Text = "Cargo:";
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.AutoSize = true;
            EmployeeEmail.Font = new Font("Segoe UI", 14F);
            EmployeeEmail.ForeColor = Color.Green;
            EmployeeEmail.Location = new Point(3, 62);
            EmployeeEmail.Name = "EmployeeEmail";
            EmployeeEmail.Size = new Size(218, 25);
            EmployeeEmail.TabIndex = 7;
            EmployeeEmail.Text = "email@verdeviva.com.br";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(835, 8);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 35);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
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
            Size = new Size(928, 140);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label EmployeeEmail;
        private Button DeleteButton;
        private Label EmployeeName;
        private Label PositionLabel;
        private Label label1;
        private Label label2;
        private Label RegistrationNumberLabel;
    }
}
