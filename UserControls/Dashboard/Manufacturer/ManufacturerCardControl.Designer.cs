namespace fazenda_verdeviva.UserControls.Dashboard.Manufacturer
{
    partial class ManufacturerCardControl
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
            ManufacturerName = new Label();
            ManufacturerDescription = new Label();
            DeleteButton = new Button();
            EditButton = new Button();
            ManufacturerWebsite = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(ManufacturerWebsite);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(ManufacturerDescription);
            ContentPanel.Controls.Add(ManufacturerName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 104);
            ContentPanel.TabIndex = 0;
            // 
            // ManufacturerName
            // 
            ManufacturerName.AutoSize = true;
            ManufacturerName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ManufacturerName.Location = new Point(0, 0);
            ManufacturerName.Name = "ManufacturerName";
            ManufacturerName.Size = new Size(368, 37);
            ManufacturerName.TabIndex = 2;
            ManufacturerName.Text = "Fazenda de alimentos LTDA";
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
            // DeleteButton
            // 
            DeleteButton.Location = new Point(777, 14);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = true;
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
            // ManufacturerCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ManufacturerCardControl";
            Size = new Size(946, 111);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ManufacturerName;
        private Label ManufacturerDescription;
        private Button DeleteButton;
        private Label ManufacturerWebsite;
        private Button EditButton;
    }
}
