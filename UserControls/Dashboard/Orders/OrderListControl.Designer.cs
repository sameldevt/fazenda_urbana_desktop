namespace fazenda_verdeviva.UserControls.Dashboard.Orders
{
    partial class OrderListControl
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
            OrderList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // OrderList
            // 
            OrderList.Location = new Point(3, 3);
            OrderList.Name = "OrderList";
            OrderList.Size = new Size(942, 507);
            OrderList.TabIndex = 0;
            // 
            // OrderListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderList);
            Name = "OrderListControl";
            Size = new Size(948, 513);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel OrderList;
    }
}
