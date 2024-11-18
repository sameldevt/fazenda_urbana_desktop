namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    partial class RegisterCultureControl
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
            CycleComboBox = new ComboBox();
            TypeComboBox = new ComboBox();
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            ImageLinkLabel = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            EstimatedHarvestDate = new TextBox();
            PlantingDate = new TextBox();
            CultureName = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // CycleComboBox
            // 
            CycleComboBox.FormattingEnabled = true;
            CycleComboBox.Items.AddRange(new object[] { "Empresa 1", "Empresa 2", "Empresa 3" });
            CycleComboBox.Location = new Point(65, 238);
            CycleComboBox.Name = "CycleComboBox";
            CycleComboBox.Size = new Size(190, 23);
            CycleComboBox.TabIndex = 175;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            TypeComboBox.Location = new Point(65, 190);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(190, 23);
            TypeComboBox.TabIndex = 174;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(63, 91);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 173;
            label11.Text = "Informações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(65, 264);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 170;
            label5.Text = "Data do plantio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(65, 216);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 172;
            label3.Text = "Ciclo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 166);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 169;
            label2.Text = "Tipo";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(65, 116);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 171;
            label23.Text = "Nome";
            // 
            // ImageLinkLabel
            // 
            ImageLinkLabel.AutoSize = true;
            ImageLinkLabel.Font = new Font("Segoe UI", 12F);
            ImageLinkLabel.Location = new Point(65, 316);
            ImageLinkLabel.Name = "ImageLinkLabel";
            ImageLinkLabel.Size = new Size(194, 21);
            ImageLinkLabel.TabIndex = 165;
            ImageLinkLabel.Text = "Data prevista para colheita";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(759, 462);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 167;
            SaveButton.Text = "Cadastrar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(584, 462);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 168;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // EstimatedHarvestDate
            // 
            EstimatedHarvestDate.Enabled = false;
            EstimatedHarvestDate.Location = new Point(63, 340);
            EstimatedHarvestDate.Name = "EstimatedHarvestDate";
            EstimatedHarvestDate.Size = new Size(190, 23);
            EstimatedHarvestDate.TabIndex = 166;
            // 
            // PlantingDate
            // 
            PlantingDate.Enabled = false;
            PlantingDate.Location = new Point(65, 288);
            PlantingDate.Name = "PlantingDate";
            PlantingDate.Size = new Size(190, 23);
            PlantingDate.TabIndex = 164;
            // 
            // CultureName
            // 
            CultureName.Enabled = false;
            CultureName.Location = new Point(65, 140);
            CultureName.Name = "CultureName";
            CultureName.Size = new Size(190, 23);
            CultureName.TabIndex = 163;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label.Location = new Point(26, 19);
            label.Name = "label";
            label.Size = new Size(238, 37);
            label.TabIndex = 162;
            label.Text = "Cadastrar cultura";
            // 
            // RegisterCultureControl
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
            Name = "RegisterCultureControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CycleComboBox;
        private ComboBox TypeComboBox;
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label23;
        private Label ImageLinkLabel;
        private Button SaveButton;
        private Button BackButton;
        private TextBox EstimatedHarvestDate;
        private TextBox PlantingDate;
        private TextBox CultureName;
        private Label label;
    }
}
