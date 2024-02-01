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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        Database DB = new Database("Data Source=dataBase.DB; Version = 3;");
        /// <summary>
        /// Кнопка "отмена", возвращает к форме авторизации
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// кнопка регистрации для нового пользователя
        /// </summary>
        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLogin.Text) ||
               String.IsNullOrWhiteSpace(textBoxPassword.Text) ||
               String.IsNullOrWhiteSpace(textBoxPasswordConfirm.Text)) //проверяем, пустые поля у всех textbox, если пустые, то выдаём ошибку
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка регистрации", MessageBoxButtons.OK);
                return;
            }
            else if (textBoxPassword.Text.Length < 8) //проверяем длину пароля, если меньше, то выдаём ошибку об этом
            {
                MessageBox.Show("Пароль должен содержать миниммум 8 символов.", "Ошибка регистрации", MessageBoxButtons.OK);
                return;
            }

            else if (textBoxPassword.Text != textBoxPasswordConfirm.Text) //проверяем, совпада.т ли данные в пароле и в повторе пароля, иначе выдаём ошибку
            {
                MessageBox.Show("Пароли должны совпадать.", "Ошибка доступа", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (DB.CheckUser(textBoxLogin.Text, textBoxPassword.Text)) //проверяем, существует ли такой пользователь в БД, если да, то выдаём ошибку, что не может повторно зарегистрировать
                {
                    MessageBox.Show("Такой пользователь ранее был зарегистрирован. Придумайте новый логин или войдите в аккаунт, если это вы.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DB.CreateUser(textBoxLogin.Text, textBoxPassword.Text); //если пользователя в БД нет, то заносим информацию о нём в БД
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Вы успешно зарегестрированы!", "Регистрация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //после успешной регистрации закрываем форму регистрации
            }
        }
    }
}
