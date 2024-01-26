using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _732_2
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void MakeReg_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("D:\\1234\\DB Kursach\\users.db");

            if (string.IsNullOrEmpty(RegLogin.Text) || string.IsNullOrEmpty(RegPwd.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                
                return;
            }

            string password = RegPwd.Text;
            int minCharacters = 8;

            if (password.Length < minCharacters)
            {
                MessageBox.Show("Минимальное количество символов не достигнуто");
                return;
            }

            if (dBManager.AddUser(RegLogin.Text, RegPwd.Text))
            {
                MessageBox.Show("Успешно!");
            }
            else
            {
                MessageBox.Show("Не удалось! Пользователь с таким логином уже существует");
            }           
        }

        private void RegLogin_TextChanged(object sender, EventArgs e)
        {
            Reg textBox = new Reg();
            int minCharacters = 5;

            textBox.TextChanged += (sender, e) =>
            {
                if (textBox.Text.Length < minCharacters)
                {
                    MessageBox.Show("Минимальное количество символов не достигнуто");
                }
            };

            RegLogin.MaxLength = 15;

            string block = "*-;' ";
            foreach (char c in RegLogin.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        RegLogin.Clear();
                    }
                }
            }
        }

        private void RegPwd_TextChanged(object sender, EventArgs e)
        {

            string block = "*-;' ";
            foreach (char c in RegPwd.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введён запрещённый символ");
                        RegLogin.Clear();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
