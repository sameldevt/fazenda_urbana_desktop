﻿namespace fazenda_verdeviva.UserControls
{
    partial class DashboardControl
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
            TopBar = new Panel();
            label3 = new Label();
            label1 = new Label();
            OperatorEmail = new Label();
            pictureBox1 = new PictureBox();
            CompanyLogo = new Label();
            NavPanel = new Panel();
            MessagesButton = new Button();
            ClientsButton = new Button();
            OrdersButton = new Button();
            ManufacturerButton = new Button();
            ProductsButton = new Button();
            EmployeesButton = new Button();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(231, 71);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(966, 626);
            ContentPanel.TabIndex = 0;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.White;
            TopBar.Controls.Add(label3);
            TopBar.Controls.Add(label1);
            TopBar.Controls.Add(OperatorEmail);
            TopBar.Controls.Add(pictureBox1);
            TopBar.Controls.Add(CompanyLogo);
            TopBar.Location = new Point(3, 3);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1194, 62);
            TopBar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(966, 15);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 5;
            label3.Text = "Autenticado como";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 36);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "Fazenda urbana Verdeviva";
            // 
            // OperatorEmail
            // 
            OperatorEmail.AutoSize = true;
            OperatorEmail.Location = new Point(966, 33);
            OperatorEmail.Name = "OperatorEmail";
            OperatorEmail.Size = new Size(175, 15);
            OperatorEmail.TabIndex = 4;
            OperatorEmail.Text = "email-do-operador@email.com";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mini_logo;
            pictureBox1.Location = new Point(30, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // CompanyLogo
            // 
            CompanyLogo.AutoSize = true;
            CompanyLogo.Font = new Font("Segoe UI", 20F);
            CompanyLogo.Location = new Point(87, 3);
            CompanyLogo.Name = "CompanyLogo";
            CompanyLogo.Size = new Size(132, 37);
            CompanyLogo.TabIndex = 1;
            CompanyLogo.Text = "Verdeviva";
            // 
            // NavPanel
            // 
            NavPanel.Controls.Add(EmployeesButton);
            NavPanel.Controls.Add(MessagesButton);
            NavPanel.Controls.Add(ClientsButton);
            NavPanel.Controls.Add(OrdersButton);
            NavPanel.Controls.Add(ManufacturerButton);
            NavPanel.Controls.Add(ProductsButton);
            NavPanel.Location = new Point(3, 71);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(225, 626);
            NavPanel.TabIndex = 2;
            // 
            // MessagesButton
            // 
            MessagesButton.Location = new Point(3, 251);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(219, 44);
            MessagesButton.TabIndex = 4;
            MessagesButton.Text = "Mensagens de contato";
            MessagesButton.UseVisualStyleBackColor = true;
            MessagesButton.Click += MessagesButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.Location = new Point(3, 151);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(219, 44);
            ClientsButton.TabIndex = 3;
            ClientsButton.Text = "Clientes";
            ClientsButton.UseVisualStyleBackColor = true;
            ClientsButton.Click += ClientsButton_Click_1;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(3, 101);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(219, 44);
            OrdersButton.TabIndex = 2;
            OrdersButton.Text = "Pedidos";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click_1;
            // 
            // ManufacturerButton
            // 
            ManufacturerButton.Location = new Point(3, 53);
            ManufacturerButton.Name = "ManufacturerButton";
            ManufacturerButton.Size = new Size(219, 44);
            ManufacturerButton.TabIndex = 1;
            ManufacturerButton.Text = "Fornecedores";
            ManufacturerButton.UseVisualStyleBackColor = true;
            ManufacturerButton.Click += ManufacturerButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(3, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(219, 44);
            ProductsButton.TabIndex = 0;
            ProductsButton.Text = "Produtos";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(3, 201);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(219, 44);
            EmployeesButton.TabIndex = 5;
            EmployeesButton.Text = "Funcionarios";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NavPanel);
            Controls.Add(TopBar);
            Controls.Add(ContentPanel);
            Name = "DashboardControl";
            Size = new Size(1200, 700);
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Panel TopBar;
        private Panel NavPanel;
        private Label CompanyLogo;
        private PictureBox pictureBox1;
        private Button ClientsButton;
        private Button OrdersButton;
        private Button ManufacturerButton;
        private Button ProductsButton;
        private Button MessagesButton;
        private Label label1;
        private Label label3;
        private Label OperatorEmail;
        private Button EmployeesButton;
    }
}
