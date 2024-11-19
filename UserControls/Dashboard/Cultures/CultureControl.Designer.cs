namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    partial class CultureControl
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
            panel1 = new Panel();
            RefreshButton = new Button();
            RegisterButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(3, 65);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(954, 519);
            ContentPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 59);
            panel1.TabIndex = 7;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(574, 10);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(169, 37);
            RefreshButton.TabIndex = 11;
            RefreshButton.Text = "Atualizar lista";
            RefreshButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(749, 10);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(169, 37);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 62);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(957, 558);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 5;
            label1.Text = "Culturas";
            // 
            // CultureControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            Name = "CultureControl";
            Size = new Size(960, 587);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Panel panel1;
        public Button RefreshButton;
        public Button RegisterButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
