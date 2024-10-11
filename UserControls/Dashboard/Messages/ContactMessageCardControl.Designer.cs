namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    partial class ContactMessageCardControl
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
            ContactEmail = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            MessageContent = new Label();
            MessageCode = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(ContactEmail);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(MessageContent);
            ContentPanel.Controls.Add(MessageCode);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 104);
            ContentPanel.TabIndex = 1;
            // 
            // ContactEmail
            // 
            ContactEmail.AutoSize = true;
            ContactEmail.Font = new Font("Segoe UI", 14F);
            ContactEmail.ForeColor = Color.DarkGray;
            ContactEmail.Location = new Point(0, 37);
            ContactEmail.Name = "ContactEmail";
            ContactEmail.Size = new Size(162, 25);
            ContactEmail.TabIndex = 7;
            ContactEmail.Text = "email@email.com";
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
            // MessageContent
            // 
            MessageContent.AutoSize = true;
            MessageContent.Font = new Font("Segoe UI", 14F);
            MessageContent.ForeColor = Color.DarkGray;
            MessageContent.Location = new Point(0, 62);
            MessageContent.Name = "MessageContent";
            MessageContent.Size = new Size(769, 25);
            MessageContent.TabIndex = 3;
            MessageContent.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // MessageCode
            // 
            MessageCode.AutoSize = true;
            MessageCode.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            MessageCode.Location = new Point(0, 0);
            MessageCode.Name = "MessageCode";
            MessageCode.Size = new Size(168, 37);
            MessageCode.TabIndex = 2;
            MessageCode.Text = "# 12312312";
            // 
            // ContactMessageCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ContactMessageCardControl";
            Size = new Size(946, 111);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ContactEmail;
        private Button EditButton;
        private Button DeleteButton;
        private Label MessageContent;
        private Label MessageCode;
    }
}
