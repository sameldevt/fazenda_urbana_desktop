namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    partial class FarmCardControl
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
            IsActive = new Label();
            GreenhousesCount = new Label();
            FoundationDate = new Label();
            Location = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            Area = new Label();
            FarmName = new Label();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(IsActive);
            ContentPanel.Controls.Add(GreenhousesCount);
            ContentPanel.Controls.Add(FoundationDate);
            ContentPanel.Controls.Add(Location);
            ContentPanel.Controls.Add(EditButton);
            ContentPanel.Controls.Add(DeleteButton);
            ContentPanel.Controls.Add(Area);
            ContentPanel.Controls.Add(FarmName);
            ContentPanel.Location = new Point(3, 3);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(922, 172);
            ContentPanel.TabIndex = 3;
            // 
            // IsActive
            // 
            IsActive.AutoSize = true;
            IsActive.Font = new Font("Segoe UI", 14F);
            IsActive.ForeColor = Color.DarkGray;
            IsActive.Location = new Point(3, 140);
            IsActive.Name = "IsActive";
            IsActive.Size = new Size(238, 25);
            IsActive.TabIndex = 14;
            IsActive.Text = "Membro desde 10/02/2202";
            // 
            // GreenhousesCount
            // 
            GreenhousesCount.AutoSize = true;
            GreenhousesCount.Font = new Font("Segoe UI", 14F);
            GreenhousesCount.ForeColor = Color.DarkGray;
            GreenhousesCount.Location = new Point(3, 115);
            GreenhousesCount.Name = "GreenhousesCount";
            GreenhousesCount.Size = new Size(238, 25);
            GreenhousesCount.TabIndex = 13;
            GreenhousesCount.Text = "Membro desde 10/02/2202";
            // 
            // FoundationDate
            // 
            FoundationDate.AutoSize = true;
            FoundationDate.Font = new Font("Segoe UI", 14F);
            FoundationDate.ForeColor = Color.DarkGray;
            FoundationDate.Location = new Point(3, 90);
            FoundationDate.Name = "FoundationDate";
            FoundationDate.Size = new Size(238, 25);
            FoundationDate.TabIndex = 12;
            FoundationDate.Text = "Membro desde 10/02/2202";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Segoe UI", 14F);
            Location.ForeColor = Color.DarkGray;
            Location.Location = new Point(3, 40);
            Location.Name = "Location";
            Location.Size = new Size(162, 25);
            Location.TabIndex = 11;
            Location.Text = "email@email.com";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.White;
            EditButton.Location = new Point(824, 51);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(95, 35);
            EditButton.TabIndex = 9;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.ForeColor = SystemColors.ControlText;
            DeleteButton.Location = new Point(824, 12);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(95, 33);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Excluir";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Font = new Font("Segoe UI", 14F);
            Area.ForeColor = Color.DarkGray;
            Area.Location = new Point(3, 65);
            Area.Name = "Area";
            Area.Size = new Size(238, 25);
            Area.TabIndex = 2;
            Area.Text = "Membro desde 10/02/2202";
            // 
            // FarmName
            // 
            FarmName.AutoSize = true;
            FarmName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            FarmName.Location = new Point(3, 3);
            FarmName.Name = "FarmName";
            FarmName.Size = new Size(135, 37);
            FarmName.TabIndex = 1;
            FarmName.Text = "Demonio";
            // 
            // FarmCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Name = "FarmCardControl";
            Size = new Size(928, 178);
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Label IsActive;
        private Label GreenhousesCount;
        private Label FoundationDate;
        private Label Location;
        private Button EditButton;
        private Button DeleteButton;
        private Label Area;
        private Label FarmName;
    }
}
