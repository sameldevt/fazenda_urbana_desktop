namespace fazenda_verdeviva.UserControls.Dashboard.Messages
{
    partial class ContactMessageControl
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
            Title = new Label();
            pictureBox1 = new PictureBox();
            MessagesList = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Title);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 59);
            panel1.TabIndex = 2;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Title.Location = new Point(68, 0);
            Title.Name = "Title";
            Title.Size = new Size(307, 37);
            Title.TabIndex = 5;
            Title.Text = "Mensagens de contato";
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
            // MessagesList
            // 
            MessagesList.Location = new Point(3, 65);
            MessagesList.Name = "MessagesList";
            MessagesList.Size = new Size(957, 558);
            MessagesList.TabIndex = 3;
            MessagesList.Paint += flowLayoutPanel1_Paint;
            // 
            // ContactMessageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MessagesList);
            Controls.Add(panel1);
            Name = "ContactMessageControl";
            Size = new Size(963, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Title;
        private PictureBox pictureBox1;
        private FlowLayoutPanel MessagesList;
    }
}
