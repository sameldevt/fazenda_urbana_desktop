﻿namespace fazenda_verdeviva.UserControls.Dashboard.Clients
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
            EditButton = new Button();
            DeleteButton = new Button();
            ClientMemberSinceDate = new Label();
            ClientName = new Label();
            ClientImage = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(ClientMemberSinceDate);
            ContentPanel.Controls.Add(ClientName);
            ContentPanel.Controls.Add(ClientImage);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 144);
            ContentPanel.TabIndex = 1;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(852, 14);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 5;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(771, 14);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ClientMemberSinceDate
            // 
            ClientMemberSinceDate.AutoSize = true;
            ClientMemberSinceDate.Font = new Font("Segoe UI", 14F);
            ClientMemberSinceDate.ForeColor = Color.DarkGray;
            ClientMemberSinceDate.Location = new Point(159, 40);
            ClientMemberSinceDate.Name = "ClientMemberSinceDate";
            ClientMemberSinceDate.Size = new Size(238, 25);
            ClientMemberSinceDate.TabIndex = 2;
            ClientMemberSinceDate.Text = "Membro desde 10/02/2202";
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ClientName.Location = new Point(159, 3);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(135, 37);
            ClientName.TabIndex = 1;
            ClientName.Text = "Demonio";
            // 
            // ClientImage
            // 
            ClientImage.Image = Properties.Resources.purchase;
            ClientImage.InitialImage = Properties.Resources.product_image;
            ClientImage.Location = new Point(3, 3);
            ClientImage.Name = "ClientImage";
            ClientImage.Size = new Size(150, 150);
            ClientImage.SizeMode = PictureBoxSizeMode.Zoom;
            ClientImage.TabIndex = 0;
            ClientImage.TabStop = false;
            // 
            // ClientCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ClientCardControl";
            Size = new Size(946, 150);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Button EditButton;
        private Button DeleteButton;
        private Label ClientMemberSinceDate;
        private Label ClientName;
        private PictureBox ClientImage;
    }
}
