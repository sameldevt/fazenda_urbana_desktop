﻿namespace fazenda_verdeviva.UserControls.Dashboard.Farms
{
    partial class FarmListControl
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
            FarmList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FarmList
            // 
            FarmList.Location = new Point(3, 3);
            FarmList.Name = "FarmList";
            FarmList.Size = new Size(948, 513);
            FarmList.TabIndex = 7;
            // 
            // FarmListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FarmList);
            Name = "FarmListControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel FarmList;
    }
}
