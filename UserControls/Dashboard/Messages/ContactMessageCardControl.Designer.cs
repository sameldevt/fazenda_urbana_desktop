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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UserName = new Label();
            MessageDate = new Label();
            UserEmail = new Label();
            Content = new Label();
            MessageId = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(label3);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(UserName);
            ContentPanel.Controls.Add(MessageDate);
            ContentPanel.Controls.Add(UserEmail);
            ContentPanel.Controls.Add(Content);
            ContentPanel.Controls.Add(MessageId);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(948, 124);
            ContentPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(5, 92);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 12;
            label3.Text = "Data do envio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(5, 52);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 10;
            label1.Text = "Usuário:";
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Microsoft Sans Serif", 12F);
            UserName.ForeColor = Color.Green;
            UserName.Location = new Point(122, 52);
            UserName.Name = "UserName";
            UserName.Size = new Size(133, 20);
            UserName.TabIndex = 9;
            UserName.Text = "email@email.com";
            // 
            // MessageDate
            // 
            MessageDate.AutoSize = true;
            MessageDate.Font = new Font("Microsoft Sans Serif", 12F);
            MessageDate.ForeColor = Color.Green;
            MessageDate.Location = new Point(122, 92);
            MessageDate.Name = "MessageDate";
            MessageDate.Size = new Size(133, 20);
            MessageDate.TabIndex = 8;
            MessageDate.Text = "email@email.com";
            // 
            // UserEmail
            // 
            UserEmail.AutoSize = true;
            UserEmail.Font = new Font("Microsoft Sans Serif", 12F);
            UserEmail.ForeColor = Color.Green;
            UserEmail.Location = new Point(122, 72);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(133, 20);
            UserEmail.TabIndex = 7;
            UserEmail.Text = "email@email.com";
            // 
            // Content
            // 
            Content.AutoSize = true;
            Content.Font = new Font("Microsoft Sans Serif", 12F);
            Content.ForeColor = Color.Green;
            Content.Location = new Point(5, 32);
            Content.Name = "Content";
            Content.Size = new Size(634, 20);
            Content.TabIndex = 3;
            Content.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            Content.Click += UserName_Click;
            // 
            // MessageId
            // 
            MessageId.AutoSize = true;
            MessageId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessageId.Location = new Point(5, 7);
            MessageId.Name = "MessageId";
            MessageId.Size = new Size(116, 25);
            MessageId.TabIndex = 2;
            MessageId.Text = "# 12312312";
            // 
            // ContactMessageCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ContactMessageCardControl";
            Size = new Size(954, 130);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label UserEmail;
        private Label Content;
        private Label MessageId;
        private Label MessageDate;
        private Label UserName;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
