using lab9_Dish;

namespace TestCalories
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() // конструктор с параметром, по умолчанию
        {
            Dish expected = new Dish();
            Dish actual = new Dish(-1, -1, -1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2() // конструктор копирования, бинарный +
        {
            Dish expected = new Dish(10.5, 12.3, 8);
            expected++;
            Dish actual = new Dish(expected);
            Assert.AreEqual(new Dish(11.5, 13.3, 9), actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Dish expected = new Dish(14, 32.4, 0.5);
            Assert.AreEqual(349.6, expected.NumberCalories());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Dish expected = new Dish(14, 32.4, 0.5);
            Assert.AreEqual(349.6, Dish.CalculateCalories(expected));
        }


        [TestMethod]
        public void TestMethod5()
        {
            Dish expected = new Dish(18, 18, 24);
            Assert.AreEqual(true, (bool)expected);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Dish expected = new Dish(3, 5.2, 0);
            string actual = expected;
            Assert.AreEqual("Proteins - 3 g., fats - 5,2 g., carbohydrates - 0 g.\n\n", actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Dish expected = new Dish(3, 5.2, 0);
            Assert.AreEqual(1.5 * expected, expected * 1.5);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Dish dish1 = new Dish(1, 1, 1);
            Dish dish2 = new Dish(2, 2, 2);
            Assert.AreEqual(false, dish2 < dish1);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Dish d1 = new Dish(3, 0.9, 13);
            Dish d2 = new Dish(15, 15, 20);
            Assert.AreEqual(false, d1 > d2);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Dish expected = new Dish(18, 19, 24);
            Assert.AreEqual(false, (bool)expected);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Dish expected = new Dish(18, 19, 24);
            Assert.AreEqual(16.95, ~expected);
        }

        [TestMethod]
        public void TestGet1()
        {
            DishArray d = new DishArray(5);
            Assert.ThrowsException<IndexOutOfRangeException>(() => { new Dish(d[10]); } );
        }

        [TestMethod]
        public void TestGet2()
        {
            DishArray d1 = new DishArray();
            DishArray d2 = new DishArray(d1);
            Assert.AreEqual(d2[2], d2.FindMostCaloricFood());
        }

        [TestMethod]
        public void TestIndexerSetter_ValidIndex_SetsDish()
        {
            DishArray d1 = new DishArray(5);
            Dish d2 = new Dish(13, 5, 6);
            d1[1] = d2;
            Assert.AreEqual(d2, d1[1]);
        }
    }
}