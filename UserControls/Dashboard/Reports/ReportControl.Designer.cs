namespace fazenda_verdeviva.UserControls.Dashboard.Reports
{
    partial class ReportControl
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
            ExitButton = new Button();
            button2 = new Button();
            AllReportsButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AllReportsButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 663);
            panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(3, 61);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(194, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Sair";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(194, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // AllReportsButton
            // 
            AllReportsButton.Location = new Point(3, 3);
            AllReportsButton.Name = "AllReportsButton";
            AllReportsButton.Size = new Size(194, 23);
            AllReportsButton.TabIndex = 0;
            AllReportsButton.Text = "Todos os relatórios";
            AllReportsButton.UseVisualStyleBackColor = true;
            AllReportsButton.Click += AllReportsButton_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(209, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 663);
            panel2.TabIndex = 1;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportControl";
            Size = new Size(1194, 669);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button AllReportsButton;
        private Button ExitButton;
    }
}
