using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_kursovaa
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }
        Database DB = new Database("Data Source=dataBase.DB; Version = 3;");
        /// <summary>
        /// проверка на пустую строку (или только пробелы)
        /// </summary>
        /// <param name="field"> подаём на вход поле для проверки из textbox</param>

        private bool inCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field)) 
                return true;
            return false;
        }

        private bool incorrectFiledsForm() //проверяем пустое ли окно у ввода логина и пустое ли окно у ввода пароля 
        {
            if (inCorrectField(textBoxLogin.Text) || inCorrectField(textBoxPassword.Text))
                return true;
            return false;
        }
        /// <summary>
        /// проверка существования пользователя
        /// </summary>
        /// <param name="login"> подаём логин</param>
        /// <param name="password"> и пароль на проверку</param>
        /// <returns>проверяем существование пользователя методом CheckUser, который смотрит по БД</returns>
        private bool hasUser(string login, string password) 
        {
            return DB.CheckUser(login, password);
        }
        /// <summary>
        /// проверка успешности авторизации, проверяет, что поля логин и пароль непустые (incorrectFiledsForm),
        /// проверяет наличие пользвоателя в БД (CheckUser)
        /// при пустом поле выдаёт ошибку, при отсуствии вводимого логина и пароля в БД тоже выдаёт ошибку
        /// </summary>
        /// <returns></returns>
        private bool AuthSucceess() 
        {
            if (incorrectFiledsForm())
            {
                MessageBox.Show("Пустое поле, вы ничего не ввели");
                return false;
            }
            if (hasUser(textBoxLogin.Text, textBoxPassword.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Проблемы ! Проверьте логин или пароль");
                return false;
            }
        }
        /// <summary>
        /// кнопка авторизации, проверяет успешность (AuthSucceess), после чего закрывает форму авторизации,
        /// иначе, если AuthSucceess ругается, то выдаёт ошибку, что пользователя нет
        /// </summary>
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (AuthSucceess())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет"); //подумай, надо ли показывать сообщение 
            }
        }
        /// <summary>
        /// ссылка на форму регистрации. Если регистрация успешна, но закрывается форма атворизации. 
        /// Если на форме регистрации нажата кнопка "Отмена", то возврат к форме авторизации
        /// </summary>
        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dialogResultFormReg = new FormReg().ShowDialog();
            if (dialogResultFormReg == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
