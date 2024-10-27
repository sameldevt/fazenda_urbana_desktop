namespace fazenda_verdeviva.UserControls
{
    partial class RegisterControl
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
            EmailInputLabel = new Label();
            LogoImageBox = new PictureBox();
            RegisterButton = new Button();
            EmailInputBox = new TextBox();
            PasswordInputBox = new TextBox();
            PasswordInputLabel = new Label();
            ReturnToLoginButton = new Button();
            NameInputBox = new TextBox();
            NameInputLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).BeginInit();
            SuspendLayout();
            // 
            // EmailInputLabel
            // 
            EmailInputLabel.AutoSize = true;
            EmailInputLabel.Location = new Point(475, 465);
            EmailInputLabel.Name = "EmailInputLabel";
            EmailInputLabel.Size = new Size(41, 15);
            EmailInputLabel.TabIndex = 0;
            EmailInputLabel.Text = "E-mail";
            // 
            // LogoImageBox
            // 
            LogoImageBox.Image = Properties.Resources.logo_fazenda;
            LogoImageBox.Location = new Point(450, 100);
            LogoImageBox.Margin = new Padding(0);
            LogoImageBox.Name = "LogoImageBox";
            LogoImageBox.Size = new Size(300, 300);
            LogoImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoImageBox.TabIndex = 1;
            LogoImageBox.TabStop = false;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(475, 582);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(250, 23);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // EmailInputBox
            // 
            EmailInputBox.Location = new Point(475, 483);
            EmailInputBox.Name = "EmailInputBox";
            EmailInputBox.Size = new Size(250, 23);
            EmailInputBox.TabIndex = 3;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(475, 538);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(250, 23);
            PasswordInputBox.TabIndex = 4;
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(475, 520);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(39, 15);
            PasswordInputLabel.TabIndex = 5;
            PasswordInputLabel.Text = "Senha";
            // 
            // ReturnToLoginButton
            // 
            ReturnToLoginButton.Location = new Point(475, 611);
            ReturnToLoginButton.Name = "ReturnToLoginButton";
            ReturnToLoginButton.Size = new Size(250, 23);
            ReturnToLoginButton.TabIndex = 6;
            ReturnToLoginButton.Text = "Cancelar";
            ReturnToLoginButton.UseVisualStyleBackColor = true;
            ReturnToLoginButton.Click += ReturnToLoginButton_Click;
            // 
            // NameInputBox
            // 
            NameInputBox.Location = new Point(475, 429);
            NameInputBox.Name = "NameInputBox";
            NameInputBox.Size = new Size(250, 23);
            NameInputBox.TabIndex = 8;
            // 
            // NameInputLabel
            // 
            NameInputLabel.AutoSize = true;
            NameInputLabel.Location = new Point(475, 411);
            NameInputLabel.Name = "NameInputLabel";
            NameInputLabel.Size = new Size(94, 15);
            NameInputLabel.TabIndex = 9;
            NameInputLabel.Text = "Nome completo";
            // 
            // RequestAccessControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(NameInputLabel);
            Controls.Add(NameInputBox);
            Controls.Add(ReturnToLoginButton);
            Controls.Add(PasswordInputLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmailInputBox);
            Controls.Add(RegisterButton);
            Controls.Add(LogoImageBox);
            Controls.Add(EmailInputLabel);
            Name = "RequestAccessControl";
            Size = new Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailInputLabel;
        private PictureBox LogoImageBox;
        private Button RegisterButton;
        private TextBox EmailInputBox;
        private TextBox PasswordInputBox;
        private Label PasswordInputLabel;
        private Button ReturnToLoginButton;
        private TextBox NameInputBox;
        private Label NameInputLabel;
    }
}
