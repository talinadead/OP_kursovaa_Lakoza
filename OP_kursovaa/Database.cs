using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_kursovaa
{
    internal class Database
    {
        private readonly string dataSource;
        private SQLiteConnection conn;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
            conn = new SQLiteConnection(dataSource); //создаём новый конект к БД с известным источником данных
        }
        /// <summary>
        /// инициализация базы данных, создаём таблицу users с столбцами id - число ключ,
        /// login, password, role (его в дальнейшем не используем)
        /// </summary>
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                   + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                   + "login TEXT, "
                   + "password TEXT, "
                   + "role TEXT); ";
                    cmd.CommandText = sql_command; // текст sql-команды
                    cmd.ExecuteNonQuery(); // выполнение sql-команды без возвращения данных
                }
            }
            catch (Exception e) // - исключение 
            {
                MessageBox.Show(e.Message); // - окно сообщения с текстом исключения 
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
        /// <summary>
        /// метод создаёт нового пользователя, заносит информацию о нём в базу данных
        /// </summary>
        /// <param name="login"> заносит логин</param>
        /// <param name="password"> и пароль в базу данных</param>
       
        public bool CreateUser(string login, string password)
        //вносим новогопользователя
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + " VALUES ('{0}', '{1}')",
                login.ToUpper(), password); //имя пользователя сохраняется большими буквами (ToUpper)
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        /// <summary>
        /// метод проверяет пользователя в базе данных по логину и паролю
        /// </summary>
        /// <param name="login"> на вход логин пользвоателя</param>
        /// <param name="password"> и пароль</param>
        /// <returns></returns>
        public bool CheckUser(string login, string password)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT login, password, role"
                    + " FROM users"
                    + " where login = '{0}' AND"
                    + " password = '{1}'",
                    login.ToUpper(), password);

                return cmd.ExecuteScalar() != null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
}
