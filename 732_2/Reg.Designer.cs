namespace _732_2
{
    partial class Reg
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
            RegLogin = new TextBox();
            RegPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MakeReg = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(12, 185);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(361, 23);
            RegLogin.TabIndex = 0;
            RegLogin.TextChanged += RegLogin_TextChanged;
            // 
            // RegPwd
            // 
            RegPwd.Location = new Point(12, 244);
            RegPwd.Name = "RegPwd";
            RegPwd.PasswordChar = '*';
            RegPwd.Size = new Size(361, 23);
            RegPwd.TabIndex = 1;
            RegPwd.TextChanged += RegPwd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 167);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 226);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // MakeReg
            // 
            MakeReg.Location = new Point(224, 306);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(136, 23);
            MakeReg.TabIndex = 4;
            MakeReg.Text = "Зарегистрироваться";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += MakeReg_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hzDxffhhXeA_min__1_2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(386, 341);
            Controls.Add(button1);
            Controls.Add(MakeReg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegPwd);
            Controls.Add(RegLogin);
            Name = "Reg";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegLogin;
        private TextBox RegPwd;
        private Label label1;
        private Label label2;
        private Button MakeReg;
        private Button button1;
    }
}