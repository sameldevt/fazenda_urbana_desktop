﻿namespace fazenda_verdeviva.UserControls.Dashboard.Common
{
    partial class NoResourceFound
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(237, 200);
            label1.Name = "label1";
            label1.Size = new Size(513, 59);
            label1.TabIndex = 0;
            label1.Text = "Nenhum item encontrado";
            // 
            // NoResourceFound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Name = "NoResourceFound";
            Size = new Size(948, 513);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
