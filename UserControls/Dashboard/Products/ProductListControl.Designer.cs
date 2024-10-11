namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductListControl
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
            ProductsList = new FlowLayoutPanel();
            panel1 = new Panel();
            FilterLabel = new Label();
            FilterProductComboBox = new ComboBox();
            SearchButton = new Button();
            SearchProductTextBox = new TextBox();
            SearchProductLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsList
            // 
            ProductsList.Location = new Point(3, 65);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(954, 496);
            ProductsList.TabIndex = 2;
            ProductsList.Paint += ProductsList_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(FilterLabel);
            panel1.Controls.Add(FilterProductComboBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchProductTextBox);
            panel1.Controls.Add(SearchProductLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 59);
            panel1.TabIndex = 3;
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
            // FilterProductComboBox
            // 
            FilterProductComboBox.FormattingEnabled = true;
            FilterProductComboBox.Location = new Point(245, 32);
            FilterProductComboBox.Name = "FilterProductComboBox";
            FilterProductComboBox.Size = new Size(169, 23);
            FilterProductComboBox.TabIndex = 8;
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
            // SearchProductTextBox
            // 
            SearchProductTextBox.Location = new Point(6, 33);
            SearchProductTextBox.Name = "SearchProductTextBox";
            SearchProductTextBox.Size = new Size(169, 23);
            SearchProductTextBox.TabIndex = 6;
            // 
            // SearchProductLabel
            // 
            SearchProductLabel.AutoSize = true;
            SearchProductLabel.Location = new Point(6, 15);
            SearchProductLabel.Name = "SearchProductLabel";
            SearchProductLabel.Size = new Size(42, 15);
            SearchProductLabel.TabIndex = 5;
            SearchProductLabel.Text = "Buscar";
            // 
            // ProductListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(ProductsList);
            Name = "ProductListControl";
            Size = new Size(960, 558);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ProductsList;
        private Panel panel1;
        private Label FilterLabel;
        private ComboBox FilterProductComboBox;
        private Button SearchButton;
        private TextBox SearchProductTextBox;
        private Label SearchProductLabel;
    }
}
