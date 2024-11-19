namespace fazenda_verdeviva.UserControls.Dashboard.Supplies
{
    partial class SupplyCardControl
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
            UnitPrice = new Label();
            label4 = new Label();
            SupplySupplier = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SupplyDetails = new Button();
            SupplyCategory = new Label();
            DeleteButton = new Button();
            StockQuantity = new Label();
            SupplyDescription = new Label();
            SupplyName = new Label();
            SupplyImage = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplyImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(UnitPrice);
            ContentPanel.Controls.Add(label4);
            ContentPanel.Controls.Add(SupplySupplier);
            ContentPanel.Controls.Add(label3);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(SupplyDetails);
            ContentPanel.Controls.Add(SupplyCategory);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(StockQuantity);
            ContentPanel.Controls.Add(SupplyDescription);
            ContentPanel.Controls.Add(SupplyName);
            ContentPanel.Controls.Add(SupplyImage);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 172);
            ContentPanel.TabIndex = 2;
            // 
            // UnitPrice
            // 
            UnitPrice.AutoSize = true;
            UnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnitPrice.ForeColor = Color.Green;
            UnitPrice.Location = new Point(372, 113);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(73, 21);
            UnitPrice.TabIndex = 13;
            UnitPrice.Text = "R$ 10,99";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(178, 113);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 12;
            label4.Text = "Preço unitário:";
            // 
            // SupplySupplier
            // 
            SupplySupplier.AutoSize = true;
            SupplySupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplySupplier.ForeColor = Color.Green;
            SupplySupplier.Location = new Point(372, 134);
            SupplySupplier.Name = "SupplySupplier";
            SupplySupplier.Size = new Size(73, 21);
            SupplySupplier.TabIndex = 11;
            SupplySupplier.Text = "R$ 10,99";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(178, 134);
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
            label2.Location = new Point(178, 71);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 9;
            label2.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(178, 92);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 8;
            label1.Text = "Quantidade em estoque:";
            // 
            // SupplyDetails
            // 
            SupplyDetails.BackColor = Color.White;
            SupplyDetails.Location = new Point(824, 7);
            SupplyDetails.Name = "SupplyDetails";
            SupplyDetails.Size = new Size(95, 33);
            SupplyDetails.TabIndex = 7;
            SupplyDetails.Text = "Ver detalhes";
            SupplyDetails.UseVisualStyleBackColor = false;
            SupplyDetails.Click += SupplyDetails_Click;
            // 
            // SupplyCategory
            // 
            SupplyCategory.AutoSize = true;
            SupplyCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplyCategory.ForeColor = Color.Green;
            SupplyCategory.Location = new Point(372, 68);
            SupplyCategory.Name = "SupplyCategory";
            SupplyCategory.Size = new Size(69, 21);
            SupplyCategory.TabIndex = 6;
            SupplyCategory.Text = "1000 kg";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(824, 46);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // StockQuantity
            // 
            StockQuantity.AutoSize = true;
            StockQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockQuantity.ForeColor = Color.Green;
            StockQuantity.Location = new Point(372, 92);
            StockQuantity.Name = "StockQuantity";
            StockQuantity.Size = new Size(73, 21);
            StockQuantity.TabIndex = 3;
            StockQuantity.Text = "R$ 10,99";
            // 
            // SupplyDescription
            // 
            SupplyDescription.AllowDrop = true;
            SupplyDescription.AutoEllipsis = true;
            SupplyDescription.AutoSize = true;
            SupplyDescription.Font = new Font("Segoe UI", 14F);
            SupplyDescription.ForeColor = Color.DarkGray;
            SupplyDescription.Location = new Point(178, 43);
            SupplyDescription.Name = "SupplyDescription";
            SupplyDescription.Size = new Size(661, 25);
            SupplyDescription.TabIndex = 2;
            SupplyDescription.Text = "Banana fresca e madura, rica em potássio e fibras, ideal para consumo diário.";
            // 
            // SupplyName
            // 
            SupplyName.AutoSize = true;
            SupplyName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SupplyName.Location = new Point(178, 7);
            SupplyName.Name = "SupplyName";
            SupplyName.Size = new Size(111, 37);
            SupplyName.TabIndex = 1;
            SupplyName.Text = "Banana";
            // 
            // SupplyImage
            // 
            SupplyImage.InitialImage = null;
            SupplyImage.Location = new Point(3, 3);
            SupplyImage.Name = "SupplyImage";
            SupplyImage.Size = new Size(169, 166);
            SupplyImage.SizeMode = PictureBoxSizeMode.Zoom;
            SupplyImage.TabIndex = 0;
            SupplyImage.TabStop = false;
            // 
            // SupplyCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "SupplyCardControl";
            Size = new Size(928, 178);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SupplyImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label SupplySupplier;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button SupplyDetails;
        private Label SupplyCategory;
        private Button DeleteButton;
        private Label StockQuantity;
        private Label SupplyDescription;
        private Label SupplyName;
        private PictureBox SupplyImage;
        private Label UnitPrice;
        private Label label4;
    }
}
