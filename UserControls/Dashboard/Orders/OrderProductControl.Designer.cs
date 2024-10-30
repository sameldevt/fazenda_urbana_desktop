namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    partial class OrderProductControl
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
            label2 = new Label();
            label1 = new Label();
            ProductQuantity = new Label();
            ProductPrice = new Label();
            ProductDescription = new Label();
            ProductName = new Label();
            ProductImage = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(ProductQuantity);
            ContentPanel.Controls.Add(ProductPrice);
            ContentPanel.Controls.Add(ProductDescription);
            ContentPanel.Controls.Add(ProductName);
            ContentPanel.Controls.Add(ProductImage);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(825, 144);
            ContentPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(159, 65);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 9;
            label2.Text = "Quantidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(159, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 8;
            label1.Text = "Valor:";
            // 
            // ProductQuantity
            // 
            ProductQuantity.AutoSize = true;
            ProductQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductQuantity.ForeColor = Color.Green;
            ProductQuantity.Location = new Point(259, 65);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(69, 21);
            ProductQuantity.TabIndex = 6;
            ProductQuantity.Text = "1000 kg";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.ForeColor = Color.Green;
            ProductPrice.Location = new Point(214, 86);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(73, 21);
            ProductPrice.TabIndex = 3;
            ProductPrice.Text = "R$ 10,99";
            // 
            // ProductDescription
            // 
            ProductDescription.AllowDrop = true;
            ProductDescription.AutoEllipsis = true;
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Segoe UI", 14F);
            ProductDescription.ForeColor = Color.DarkGray;
            ProductDescription.Location = new Point(159, 40);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(661, 25);
            ProductDescription.TabIndex = 2;
            ProductDescription.Text = "Banana fresca e madura, rica em potássio e fibras, ideal para consumo diário.";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ProductName.Location = new Point(159, 3);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(111, 37);
            ProductName.TabIndex = 1;
            ProductName.Text = "Banana";
            // 
            // ProductImage
            // 
            ProductImage.InitialImage = null;
            ProductImage.Location = new Point(3, 3);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(150, 150);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            // 
            // OrderProductControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "OrderProductControl";
            Size = new Size(831, 150);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label label2;
        private Label label1;
        private Label ProductQuantity;
        private Label ProductPrice;
        private Label ProductDescription;
        private Label ProductName;
        private PictureBox ProductImage;
    }
}
