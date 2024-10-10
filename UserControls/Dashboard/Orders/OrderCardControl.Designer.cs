namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    partial class OrderCardControl
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
            ManufacturerDescription = new Label();
            ManufacturerName = new Label();
            label1 = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(ManufacturerWebsite);
            ContentPanel.Controls.Add(ManufacturerDescription);
            ContentPanel.Controls.Add(ManufacturerName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 107);
            ContentPanel.TabIndex = 1;
            // 
            // ManufacturerWebsite
            // 
            ManufacturerWebsite.AutoSize = true;
            ManufacturerWebsite.Font = new Font("Segoe UI", 14F);
            ManufacturerWebsite.ForeColor = Color.DarkGray;
            ManufacturerWebsite.Location = new Point(3, 39);
            ManufacturerWebsite.Name = "ManufacturerWebsite";
            ManufacturerWebsite.Size = new Size(211, 25);
            ManufacturerWebsite.TabIndex = 7;
            ManufacturerWebsite.Text = "Quantidade de itens: 13";
            // 
            // ManufacturerDescription
            // 
            ManufacturerDescription.AutoSize = true;
            ManufacturerDescription.Font = new Font("Segoe UI", 14F);
            ManufacturerDescription.ForeColor = Color.DarkGray;
            ManufacturerDescription.Location = new Point(3, 64);
            ManufacturerDescription.Name = "ManufacturerDescription";
            ManufacturerDescription.Size = new Size(769, 25);
            ManufacturerDescription.TabIndex = 3;
            ManufacturerDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt";
            // 
            // ManufacturerName
            // 
            ManufacturerName.AutoSize = true;
            ManufacturerName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ManufacturerName.Location = new Point(3, 2);
            ManufacturerName.Name = "ManufacturerName";
            ManufacturerName.Size = new Size(168, 37);
            ManufacturerName.TabIndex = 2;
            ManufacturerName.Text = "# 21231122";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(833, 14);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 8;
            label1.Text = "R$ 49,99 ";
            // 
            // OrderCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "OrderCardControl";
            Size = new Size(946, 113);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ManufacturerWebsite;
        private Label ManufacturerDescription;
        private Label ManufacturerName;
        private Label label1;
    }
}
