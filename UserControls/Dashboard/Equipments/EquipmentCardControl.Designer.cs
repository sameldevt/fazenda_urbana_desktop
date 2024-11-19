namespace fazenda_verdeviva.UserControls.Dashboard.Equipments
{
    partial class EquipmentCardControl
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
            EquipmentSupplier = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EquipmentType = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            EquipmentBrand = new Label();
            EquipmentDescription = new Label();
            EquipmentName = new Label();
            EquipmentImage = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EquipmentSupplier);
            ContentPanel.Controls.Add(label3);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(EquipmentType);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(EquipmentBrand);
            ContentPanel.Controls.Add(EquipmentDescription);
            ContentPanel.Controls.Add(EquipmentName);
            ContentPanel.Controls.Add(EquipmentImage);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 172);
            ContentPanel.TabIndex = 1;
            // 
            // EquipmentSupplier
            // 
            EquipmentSupplier.AutoSize = true;
            EquipmentSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentSupplier.ForeColor = Color.Green;
            EquipmentSupplier.Location = new Point(276, 108);
            EquipmentSupplier.Name = "EquipmentSupplier";
            EquipmentSupplier.Size = new Size(73, 21);
            EquipmentSupplier.TabIndex = 11;
            EquipmentSupplier.Text = "R$ 10,99";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(178, 107);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10;
            label3.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(178, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 9;
            label2.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(178, 86);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 8;
            label1.Text = "Marca:";
            // 
            // EquipmentType
            // 
            EquipmentType.AutoSize = true;
            EquipmentType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentType.ForeColor = Color.Green;
            EquipmentType.Location = new Point(276, 66);
            EquipmentType.Name = "EquipmentType";
            EquipmentType.Size = new Size(69, 21);
            EquipmentType.TabIndex = 6;
            EquipmentType.Text = "1000 kg";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(824, 46);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(95, 35);
            EditButton.TabIndex = 5;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(824, 7);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EquipmentBrand
            // 
            EquipmentBrand.AutoSize = true;
            EquipmentBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentBrand.ForeColor = Color.Green;
            EquipmentBrand.Location = new Point(276, 87);
            EquipmentBrand.Name = "EquipmentBrand";
            EquipmentBrand.Size = new Size(73, 21);
            EquipmentBrand.TabIndex = 3;
            EquipmentBrand.Text = "R$ 10,99";
            // 
            // EquipmentDescription
            // 
            EquipmentDescription.AllowDrop = true;
            EquipmentDescription.AutoEllipsis = true;
            EquipmentDescription.AutoSize = true;
            EquipmentDescription.Font = new Font("Segoe UI", 14F);
            EquipmentDescription.ForeColor = Color.DarkGray;
            EquipmentDescription.Location = new Point(178, 40);
            EquipmentDescription.Name = "EquipmentDescription";
            EquipmentDescription.Size = new Size(661, 25);
            EquipmentDescription.TabIndex = 2;
            EquipmentDescription.Text = "Banana fresca e madura, rica em potássio e fibras, ideal para consumo diário.";
            // 
            // EquipmentName
            // 
            EquipmentName.AutoSize = true;
            EquipmentName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EquipmentName.Location = new Point(178, 7);
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Size = new Size(111, 37);
            EquipmentName.TabIndex = 1;
            EquipmentName.Text = "Banana";
            // 
            // EquipmentImage
            // 
            EquipmentImage.InitialImage = null;
            EquipmentImage.Location = new Point(3, 3);
            EquipmentImage.Name = "EquipmentImage";
            EquipmentImage.Size = new Size(169, 166);
            EquipmentImage.SizeMode = PictureBoxSizeMode.Zoom;
            EquipmentImage.TabIndex = 0;
            EquipmentImage.TabStop = false;
            // 
            // EquipmentCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "EquipmentCardControl";
            Size = new Size(928, 178);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EquipmentImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label label2;
        private Label label1;
        private Label EquipmentType;
        private Button EditButton;
        private Button DeleteButton;
        private Label EquipmentBrand;
        private Label EquipmentDescription;
        private Label EquipmentName;
        private PictureBox EquipmentImage;
        private Label label3;
        private Label EquipmentSupplier;
    }
}
