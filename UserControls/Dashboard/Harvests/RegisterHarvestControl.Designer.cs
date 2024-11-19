namespace fazenda_verdeviva.UserControls.Dashboard.Harvests
{
    partial class RegisterHarvestControl
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
            SaveButton = new Button();
            CultureComboBox = new ComboBox();
            label2 = new Label();
            ProductComboBox = new ComboBox();
            label13 = new Label();
            EndDate = new DateTimePicker();
            label15 = new Label();
            StartDate = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            label16 = new Label();
            HarvestedQuantity = new TextBox();
            HarvestedArea = new TextBox();
            label17 = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(581, 458);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 340;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(756, 458);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 354;
            SaveButton.Text = "Cadastrar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CultureComboBox
            // 
            CultureComboBox.FormattingEnabled = true;
            CultureComboBox.Location = new Point(252, 180);
            CultureComboBox.Name = "CultureComboBox";
            CultureComboBox.Size = new Size(190, 23);
            CultureComboBox.TabIndex = 370;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(252, 156);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 369;
            label2.Text = "Cultura";
            // 
            // ProductComboBox
            // 
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(252, 130);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(190, 23);
            ProductComboBox.TabIndex = 368;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(252, 106);
            label13.Name = "label13";
            label13.Size = new Size(66, 21);
            label13.TabIndex = 367;
            label13.Text = "Produto";
            // 
            // EndDate
            // 
            EndDate.Format = DateTimePickerFormat.Short;
            EndDate.Location = new Point(40, 180);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(190, 23);
            EndDate.TabIndex = 366;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(40, 156);
            label15.Name = "label15";
            label15.Size = new Size(91, 21);
            label15.TabIndex = 365;
            label15.Text = "Data do fim";
            // 
            // StartDate
            // 
            StartDate.Format = DateTimePickerFormat.Short;
            StartDate.ImeMode = ImeMode.NoControl;
            StartDate.Location = new Point(40, 127);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(190, 23);
            StartDate.TabIndex = 364;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(40, 106);
            label18.Name = "label18";
            label18.Size = new Size(104, 21);
            label18.TabIndex = 358;
            label18.Text = "Data de início";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label19.Location = new Point(40, 81);
            label19.Name = "label19";
            label19.Size = new Size(181, 25);
            label19.TabIndex = 357;
            label19.Text = "Informações gerais";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label21.Location = new Point(40, 29);
            label21.Name = "label21";
            label21.Size = new Size(251, 37);
            label21.TabIndex = 355;
            label21.Text = "Cadastrar colheita";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(39, 256);
            label16.Name = "label16";
            label16.Size = new Size(91, 21);
            label16.TabIndex = 362;
            label16.Text = "Quantidade";
            // 
            // HarvestedQuantity
            // 
            HarvestedQuantity.Location = new Point(39, 280);
            HarvestedQuantity.Multiline = true;
            HarvestedQuantity.Name = "HarvestedQuantity";
            HarvestedQuantity.Size = new Size(190, 23);
            HarvestedQuantity.TabIndex = 363;
            // 
            // HarvestedArea
            // 
            HarvestedArea.Location = new Point(39, 230);
            HarvestedArea.Multiline = true;
            HarvestedArea.Name = "HarvestedArea";
            HarvestedArea.Size = new Size(190, 23);
            HarvestedArea.TabIndex = 361;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(39, 206);
            label17.Name = "label17";
            label17.Size = new Size(130, 21);
            label17.TabIndex = 360;
            label17.Text = "Área colhida (m²)";
            // 
            // RegisterHarvestControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CultureComboBox);
            Controls.Add(label2);
            Controls.Add(ProductComboBox);
            Controls.Add(label13);
            Controls.Add(EndDate);
            Controls.Add(label15);
            Controls.Add(StartDate);
            Controls.Add(HarvestedQuantity);
            Controls.Add(label16);
            Controls.Add(HarvestedArea);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Name = "RegisterHarvestControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Button SaveButton;
        private ComboBox CultureComboBox;
        private Label label2;
        private ComboBox ProductComboBox;
        private Label label13;
        private DateTimePicker EndDate;
        private Label label15;
        private DateTimePicker StartDate;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label16;
        private TextBox HarvestedQuantity;
        private TextBox HarvestedArea;
        private Label label17;
    }
}
