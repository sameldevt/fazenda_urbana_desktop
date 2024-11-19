namespace fazenda_verdeviva.UserControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            ContentPanel = new Panel();
            TopBar = new Panel();
            label3 = new Label();
            OperatorEmail = new Label();
            pictureBox1 = new PictureBox();
            NavPanel = new Panel();
            SupplyButton = new Button();
            EquipmentButton = new Button();
            FarmButton = new Button();
            CultureButton = new Button();
            HarvestButton = new Button();
            MessagesButton = new Button();
            EmployeesButton = new Button();
            ClientsButton = new Button();
            OrdersButton = new Button();
            ManufacturerButton = new Button();
            ExitButton = new Button();
            ProductsButton = new Button();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(231, 71);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(960, 587);
            ContentPanel.TabIndex = 0;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.White;
            TopBar.Controls.Add(label3);
            TopBar.Controls.Add(OperatorEmail);
            TopBar.Controls.Add(pictureBox1);
            TopBar.Location = new Point(3, 3);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1188, 62);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NavPanel
            // 
            NavPanel.Controls.Add(SupplyButton);
            NavPanel.Controls.Add(EquipmentButton);
            NavPanel.Controls.Add(FarmButton);
            NavPanel.Controls.Add(CultureButton);
            NavPanel.Controls.Add(HarvestButton);
            NavPanel.Controls.Add(MessagesButton);
            NavPanel.Controls.Add(EmployeesButton);
            NavPanel.Controls.Add(ClientsButton);
            NavPanel.Controls.Add(OrdersButton);
            NavPanel.Controls.Add(ManufacturerButton);
            NavPanel.Controls.Add(ExitButton);
            NavPanel.Controls.Add(ProductsButton);
            NavPanel.Location = new Point(3, 71);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(225, 587);
            NavPanel.TabIndex = 2;
            // 
            // SupplyButton
            // 
            SupplyButton.Location = new Point(3, 354);
            SupplyButton.Name = "SupplyButton";
            SupplyButton.Size = new Size(219, 33);
            SupplyButton.TabIndex = 11;
            SupplyButton.Text = "Insumos";
            SupplyButton.UseVisualStyleBackColor = true;
            SupplyButton.Click += SupplyButton_Click;
            // 
            // EquipmentButton
            // 
            EquipmentButton.Location = new Point(3, 315);
            EquipmentButton.Name = "EquipmentButton";
            EquipmentButton.Size = new Size(219, 33);
            EquipmentButton.TabIndex = 10;
            EquipmentButton.Text = "Equipamentos";
            EquipmentButton.UseVisualStyleBackColor = true;
            EquipmentButton.Click += EquipmentButton_Click;
            // 
            // FarmButton
            // 
            FarmButton.Location = new Point(3, 276);
            FarmButton.Name = "FarmButton";
            FarmButton.Size = new Size(219, 33);
            FarmButton.TabIndex = 9;
            FarmButton.Text = "Fazendas";
            FarmButton.UseVisualStyleBackColor = true;
            FarmButton.Click += FarmButton_Click;
            // 
            // CultureButton
            // 
            CultureButton.Location = new Point(3, 237);
            CultureButton.Name = "CultureButton";
            CultureButton.Size = new Size(219, 33);
            CultureButton.TabIndex = 8;
            CultureButton.Text = "Culturas";
            CultureButton.UseVisualStyleBackColor = true;
            CultureButton.Click += CultureButton_Click;
            // 
            // HarvestButton
            // 
            HarvestButton.Location = new Point(3, 198);
            HarvestButton.Name = "HarvestButton";
            HarvestButton.Size = new Size(219, 33);
            HarvestButton.TabIndex = 7;
            HarvestButton.Text = "Colheitas";
            HarvestButton.UseVisualStyleBackColor = true;
            HarvestButton.Click += HarvestButton_Click;
            // 
            // MessagesButton
            // 
            MessagesButton.Location = new Point(3, 393);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(219, 33);
            MessagesButton.TabIndex = 4;
            MessagesButton.Text = "Mensagens de contato";
            MessagesButton.UseVisualStyleBackColor = true;
            MessagesButton.Click += MessagesButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Location = new Point(3, 159);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(219, 33);
            EmployeesButton.TabIndex = 5;
            EmployeesButton.Text = "Funcionarios";
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.Location = new Point(3, 120);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(219, 33);
            ClientsButton.TabIndex = 3;
            ClientsButton.Text = "Clientes";
            ClientsButton.UseVisualStyleBackColor = true;
            ClientsButton.Click += ClientsButton_Click_1;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(3, 81);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(219, 33);
            OrdersButton.TabIndex = 2;
            OrdersButton.Text = "Pedidos";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click_1;
            // 
            // ManufacturerButton
            // 
            ManufacturerButton.Location = new Point(3, 42);
            ManufacturerButton.Name = "ManufacturerButton";
            ManufacturerButton.Size = new Size(219, 33);
            ManufacturerButton.TabIndex = 1;
            ManufacturerButton.Text = "Fornecedores";
            ManufacturerButton.UseVisualStyleBackColor = true;
            ManufacturerButton.Click += ManufacturerButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(3, 540);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(219, 44);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Sair";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(3, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(219, 33);
            ProductsButton.TabIndex = 0;
            ProductsButton.Text = "Produtos";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NavPanel);
            Controls.Add(TopBar);
            Controls.Add(ContentPanel);
            Name = "DashboardControl";
            Size = new Size(1194, 661);
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
        private PictureBox pictureBox1;
        private Button ClientsButton;
        private Button OrdersButton;
        private Button ManufacturerButton;
        private Button ProductsButton;
        private Button MessagesButton;
        private Label label3;
        public Label OperatorEmail;
        private Button EmployeesButton;
        private Button ExitButton;
        private Button SupplyButton;
        private Button EquipmentButton;
        private Button FarmButton;
        private Button CultureButton;
        private Button HarvestButton;
    }
}
