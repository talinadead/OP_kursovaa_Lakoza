using OP_kursovaa;

namespace Op_kursovaa_TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //тестируем Гномью сортировку на разных массивах
        [Test]
        public void TestRandom()
        {
            int[] testarr = { 5, 3, 0, 2, 4, 1, 5 };
            GnomeSort test = new GnomeSort();
            int[] actual = test.Gnome_Sort(testarr);
            int[] expected = {0, 1, 2, 3, 4, 5, 5 };
            Assert.AreEqual(expected, actual); //проверяет операнды expected - ожидалось и actual - получено на равенство 
        }
        [Test]
        public void TestIncrease()
        {
            int[] testarr = { -1, 0, 2, 3, 4, 5, 6, 7, 8, 9};
            GnomeSort test = new GnomeSort();
            int[] actual = test.Gnome_Sort(testarr);
            int[] expected = { -1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestHard()
        {
            int[] testarr = { -1, 7, 3, 4, 18, -5, 6, -8 };
            GnomeSort test = new GnomeSort();
            int[] actual = test.Gnome_Sort(testarr);
            int[] expected = { -8, -5, -1, 3, 4, 6, 7, 18 };
            Assert.AreEqual(expected, actual);
        }
       

    }
}