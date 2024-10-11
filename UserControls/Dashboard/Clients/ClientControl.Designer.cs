namespace fazenda_verdeviva.UserControls.Dashboard
{
    partial class ClientControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ClientsList = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 59);
            panel1.TabIndex = 4;
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
            label1.Location = new Point(68, 3);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 5;
            label1.Text = "Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mini_logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ClientsList
            // 
            ClientsList.Location = new Point(3, 65);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(957, 558);
            ClientsList.TabIndex = 5;
            ClientsList.Paint += flowLayoutPanel2_Paint;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClientsList);
            Controls.Add(panel1);
            Name = "ClientControl";
            Size = new Size(963, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel ClientsList;
    }
}
