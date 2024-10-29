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
            MessageDate = new Label();
            UserEmail = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            UserName = new Label();
            MessageContent = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(MessageDate);
            ContentPanel.Controls.Add(UserEmail);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(UserName);
            ContentPanel.Controls.Add(MessageContent);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(948, 104);
            ContentPanel.TabIndex = 1;
            // 
            // MessageDate
            // 
            MessageDate.AutoSize = true;
            MessageDate.Font = new Font("Segoe UI", 10F);
            MessageDate.ForeColor = Color.DarkGray;
            MessageDate.Location = new Point(818, 79);
            MessageDate.Name = "MessageDate";
            MessageDate.Size = new Size(115, 19);
            MessageDate.TabIndex = 8;
            MessageDate.Text = "email@email.com";
            // 
            // UserEmail
            // 
            UserEmail.AutoSize = true;
            UserEmail.Font = new Font("Segoe UI", 10F);
            UserEmail.ForeColor = Color.DarkGray;
            UserEmail.Location = new Point(4, 79);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(115, 19);
            UserEmail.TabIndex = 7;
            UserEmail.Text = "email@email.com";
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
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 14F);
            UserName.ForeColor = Color.DarkGray;
            UserName.Location = new Point(5, 54);
            UserName.Name = "UserName";
            UserName.Size = new Size(769, 25);
            UserName.TabIndex = 3;
            UserName.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // MessageContent
            // 
            MessageContent.AutoSize = true;
            MessageContent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MessageContent.Location = new Point(5, 11);
            MessageContent.Name = "MessageContent";
            MessageContent.Size = new Size(95, 21);
            MessageContent.TabIndex = 2;
            MessageContent.Text = "# 12312312";
            // 
            // ContactMessageCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ContactMessageCardControl";
            Size = new Size(954, 111);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label UserEmail;
        private Button EditButton;
        private Button DeleteButton;
        private Label UserName;
        private Label MessageContent;
        private Label MessageDate;
    }
}
