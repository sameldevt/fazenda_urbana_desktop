namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    partial class EditCultureControl
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
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            ImageLinkLabel = new Label();
            BackButton = new Button();
            EstimatedHarvestDate = new TextBox();
            PlantingDate = new TextBox();
            CultureName = new TextBox();
            label = new Label();
            SaveButton = new Button();
            CycleComboBox = new ComboBox();
            TypeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(63, 90);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 157;
            label11.Text = "Informações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(65, 263);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 149;
            label5.Text = "Data do plantio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(65, 215);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 156;
            label3.Text = "Ciclo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 165);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 147;
            label2.Text = "Tipo";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(65, 115);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 155;
            label23.Text = "Nome";
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(65, 315);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(194, 21);
            ImageLinkLabel.TabIndex = 136;
            ImageLinkLabel.Text = "Data prevista para colheita";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(584, 461);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 139;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // EstimatedHarvestDate
            // 
            EstimatedHarvestDate.Location = new Point(63, 339);
            EstimatedHarvestDate.Name = "EstimatedHarvestDate";
            EstimatedHarvestDate.Size = new Size(190, 23);
            EstimatedHarvestDate.TabIndex = 137;
            // 
            // PlantingDate
            // 
            PlantingDate.Location = new Point(65, 287);
            PlantingDate.Name = "PlantingDate";
            PlantingDate.Size = new Size(190, 23);
            PlantingDate.TabIndex = 135;
            // 
            // CultureName
            // 
            CultureName.Location = new Point(65, 139);
            CultureName.Name = "CultureName";
            CultureName.Size = new Size(190, 23);
            CultureName.TabIndex = 132;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label.Location = new Point(26, 18);
            label.Name = "label";
            label.Size = new Size(190, 37);
            label.TabIndex = 131;
            label.Text = "Editar cultura";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(759, 461);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 138;
            SaveButton.Text = "Salvar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += this.SaveButton_Click;
            // 
            // CycleComboBox
            // 
            CycleComboBox.FormattingEnabled = true;
            CycleComboBox.Items.AddRange(new object[] { "Empresa 1", "Empresa 2", "Empresa 3" });
            CycleComboBox.Location = new Point(65, 237);
            CycleComboBox.Name = "CycleComboBox";
            CycleComboBox.Size = new Size(190, 23);
            CycleComboBox.TabIndex = 161;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            TypeComboBox.Location = new Point(65, 189);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(190, 23);
            TypeComboBox.TabIndex = 160;
            // 
            // EditCultureControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CycleComboBox);
            Controls.Add(TypeComboBox);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(ImageLinkLabel);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(EstimatedHarvestDate);
            Controls.Add(PlantingDate);
            Controls.Add(CultureName);
            Controls.Add(label);
            Name = "EditCultureControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label23;
        private Label ImageLinkLabel;
        private Button BackButton;
        private TextBox EstimatedHarvestDate;
        private TextBox PlantingDate;
        private TextBox CultureName;
        private Label label;
        private Button SaveButton;
        private ComboBox CycleComboBox;
        private ComboBox TypeComboBox;
    }
}
