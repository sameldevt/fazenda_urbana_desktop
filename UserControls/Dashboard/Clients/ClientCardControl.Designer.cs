namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    partial class ClientCardControl
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
            ClientEmail = new Label();
            DetailsButton = new Button();
            DeleteButton = new Button();
            ClientMemberSinceDate = new Label();
            ClientName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(ClientEmail);
            ContentPanel.Controls.Add(DetailsButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(ClientMemberSinceDate);
            ContentPanel.Controls.Add(ClientName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(948, 144);
            ContentPanel.TabIndex = 1;
            // 
            // ClientEmail
            // 
            ClientEmail.AutoSize = true;
            ClientEmail.Font = new Font("Segoe UI", 14F);
            ClientEmail.ForeColor = Color.DarkGray;
            ClientEmail.Location = new Point(3, 40);
            ClientEmail.Name = "ClientEmail";
            ClientEmail.Size = new Size(162, 25);
            ClientEmail.TabIndex = 11;
            ClientEmail.Text = "email@email.com";
            // 
            // DetailsButton
            // 
            DetailsButton.BackColor = Color.White;
            DetailsButton.Location = new Point(826, 12);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(95, 33);
            DetailsButton.TabIndex = 10;
            DetailsButton.Text = "Ver detalhes";
            DetailsButton.UseVisualStyleBackColor = false;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(826, 51);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click_1;
            // 
            // ClientMemberSinceDate
            // 
            ClientMemberSinceDate.AutoSize = true;
            ClientMemberSinceDate.Font = new Font("Segoe UI", 14F);
            ClientMemberSinceDate.ForeColor = Color.DarkGray;
            ClientMemberSinceDate.Location = new Point(3, 65);
            ClientMemberSinceDate.Name = "ClientMemberSinceDate";
            ClientMemberSinceDate.Size = new Size(238, 25);
            ClientMemberSinceDate.TabIndex = 2;
            ClientMemberSinceDate.Text = "Membro desde 10/02/2202";
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ClientName.Location = new Point(3, 3);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(135, 37);
            ClientName.TabIndex = 1;
            ClientName.Text = "Demonio";
            // 
            // ClientCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ClientCardControl";
            Size = new Size(954, 150);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ClientMemberSinceDate;
        private Label ClientName;
        private Button DetailsButton;
        private Button DeleteButton;
        private Label ClientEmail;
    }
}
