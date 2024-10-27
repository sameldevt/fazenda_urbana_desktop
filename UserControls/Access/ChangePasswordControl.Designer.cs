namespace fazenda_verdeviva.UserControls.Access
{
    partial class ChangePasswordControl
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
            ReturnButton = new Button();
            PasswordInputLabel = new Label();
            PasswordInputBox = new TextBox();
            EmailInputBox = new TextBox();
            ChangePasswordButton = new Button();
            LogoImageBox = new PictureBox();
            EmailInputLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).BeginInit();
            SuspendLayout();
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(475, 580);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(250, 23);
            ReturnButton.TabIndex = 14;
            ReturnButton.Text = "Voltar";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(475, 477);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(69, 15);
            PasswordInputLabel.TabIndex = 13;
            PasswordInputLabel.Text = "Nova senha";
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(475, 495);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(250, 23);
            PasswordInputBox.TabIndex = 12;
            // 
            // EmailInputBox
            // 
            EmailInputBox.Location = new Point(475, 440);
            EmailInputBox.Name = "EmailInputBox";
            EmailInputBox.Size = new Size(250, 23);
            EmailInputBox.TabIndex = 11;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(475, 551);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(250, 23);
            ChangePasswordButton.TabIndex = 10;
            ChangePasswordButton.Text = "Alterar Senha";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // LogoImageBox
            // 
            LogoImageBox.Image = Properties.Resources.logo_fazenda;
            LogoImageBox.Location = new Point(450, 97);
            LogoImageBox.Margin = new Padding(0);
            LogoImageBox.Name = "LogoImageBox";
            LogoImageBox.Size = new Size(300, 300);
            LogoImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoImageBox.TabIndex = 9;
            LogoImageBox.TabStop = false;
            // 
            // EmailInputLabel
            // 
            EmailInputLabel.AutoSize = true;
            EmailInputLabel.Location = new Point(475, 422);
            EmailInputLabel.Name = "EmailInputLabel";
            EmailInputLabel.Size = new Size(41, 15);
            EmailInputLabel.TabIndex = 8;
            EmailInputLabel.Text = "E-mail";
            // 
            // ChangePasswordControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReturnButton);
            Controls.Add(PasswordInputLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmailInputBox);
            Controls.Add(ChangePasswordButton);
            Controls.Add(LogoImageBox);
            Controls.Add(EmailInputLabel);
            Name = "ChangePasswordControl";
            Size = new Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnButton;
        private Label PasswordInputLabel;
        private TextBox PasswordInputBox;
        private TextBox EmailInputBox;
        private Button ChangePasswordButton;
        private PictureBox LogoImageBox;
        private Label EmailInputLabel;
    }
}
