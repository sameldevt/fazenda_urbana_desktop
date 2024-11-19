namespace fazenda_verdeviva.UserControls.Dashboard.Harvests
{
    partial class HarvestCardControl
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
            DeleteButton = new Button();
            label3 = new Label();
            label4 = new Label();
            HarvestedQuantity = new Label();
            HarvestedArea = new Label();
            label2 = new Label();
            label1 = new Label();
            Details = new Button();
            EndDate = new Label();
            OrderPrice = new Label();
            StartDate = new Label();
            HarvestId = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(label3);
            ContentPanel.Controls.Add(label4);
            ContentPanel.Controls.Add(HarvestedQuantity);
            ContentPanel.Controls.Add(HarvestedArea);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(Details);
            ContentPanel.Controls.Add(EndDate);
            ContentPanel.Controls.Add(OrderPrice);
            ContentPanel.Controls.Add(StartDate);
            ContentPanel.Controls.Add(HarvestId);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(904, 174);
            ContentPanel.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(806, 45);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(3, 89);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 15;
            label3.Text = "Área colhida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 14;
            label4.Text = "Quantidade colhida:";
            // 
            // HarvestedQuantity
            // 
            HarvestedQuantity.AutoSize = true;
            HarvestedQuantity.Font = new Font("Segoe UI", 14F);
            HarvestedQuantity.ForeColor = Color.Green;
            HarvestedQuantity.Location = new Point(191, 114);
            HarvestedQuantity.Name = "HarvestedQuantity";
            HarvestedQuantity.Size = new Size(158, 25);
            HarvestedQuantity.TabIndex = 13;
            HarvestedQuantity.Text = "Cartão de crédito";
            // 
            // HarvestedArea
            // 
            HarvestedArea.AutoSize = true;
            HarvestedArea.Font = new Font("Segoe UI", 14F);
            HarvestedArea.ForeColor = Color.Green;
            HarvestedArea.Location = new Point(191, 89);
            HarvestedArea.Name = "HarvestedArea";
            HarvestedArea.Size = new Size(32, 25);
            HarvestedArea.TabIndex = 12;
            HarvestedArea.Text = "13";
            HarvestedArea.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 11;
            label2.Text = "Data de início:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(3, 64);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 10;
            label1.Text = "Data do fim:";
            // 
            // Details
            // 
            Details.BackColor = Color.White;
            Details.Location = new Point(806, 6);
            Details.Name = "Details";
            Details.Size = new Size(95, 33);
            Details.TabIndex = 9;
            Details.Text = "Ver detalhes";
            Details.UseVisualStyleBackColor = false;
            Details.Click += Details_Click;
            // 
            // EndDate
            // 
            EndDate.AutoSize = true;
            EndDate.Font = new Font("Segoe UI", 14F);
            EndDate.ForeColor = Color.Green;
            EndDate.Location = new Point(191, 64);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(158, 25);
            EndDate.TabIndex = 9;
            EndDate.Text = "Cartão de crédito";
            // 
            // OrderPrice
            // 
            OrderPrice.Anchor = AnchorStyles.None;
            OrderPrice.AutoSize = true;
            OrderPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            OrderPrice.ForeColor = Color.Green;
            OrderPrice.Location = new Point(1145, 49);
            OrderPrice.Name = "OrderPrice";
            OrderPrice.Size = new Size(94, 25);
            OrderPrice.TabIndex = 8;
            OrderPrice.Text = "R$ 49,99 ";
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Font = new Font("Segoe UI", 14F);
            StartDate.ForeColor = Color.Green;
            StartDate.Location = new Point(191, 39);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(32, 25);
            StartDate.TabIndex = 7;
            StartDate.Text = "13";
            StartDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // HarvestId
            // 
            HarvestId.AutoSize = true;
            HarvestId.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            HarvestId.Location = new Point(3, 2);
            HarvestId.Name = "HarvestId";
            HarvestId.Size = new Size(168, 37);
            HarvestId.TabIndex = 2;
            HarvestId.Text = "# 21231122";
            // 
            // HarvestCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "HarvestCardControl";
            Size = new Size(910, 180);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label label2;
        private Label label1;
        private Button Details;
        private Label EndDate;
        private Label OrderPrice;
        private Label StartDate;
        private Label HarvestId;
        private Label label3;
        private Label label4;
        private Label HarvestedQuantity;
        private Label HarvestedArea;
        private Button DeleteButton;
    }
}
