using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_kursovaa
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            //создаём новую БД, если её нет
            if (!File.Exists($"{currentDirectoryPath}\\dataBase.DB"))
            {
                Database DB = new Database("Data Source=dataBase.DB; Version = 3;");
                DB.InitializeDatabase();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSortGnomes()); //первой запускаем основную форму Гномья сортировка
        }
    }
}
