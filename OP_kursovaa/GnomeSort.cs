using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_kursovaa
{
    public class GnomeSort
    {
        ///<summary>
        /// метод для того, чтобы менять элементв местами, если они в неверном порядке (по возрастанию друг за другом)
        /// </summary>
        /// <param name="item1"> наибольший элемент в паре - предыдущий</param>
        /// <param name="item2"> наименьший элемент в паре - текущий </param>
        static void Swap(ref int item1, ref int item2) // ref - передаём ссылку на переменную, после изменения в методе, сама переменная также измениться, т.к ссылка
        {
            var temp = item1;
            item1 = item2;
            item2 = temp;
        }

        /// <summary>
        /// Гномья сортировка
        /// </summary>
        /// <param name="unsortedArray"> на вход подаём неостортированный массив чисел</param>
        /// <returns></returns>
        public int[] Gnome_Sort(int[] unsortedArray)//тут был static класс, исправила из-за ошибки в недопуске к классу
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Length) //проходимя индексом по всему массиву чисел
            {
                if (unsortedArray[index - 1] < unsortedArray[index]) // сравниваем текущий и предыдущий элемент, смотрим по убыванию
                {
                    index = nextIndex; //переходим на следующий элемент по индексу
                    nextIndex++;
                }
                else
                {
                    Swap(ref unsortedArray[index - 1], ref unsortedArray[index]); //если элементы в неверном порядке (по возрастанию), то меняем их местами
                    index--; //шагаем назад, чтоб проверить, вдруг предыдущая последовательность теперь в неправильном порядке
                    if (index == 0) //если рассматриваем самый первый элемент, то смысла это не имеет, т.к соседа слева у него нет, идём сразу на следующий элемент
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return unsortedArray;
        }
    }
}
