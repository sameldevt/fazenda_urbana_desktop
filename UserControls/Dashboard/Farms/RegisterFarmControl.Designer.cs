namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    partial class RegisterFarmControl
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
            label = new Label();
            label11 = new Label();
            label3 = new Label();
            label2 = new Label();
            label23 = new Label();
            NumberOfGreenhouses = new TextBox();
            FarmName = new TextBox();
            label1 = new Label();
            LocationTextBox = new TextBox();
            FoundationDate = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            IsActiveComboBox = new ComboBox();
            SaveButton = new Button();
            BackButton = new Button();
            label8 = new Label();
            AreaTextBox = new TextBox();
            EmployeeCheckedList = new CheckedListBox();
            EquipmentsCheckedList = new CheckedListBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label.Location = new Point(26, 19);
            label.Name = "label";
            label.Size = new Size(249, 37);
            label.TabIndex = 163;
            label.Text = "Cadastrar fazenda";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(63, 91);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 184;
            label11.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(63, 266);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 183;
            label3.Text = "Quantidade de estufas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(300, 116);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 180;
            label2.Text = "Funcionários";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(63, 116);
            label23.Name = "label23";
            label23.Size = new Size(53, 21);
            label23.TabIndex = 182;
            label23.Text = "Nome";
            // 
            // NumberOfGreenhouses
            // 
            NumberOfGreenhouses.Location = new Point(63, 290);
            NumberOfGreenhouses.Name = "NumberOfGreenhouses";
            NumberOfGreenhouses.Size = new Size(190, 23);
            NumberOfGreenhouses.TabIndex = 177;
            // 
            // FarmName
            // 
            FarmName.Location = new Point(63, 140);
            FarmName.Name = "FarmName";
            FarmName.Size = new Size(190, 23);
            FarmName.TabIndex = 176;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(63, 166);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 187;
            label1.Text = "Localização";
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(63, 190);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(190, 23);
            LocationTextBox.TabIndex = 188;
            // 
            // FoundationDate
            // 
            FoundationDate.Format = DateTimePickerFormat.Short;
            FoundationDate.Location = new Point(63, 240);
            FoundationDate.Name = "FoundationDate";
            FoundationDate.Size = new Size(190, 23);
            FoundationDate.TabIndex = 189;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(63, 216);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 190;
            label4.Text = "Data de fundação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(496, 116);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 192;
            label6.Text = "Equipamentos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(63, 366);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 199;
            label7.Text = "Em atividade?";
            // 
            // IsActiveComboBox
            // 
            IsActiveComboBox.FormattingEnabled = true;
            IsActiveComboBox.Items.AddRange(new object[] { "Frutas", "Verduras", "Legumes", "Folhas" });
            IsActiveComboBox.Location = new Point(63, 390);
            IsActiveComboBox.Name = "IsActiveComboBox";
            IsActiveComboBox.Size = new Size(190, 23);
            IsActiveComboBox.TabIndex = 200;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(759, 462);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(169, 37);
            SaveButton.TabIndex = 201;
            SaveButton.Text = "Cadastrar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(584, 462);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 37);
            BackButton.TabIndex = 202;
            BackButton.Text = "Voltar";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(63, 316);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 204;
            label8.Text = "Área (km)";
            // 
            // AreaTextBox
            // 
            AreaTextBox.Location = new Point(63, 340);
            AreaTextBox.Name = "AreaTextBox";
            AreaTextBox.Size = new Size(190, 23);
            AreaTextBox.TabIndex = 203;
            // 
            // EmployeeCheckedList
            // 
            EmployeeCheckedList.FormattingEnabled = true;
            EmployeeCheckedList.Location = new Point(300, 143);
            EmployeeCheckedList.Name = "EmployeeCheckedList";
            EmployeeCheckedList.Size = new Size(161, 274);
            EmployeeCheckedList.TabIndex = 208;
            EmployeeCheckedList.ItemCheck += EmployeeCheckedList_ItemCheck;
            // 
            // EquipmentsCheckedList
            // 
            EquipmentsCheckedList.FormattingEnabled = true;
            EquipmentsCheckedList.Location = new Point(496, 143);
            EquipmentsCheckedList.Name = "EquipmentsCheckedList";
            EquipmentsCheckedList.Size = new Size(161, 274);
            EquipmentsCheckedList.TabIndex = 209;
            EquipmentsCheckedList.ItemCheck += EquipmentsCheckedList_ItemCheck;
            // 
            // RegisterFarmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EquipmentsCheckedList);
            Controls.Add(EmployeeCheckedList);
            Controls.Add(label8);
            Controls.Add(AreaTextBox);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(IsActiveComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(FoundationDate);
            Controls.Add(LocationTextBox);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label23);
            Controls.Add(NumberOfGreenhouses);
            Controls.Add(FarmName);
            Controls.Add(label);
            Name = "RegisterFarmControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label11;
        private Label label3;
        private Label label2;
        private Label label23;
        private TextBox NumberOfGreenhouses;
        private TextBox FarmName;
        private Label label1;
        private TextBox LocationTextBox;
        private DateTimePicker FoundationDate;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox IsActiveComboBox;
        private Button SaveButton;
        private Button BackButton;
        private Label label8;
        private TextBox AreaTextBox;
        private CheckedListBox EmployeeCheckedList;
        private CheckedListBox EquipmentsCheckedList;
    }
}
