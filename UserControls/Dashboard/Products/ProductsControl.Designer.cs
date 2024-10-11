namespace fazenda_verdeviva.UserControls.Dashboard.Products
{
    partial class ProductsControl
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
            RegisterButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ContentPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 59);
            panel1.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(749, 10);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(68, 3);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 4;
            label1.Text = "Produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mini_logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(3, 65);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(960, 558);
            ContentPanel.TabIndex = 1;
            ContentPanel.Paint += ContentPanel_Paint;
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            Name = "ProductsControl";
            Size = new Size(966, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        public Button RegisterButton;
        private Panel ContentPanel;
    }
}
