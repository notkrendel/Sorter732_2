namespace _732_2
{
    partial class Auth
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AuthLogin = new TextBox();
            AuthPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MakeAuth = new Button();
            GoReg = new Button();
            SuspendLayout();
            // 
            // AuthLogin
            // 
            AuthLogin.Location = new Point(79, 193);
            AuthLogin.Name = "AuthLogin";
            AuthLogin.Size = new Size(310, 23);
            AuthLogin.TabIndex = 0;
            AuthLogin.TextChanged += AuthLogin_TextChanged;
            // 
            // AuthPwd
            // 
            AuthPwd.Location = new Point(79, 239);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.Size = new Size(310, 23);
            AuthPwd.TabIndex = 1;
            AuthPwd.TextChanged += AuthPwd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 193);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 239);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // MakeAuth
            // 
            MakeAuth.Location = new Point(12, 291);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(75, 23);
            MakeAuth.TabIndex = 4;
            MakeAuth.Text = "Войти";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += MakeAuth_Click;
            // 
            // GoReg
            // 
            GoReg.Location = new Point(257, 291);
            GoReg.Name = "GoReg";
            GoReg.Size = new Size(132, 23);
            GoReg.TabIndex = 5;
            GoReg.Text = "Зарегистрироваться";
            GoReg.UseVisualStyleBackColor = true;
            GoReg.Click += GoReg_Click;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.VXld9pMDG1E1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(401, 326);
            Controls.Add(GoReg);
            Controls.Add(MakeAuth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AuthPwd);
            Controls.Add(AuthLogin);
            Name = "Auth";
            Text = "Авторизация";
            FormClosed += Auth_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLogin;
        private TextBox AuthPwd;
        private Label label1;
        private Label label2;
        private Button MakeAuth;
        private Button GoReg;
    }
}