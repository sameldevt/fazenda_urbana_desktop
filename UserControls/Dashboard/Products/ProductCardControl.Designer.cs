namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductCardControl
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
            label1 = new Label();
            ProductDescription = new Label();
            ProductName = new Label();
            ProductImage = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(ProductDescription);
            ContentPanel.Controls.Add(ProductName);
            ContentPanel.Controls.Add(ProductImage);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(940, 144);
            ContentPanel.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(781, 96);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 3;
            label1.Text = "R$ 10,99 / kg";
            // 
            // ProductDescription
            // 
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
            ProductImage.Image = Properties.Resources.product_image;
            ProductImage.InitialImage = Properties.Resources.product_image;
            ProductImage.Location = new Point(3, 3);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(150, 150);
            ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            // 
            // ProductCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "ProductCardControl";
            Size = new Size(946, 150);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label ProductName;
        private PictureBox ProductImage;
        private Label label2;
        private Label label1;
        private Label ProductDescription;
        private Button EditButton;
        private Button DeleteButton;
    }
}
