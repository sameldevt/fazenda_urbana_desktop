namespace fazenda_verdeviva.UserControls.Dashboard.Cultures
{
    partial class CultureListControl
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
            CultureList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // CultureList
            // 
            CultureList.Location = new Point(3, 3);
            CultureList.Name = "CultureList";
            CultureList.Size = new Size(948, 513);
            CultureList.TabIndex = 7;
            // 
            // CultureListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CultureList);
            Name = "CultureListControl";
            Size = new Size(954, 519);
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel CultureList;
    }
}
