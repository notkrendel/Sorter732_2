using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _732_2
{
    public partial class Auth : Form
    {

        private bool _isAuthenticated = false;

        public Auth()
        {
            InitializeComponent();
        }

        private void GoReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
                Application.Exit();
        }

        private void MakeAuth_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("D:\\1234\\DB Kursach\\users.db");

            if (dBManager.CheckUser(AuthLogin.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось!");
            }
        }

        private void AuthLogin_TextChanged(object sender, EventArgs e)
        {

            Auth textBox = new Auth();
            int minCharacters = 5;

            textBox.TextChanged += (sender, e) =>
            {
                if (textBox.Text.Length < minCharacters)
                {
                    MessageBox.Show("Минимальное количество символов не достигнуто");
                }
            };

            AuthLogin.MaxLength = 15;


            string block = "*-;'";
            foreach (char c in AuthLogin.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        AuthLogin.Clear();
                    }
                }
            }
        }

        private void AuthPwd_TextChanged(object sender, EventArgs e)
        {
            Auth textBox = new Auth();
            int minCharacters = 8;

            textBox.TextChanged += (sender, e) =>
            {
                if (textBox.Text.Length < minCharacters)
                {
                    MessageBox.Show("Минимальное количество символов не достигнуто");
                }
            };
        }
    }
}
