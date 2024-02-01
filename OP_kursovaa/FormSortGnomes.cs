using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OP_kursovaa
{
    public partial class FormSortGnomes : Form
    {
        public FormSortGnomes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// происходит до загрузки основной формы FormSortGnomes
        /// создаём новый экземплер формы авторизации FormAuth - она открывается при входе в программу 
        /// форма авторизации закрывается 
        /// </summary>
        private void FormSortGnomes_Load(object sender, EventArgs e)
        {
            DialogResult DialogResultFormAuth = new FormAuth().ShowDialog(); // открываем модальное диалоговое окно,
                                                                             // которое не даёт работать с другими окнами, кроме своего до его закрытия
            if (DialogResultFormAuth == DialogResult.Cancel)
                Close();
        }
        /// <summary>
        /// Метод для генерации массива рандомными числами в заданом 
        /// пользователе диапазоне и количестве
        /// </summary>
        /// <param name="count"> размер массива для генерации (количество чисел) </param>
        /// <param name="from"> начало диапазона генерации </param>
        /// <param name="to"> конец диапазона генерации </param>
        /// <returns> сгенерированный массив </returns>
        public int[] RandomGeneration(int count, int from, int to)
        {
            int[] arr = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; ++i) // генерируем такое количество, которое указал пользователь 
            {
                arr[i] = rand.Next(from, to); // генерируем числа из заданного диапазона 
            }
            return arr;
        }
        // создаём гистограмму для отображения
        Chart chart = new Chart(); 
        
        Series series = new Series();
        Series series_1 = new Series();
        /// <summary>
        /// кнопка для генерации массива, заполненными случайными числами
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // проверяем на ноль в элементе управления
            // "вверх-вниз" для указания размера массива
            if (numericUpDownCount.Value == 0)
            {
                MessageBox.Show("Введите количество чисел для генерации.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //иначе выводим ошибку, что пользователь не ввёл размерность массива
            }
            else if ((String.IsNullOrWhiteSpace(textBoxTo.Text))||(String.IsNullOrWhiteSpace(textBoxFrom.Text))) // проверяем на пробелы или пустое значение в диапазонах 
                                                                 // для диапазона генерации  
            {
                MessageBox.Show("Введите диапазон значений для генерации", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //иначе выдаём ошибку, что пользователь не ввёл диапазон для генерации
            }
            else if (Convert.ToInt32(textBoxFrom.Text) > Convert.ToInt32(textBoxTo.Text)) //проверяем, чтобы диапазон генерации был разумным. Наимешьнее не может быть больше наибольшего, что логично 
            {
                MessageBox.Show("Минимальное значение больше максимального", "Непорядок", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //иначе ошибка, что нужно поменять значения
            }
            else
            {
                try
                {
                    //присваиваем переменным значения с элементов управления "верх-вниз"
                    // сount -  размер массива
                    // from - начало диапазона генерации
                    // to - конец диапазона генерации 
                    int count = Convert.ToInt32(numericUpDownCount.Text);
                    int from = Convert.ToInt32(textBoxFrom.Text);
                    int to = Convert.ToInt32(textBoxTo.Text);
                    int[] nosortarr = RandomGeneration(count, from, to); // тут убрала RG.RandGen
                    string snosortarr = Convert.ToString(nosortarr[0]);
                    for (int i = 1; i < nosortarr.Length; i++)
                    {
                        snosortarr = snosortarr + " " + nosortarr[i];
                    }
                    textBoxNumbers.Text = snosortarr;
                    string[] values = textBoxNumbers.Text.Split(' '); // предполагая, что значения разделены запятыми
                    int[] intData = new int[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (int.TryParse(values[i], out int result))
                        {
                            intData[i] = result;
                        }
                    }
                    chart.Series.Clear();
                    chart.Parent = this;
                    chart.Size = new System.Drawing.Size(400, 290);
                    chart.Location = new System.Drawing.Point();
                    chart.ChartAreas.Add(new ChartArea());
                    series.ChartType = SeriesChartType.Column;
                    chart.Series.Add(series);
                    for (int i = 0; i < intData.Length; i++)
                    {
                        series.Points.AddXY(i, intData[i]);
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show($"{e1.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// кнопка сортировки массива
        /// </summary>
        private void buttonSort_Click(object sender, EventArgs e) //async
        {
            if (String.IsNullOrWhiteSpace(textBoxNumbers.Text))// проверяем, чтобы поле со сгенерированным массивом было непустое, иначе выдаём ошибку
            {
                MessageBox.Show("Поле со сгенерированным массивом пустое. Заполните его", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBoxSortNumbers.Clear(); //если пользователь несколько раз нажимает на генерацию, сортировку, то необходимо очищать textbox
                try
                {
                    string numdata = textBoxNumbers.Text; // вложили в переменную сгенерированный массив 
                    int[] nosortarr = Array.ConvertAll(numdata.Split(' '), int.Parse); // разделили, преобразовали в нужный нам тип
                    GnomeSort ob = new GnomeSort();
                    int[] sortarr = ob.Gnome_Sort(nosortarr); // остортировали массив методом гномьей сортировки 
                    for (int i = 0; i < sortarr.GetLength(0); i++) // выводим значения в отсортированном массива в textBox
                    {
                        textBoxSortNumbers.Text += sortarr[i] ; //ssortarr = ssortarr + " " + sortarr[sortarr.GetLength(i) - 1]; //убрала , i из-за несоотвествия типов
                        textBoxSortNumbers.Text += " ";
                    }
                    string[] values = textBoxSortNumbers.Text.Split(' '); // предполагая, что значения разделены запятыми

                    int[] intData = new int[values.Length]; // необходимо для построении chart гистограммы 
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (int.TryParse(values[i], out int result))
                        {
                            intData[i] = result;
                        }
                    }
                    chart.Series[0].Points.Clear(); //очищаем, если много раз нажимать на сгенерировать и сортирвоать 
                    //chart.Parent = this;
                    // chart.Size = new System.Drawing.Size(400, 400);
                    // chart.Location = new System.Drawing.Point();
                   // chart.ChartAreas.Add(new ChartArea());
                    series_1.ChartType = SeriesChartType.Column;
                    for (int i = 0; i < intData.Length; i++) // добавляем данные в chart для отображения 
                     {
                         series.Points.AddXY(i, intData[i]);
                     }
                    }
                catch (Exception e1)
                {
                    MessageBox.Show($"{e1.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// кнопка для удаления чисел с двух полей и очищения поля гистограммы
        /// </summary>
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxNumbers.Text = ""; //очистили поле с рандомно сгенерированным массивом чисел
            textBoxSortNumbers.Text = ""; //очистили поле с отсортированным массивом чисел 
            //chart.Series[0].Points.Clear(); //очистили гистограмму 
            series.Points.Clear();
        }
        /// <summary>
        /// кнопка выхода из основной формы - закрывает форму
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
