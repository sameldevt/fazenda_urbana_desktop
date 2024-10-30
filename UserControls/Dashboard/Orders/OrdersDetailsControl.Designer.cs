namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    partial class OrdersDetailsControl
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
            BackButton = new Button();
            Products = new FlowLayoutPanel();
            label2 = new Label();
            NameTextBox = new TextBox();
            Email = new Label();
            EmailTextBox = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label23 = new Label();
            EditSupplierLabel = new Label();
            label3 = new Label();
            OrderDateTextBox = new TextBox();
            label4 = new Label();
            OrderStatusTextBox = new TextBox();
            label5 = new Label();
            OrderTotalTextBox = new TextBox();
            label6 = new Label();
            OrderPaymentTextBox = new TextBox();
            label7 = new Label();
            OrderTotalItensTextBox = new TextBox();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(756, 458);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 283;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Products
            // 
            Products.Location = new Point(29, 277);
            Products.Name = "Products";
            Products.Size = new Size(896, 155);
            Products.TabIndex = 280;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(29, 249);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 282;
            label2.Text = "Produtos";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(30, 118);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(190, 23);
            NameTextBox.TabIndex = 278;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F);
            Email.Location = new Point(30, 144);
            Email.Name = "Email";
            Email.Size = new Size(54, 21);
            Email.TabIndex = 277;
            Email.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(30, 168);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.ReadOnly = true;
            EmailTextBox.Size = new Size(190, 23);
            EmailTextBox.TabIndex = 276;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(300, 69);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 273;
            label1.Text = "Informações do pedido";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(30, 69);
            label11.Name = "label11";
            label11.Size = new Size(215, 25);
            label11.TabIndex = 272;
            label11.Text = "Informações do cliente";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(29, 94);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 271;
            label23.Text = "Nome";
            // 
            // EditSupplierLabel
            // 
            EditSupplierLabel.AutoSize = true;
            EditSupplierLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EditSupplierLabel.Location = new Point(30, 24);
            EditSupplierLabel.Name = "EditSupplierLabel";
            EditSupplierLabel.Size = new Size(268, 37);
            EditSupplierLabel.TabIndex = 270;
            EditSupplierLabel.Text = "Detalhes do pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(300, 94);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 284;
            label3.Text = "Data do pedido";
            // 
            // OrderDateTextBox
            // 
            OrderDateTextBox.Location = new Point(300, 118);
            OrderDateTextBox.Multiline = true;
            OrderDateTextBox.Name = "OrderDateTextBox";
            OrderDateTextBox.ReadOnly = true;
            OrderDateTextBox.Size = new Size(190, 23);
            OrderDateTextBox.TabIndex = 285;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(300, 144);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 286;
            label4.Text = "Status do pedido";
            // 
            // OrderStatusTextBox
            // 
            OrderStatusTextBox.Location = new Point(300, 168);
            OrderStatusTextBox.Multiline = true;
            OrderStatusTextBox.Name = "OrderStatusTextBox";
            OrderStatusTextBox.ReadOnly = true;
            OrderStatusTextBox.Size = new Size(190, 23);
            OrderStatusTextBox.TabIndex = 287;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(300, 194);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 288;
            label5.Text = "Valor total";
            // 
            // OrderTotalTextBox
            // 
            OrderTotalTextBox.Location = new Point(300, 218);
            OrderTotalTextBox.Multiline = true;
            OrderTotalTextBox.Name = "OrderTotalTextBox";
            OrderTotalTextBox.ReadOnly = true;
            OrderTotalTextBox.Size = new Size(190, 23);
            OrderTotalTextBox.TabIndex = 289;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(521, 94);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 290;
            label6.Text = "Forma de pagamento";
            // 
            // OrderPaymentTextBox
            // 
            OrderPaymentTextBox.Location = new Point(521, 118);
            OrderPaymentTextBox.Multiline = true;
            OrderPaymentTextBox.Name = "OrderPaymentTextBox";
            OrderPaymentTextBox.ReadOnly = true;
            OrderPaymentTextBox.Size = new Size(190, 23);
            OrderPaymentTextBox.TabIndex = 291;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(521, 144);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 292;
            label7.Text = "Total de itens";
            // 
            // OrderTotalItensTextBox
            // 
            OrderTotalItensTextBox.Location = new Point(521, 168);
            OrderTotalItensTextBox.Multiline = true;
            OrderTotalItensTextBox.Name = "OrderTotalItensTextBox";
            OrderTotalItensTextBox.ReadOnly = true;
            OrderTotalItensTextBox.Size = new Size(190, 23);
            OrderTotalItensTextBox.TabIndex = 293;
            // 
            // OrdersDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderTotalItensTextBox);
            Controls.Add(label7);
            Controls.Add(OrderPaymentTextBox);
            Controls.Add(label6);
            Controls.Add(OrderTotalTextBox);
            Controls.Add(label5);
            Controls.Add(OrderStatusTextBox);
            Controls.Add(label4);
            Controls.Add(OrderDateTextBox);
            Controls.Add(label3);
            Controls.Add(BackButton);
            Controls.Add(Products);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(Email);
            Controls.Add(EmailTextBox);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label23);
            Controls.Add(EditSupplierLabel);
            Name = "OrdersDetailsControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private FlowLayoutPanel Products;
        private Label label2;
        private TextBox NameTextBox;
        private Label Email;
        private TextBox EmailTextBox;
        private Label label1;
        private Label label11;
        private Label label23;
        private Label EditSupplierLabel;
        private Label label3;
        private TextBox OrderDateTextBox;
        private Label label4;
        private TextBox OrderStatusTextBox;
        private Label label5;
        private TextBox OrderTotalTextBox;
        private Label label6;
        private TextBox OrderPaymentTextBox;
        private Label label7;
        private TextBox OrderTotalItensTextBox;
    }
}
