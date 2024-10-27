namespace fazenda_verdeviva.UserControls.Dashboard.Clients
{
    partial class ClientListControl
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
            panel1 = new Panel();
            FilterLabel = new Label();
            FilterClientComboBox = new ComboBox();
            SearchButton = new Button();
            SearchClientTextBox = new TextBox();
            SearchClientLabel = new Label();
            ClientsList = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(FilterLabel);
            panel1.Controls.Add(FilterClientComboBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchClientTextBox);
            panel1.Controls.Add(SearchClientLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 59);
            panel1.TabIndex = 5;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Location = new Point(245, 14);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(37, 15);
            FilterLabel.TabIndex = 9;
            FilterLabel.Text = "Filtrar";
            // 
            // FilterClientComboBox
            // 
            FilterClientComboBox.FormattingEnabled = true;
            FilterClientComboBox.Location = new Point(245, 32);
            FilterClientComboBox.Name = "FilterClientComboBox";
            FilterClientComboBox.Size = new Size(169, 23);
            FilterClientComboBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Image = Properties.Resources.search_icon;
            SearchButton.Location = new Point(181, 32);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(34, 23);
            SearchButton.TabIndex = 7;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchClientTextBox
            // 
            SearchClientTextBox.Location = new Point(6, 33);
            SearchClientTextBox.Name = "SearchClientTextBox";
            SearchClientTextBox.Size = new Size(169, 23);
            SearchClientTextBox.TabIndex = 6;
            // 
            // SearchClientLabel
            // 
            SearchClientLabel.AutoSize = true;
            SearchClientLabel.Location = new Point(6, 15);
            SearchClientLabel.Name = "SearchClientLabel";
            SearchClientLabel.Size = new Size(42, 15);
            SearchClientLabel.TabIndex = 5;
            SearchClientLabel.Text = "Buscar";
            // 
            // ClientsList
            // 
            ClientsList.Location = new Point(0, 62);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(954, 496);
            ClientsList.TabIndex = 4;
            // 
            // ClientListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(ClientsList);
            Name = "ClientListControl";
            Size = new Size(960, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label FilterLabel;
        private ComboBox FilterClientComboBox;
        private Button SearchButton;
        private TextBox SearchClientTextBox;
        private Label SearchClientLabel;
        public FlowLayoutPanel ClientsList;
    }
}
