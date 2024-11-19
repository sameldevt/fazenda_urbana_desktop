namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    partial class CultureCardControl
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
            label6 = new Label();
            Cycle = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EstimatedHarvestDate = new Label();
            PlantingDate = new Label();
            Farm = new Label();
            Type = new Label();
            DetailsButton = new Button();
            CultureName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(label6);
            ContentPanel.Controls.Add(Cycle);
            ContentPanel.Controls.Add(label5);
            ContentPanel.Controls.Add(label4);
            ContentPanel.Controls.Add(label3);
            ContentPanel.Controls.Add(label2);
            ContentPanel.Controls.Add(EstimatedHarvestDate);
            ContentPanel.Controls.Add(PlantingDate);
            ContentPanel.Controls.Add(Farm);
            ContentPanel.Controls.Add(Type);
            ContentPanel.Controls.Add(DetailsButton);
            ContentPanel.Controls.Add(CultureName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 172);
            ContentPanel.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(7, 126);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 19;
            label6.Text = "Fazenda:";
            // 
            // Cycle
            // 
            Cycle.AutoSize = true;
            Cycle.Font = new Font("Segoe UI", 12F);
            Cycle.ForeColor = Color.Green;
            Cycle.Location = new Point(247, 63);
            Cycle.Name = "Cycle";
            Cycle.Size = new Size(203, 21);
            Cycle.TabIndex = 2;
            Cycle.Text = "Membro desde 10/02/2202";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(7, 105);
            label5.Name = "label5";
            label5.Size = new Size(197, 21);
            label5.TabIndex = 18;
            label5.Text = "Data prevista para colheita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(7, 84);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 17;
            label4.Text = "Data do plantio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(7, 63);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 16;
            label3.Text = "Ciclo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(7, 40);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 15;
            label2.Text = "Tipo:";
            // 
            // EstimatedHarvestDate
            // 
            EstimatedHarvestDate.AutoSize = true;
            EstimatedHarvestDate.Font = new Font("Segoe UI", 12F);
            EstimatedHarvestDate.ForeColor = Color.Green;
            EstimatedHarvestDate.Location = new Point(247, 105);
            EstimatedHarvestDate.Name = "EstimatedHarvestDate";
            EstimatedHarvestDate.Size = new Size(203, 21);
            EstimatedHarvestDate.TabIndex = 14;
            EstimatedHarvestDate.Text = "Membro desde 10/02/2202";
            // 
            // PlantingDate
            // 
            PlantingDate.AutoSize = true;
            PlantingDate.Font = new Font("Segoe UI", 12F);
            PlantingDate.ForeColor = Color.Green;
            PlantingDate.Location = new Point(247, 84);
            PlantingDate.Name = "PlantingDate";
            PlantingDate.Size = new Size(203, 21);
            PlantingDate.TabIndex = 13;
            PlantingDate.Text = "Membro desde 10/02/2202";
            // 
            // Farm
            // 
            Farm.AutoSize = true;
            Farm.Font = new Font("Segoe UI", 12F);
            Farm.ForeColor = Color.Green;
            Farm.Location = new Point(247, 126);
            Farm.Name = "Farm";
            Farm.Size = new Size(203, 21);
            Farm.TabIndex = 12;
            Farm.Text = "Membro desde 10/02/2202";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Font = new Font("Segoe UI", 12F);
            Type.ForeColor = Color.Green;
            Type.Location = new Point(247, 40);
            Type.Name = "Type";
            Type.Size = new Size(134, 21);
            Type.TabIndex = 11;
            Type.Text = "email@email.com";
            // 
            // DetailsButton
            // 
            DetailsButton.BackColor = Color.White;
            DetailsButton.Location = new Point(826, 12);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(95, 33);
            DetailsButton.TabIndex = 10;
            DetailsButton.Text = "Ver detalhes";
            DetailsButton.UseVisualStyleBackColor = false;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // CultureName
            // 
            CultureName.AutoSize = true;
            CultureName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            CultureName.Location = new Point(3, 3);
            CultureName.Name = "CultureName";
            CultureName.Size = new Size(135, 37);
            CultureName.TabIndex = 1;
            CultureName.Text = "Demonio";
            // 
            // CultureCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "CultureCardControl";
            Size = new Size(928, 178);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label Type;
        private Button DetailsButton;
        private Label Cycle;
        private Label CultureName;
        private Label PlantingDate;
        private Label Farm;
        private Label EstimatedHarvestDate;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
