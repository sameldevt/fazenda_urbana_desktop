namespace fazenda_verdeviva.UserControls
{
    partial class LoginControl
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
            LoginButton = new Button();
            EmailInputBox = new TextBox();
            PasswordInputBox = new TextBox();
            PasswordInputLabel = new Label();
            RegisterButton = new Button();
            ForgotPasswordLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).BeginInit();
            SuspendLayout();
            // 
            // EmailInputLabel
            // 
            EmailInputLabel.AutoSize = true;
            EmailInputLabel.Location = new Point(475, 425);
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
            // LoginButton
            // 
            LoginButton.Location = new Point(475, 554);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(250, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Entrar";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // EmailInputBox
            // 
            EmailInputBox.Location = new Point(475, 443);
            EmailInputBox.Name = "EmailInputBox";
            EmailInputBox.Size = new Size(250, 23);
            EmailInputBox.TabIndex = 3;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(475, 498);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(250, 23);
            PasswordInputBox.TabIndex = 4;
            PasswordInputBox.PasswordChar = '*';
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(475, 480);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(39, 15);
            PasswordInputLabel.TabIndex = 5;
            PasswordInputLabel.Text = "Senha";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(475, 583);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(250, 23);
            RegisterButton.TabIndex = 6;
            RegisterButton.Text = "Cadastrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ForgotPasswordLink
            // 
            ForgotPasswordLink.AutoSize = true;
            ForgotPasswordLink.LinkColor = Color.FromArgb(64, 64, 64);
            ForgotPasswordLink.Location = new Point(475, 524);
            ForgotPasswordLink.Name = "ForgotPasswordLink";
            ForgotPasswordLink.Size = new Size(118, 15);
            ForgotPasswordLink.TabIndex = 7;
            ForgotPasswordLink.TabStop = true;
            ForgotPasswordLink.Text = "Esqueci minha senha";
            ForgotPasswordLink.LinkClicked += ForgotPasswordLink_LinkClicked;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ForgotPasswordLink);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordInputLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmailInputBox);
            Controls.Add(LoginButton);
            Controls.Add(LogoImageBox);
            Controls.Add(EmailInputLabel);
            Name = "LoginControl";
            Size = new Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)LogoImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmailInputLabel;
        private PictureBox LogoImageBox;
        private Button LoginButton;
        private TextBox EmailInputBox;
        private TextBox PasswordInputBox;
        private Label PasswordInputLabel;
        private Button RegisterButton;
        private LinkLabel ForgotPasswordLink;
    }
}
