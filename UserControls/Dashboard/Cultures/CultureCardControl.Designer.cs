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
            EstimatedHarvestDate = new Label();
            PlantingDate = new Label();
            label1 = new Label();
            Type = new Label();
            DetailsButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            Cycle = new Label();
            CultureName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(EstimatedHarvestDate);
            ContentPanel.Controls.Add(PlantingDate);
            ContentPanel.Controls.Add(label1);
            ContentPanel.Controls.Add(Type);
            ContentPanel.Controls.Add(DetailsButton);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(Cycle);
            ContentPanel.Controls.Add(CultureName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 172);
            ContentPanel.TabIndex = 2;
            // 
            // EstimatedHarvestDate
            // 
            EstimatedHarvestDate.AutoSize = true;
            EstimatedHarvestDate.Font = new Font("Segoe UI", 14F);
            EstimatedHarvestDate.ForeColor = Color.DarkGray;
            EstimatedHarvestDate.Location = new Point(3, 140);
            EstimatedHarvestDate.Name = "EstimatedHarvestDate";
            EstimatedHarvestDate.Size = new Size(238, 25);
            EstimatedHarvestDate.TabIndex = 14;
            EstimatedHarvestDate.Text = "Membro desde 10/02/2202";
            // 
            // PlantingDate
            // 
            PlantingDate.AutoSize = true;
            PlantingDate.Font = new Font("Segoe UI", 14F);
            PlantingDate.ForeColor = Color.DarkGray;
            PlantingDate.Location = new Point(3, 115);
            PlantingDate.Name = "PlantingDate";
            PlantingDate.Size = new Size(238, 25);
            PlantingDate.TabIndex = 13;
            PlantingDate.Text = "Membro desde 10/02/2202";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(3, 90);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 12;
            label1.Text = "Membro desde 10/02/2202";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Font = new Font("Segoe UI", 14F);
            Type.ForeColor = Color.DarkGray;
            Type.Location = new Point(3, 40);
            Type.Name = "Type";
            Type.Size = new Size(162, 25);
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
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(826, 90);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(95, 35);
            EditButton.TabIndex = 9;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(826, 51);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // Cycle
            // 
            Cycle.AutoSize = true;
            Cycle.Font = new Font("Segoe UI", 14F);
            Cycle.ForeColor = Color.DarkGray;
            Cycle.Location = new Point(3, 65);
            Cycle.Name = "Cycle";
            Cycle.Size = new Size(238, 25);
            Cycle.TabIndex = 2;
            Cycle.Text = "Membro desde 10/02/2202";
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
        private Button EditButton;
        private Button DeleteButton;
        private Label Cycle;
        private Label CultureName;
        private Label PlantingDate;
        private Label label1;
        private Label EstimatedHarvestDate;
    }
}
