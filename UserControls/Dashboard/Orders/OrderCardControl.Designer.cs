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
            label2 = new Label();
            label1 = new Label();
            Details = new Button();
            PaymentMethod = new Label();
            OrderPrice = new Label();
            OrderItemQuantity = new Label();
            OrderId = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(Details);
            ContentPanel.Controls.Add(PaymentMethod);
            ContentPanel.Controls.Add(OrderPrice);
            ContentPanel.Controls.Add(OrderItemQuantity);
            ContentPanel.Controls.Add(OrderId);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(904, 107);
            ContentPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 11;
            label2.Text = "Quantidade de itens: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 10;
            label1.Text = "Forma de pagamento:";
            // 
            // Details
            // 
            Details.BackColor = Color.White;
            Details.Location = new Point(792, 64);
            Details.Name = "Details";
            Details.Size = new Size(95, 33);
            Details.TabIndex = 9;
            Details.Text = "Ver detalhes";
            Details.UseVisualStyleBackColor = false;
            Details.Click += Details_Click;
            // 
            // PaymentMethod
            // 
            PaymentMethod.AutoSize = true;
            PaymentMethod.Font = new Font("Segoe UI", 14F);
            PaymentMethod.ForeColor = Color.Green;
            PaymentMethod.Location = new Point(222, 65);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(158, 25);
            PaymentMethod.TabIndex = 9;
            PaymentMethod.Text = "Cartão de crédito";
            // 
            // OrderPrice
            // 
            OrderPrice.Anchor = AnchorStyles.None;
            OrderPrice.AutoSize = true;
            OrderPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            OrderPrice.ForeColor = Color.Green;
            OrderPrice.Location = new Point(793, 12);
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Size = new Size(94, 25);
            OrderPrice.TabIndex = 8;
            OrderPrice.Text = "R$ 49,99 ";
            // 
            // OrderItemQuantity
            // 
            OrderItemQuantity.AutoSize = true;
            OrderItemQuantity.Font = new Font("Segoe UI", 14F);
            OrderItemQuantity.ForeColor = Color.Green;
            OrderItemQuantity.Location = new Point(222, 39);
            OrderItemQuantity.Name = "OrderItemQuantity";
            OrderItemQuantity.Size = new Size(32, 25);
            OrderItemQuantity.TabIndex = 7;
            OrderItemQuantity.Text = "13";
            OrderItemQuantity.TextAlign = ContentAlignment.TopCenter;
            // 
            // OrderId
            // 
            OrderId.AutoSize = true;
            OrderId.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            OrderId.Location = new Point(3, 2);
            OrderId.Name = "OrderId";
            OrderId.Size = new Size(168, 37);
            OrderId.TabIndex = 2;
            OrderId.Text = "# 21231122";
            // 
            // OrderCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "OrderCardControl";
            Size = new Size(910, 113);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label OrderItemQuantity;
        private Label ManufacturerDescription;
        private Label OrderId;
        private Label OrderPrice;
        private Label PaymentMethod;
        private Button Details;
        private Label label2;
        private Label label1;
    }
}
