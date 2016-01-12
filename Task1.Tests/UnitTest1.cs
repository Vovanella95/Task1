using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Tasks;
using System.Linq;

namespace Task1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Mathematics m = new Mathematics();

        [TestMethod]
        public void Level1_SumIntNumbers()
        {
            Assert.IsTrue(m.Sum(1, 2) == 3);
            Assert.IsTrue(m.Sum(0, 7) == 7);
            Assert.IsTrue(m.Sum(-7, 7) == 0);
            Assert.IsTrue(m.Sum(3, 3) == 6);
        }

        [TestMethod]
        public void Level1_SumIntArray()
        {
            Assert.IsTrue(m.Sum(new int[] { 1, 1, 1 }) == 3);
            Assert.IsTrue(m.Sum(new int[] { 0, 0, 0, 0 }) == 0);
            Assert.IsTrue(m.Sum(new int[] { -10, 18, 6 }) == 14);
            Assert.IsTrue(m.Sum(new int[] { 7, 7, 7 }) == 21);
        }

        [TestMethod]
        public void Level1_SumIntMatrix()
        {
            Assert.IsTrue(m.Sum(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }) == 9);
            Assert.IsTrue(m.Sum(new int[,] { { 1, 9 }, { -9, 7 } }) == 8);
            Assert.IsTrue(m.Sum(new int[,] { { -1, 9, 0 }, { -9, 7, 1 }, { -7, 9, 2 } }) == 11);
        }

        [TestMethod]
        public void Level1_MaxInt()
        {
            Assert.IsTrue(m.Max(0, 4) == 4);
            Assert.IsTrue(m.Max(0, 0) == 0);
            Assert.IsTrue(m.Max(-12, 4) == 4);
        }

        [TestMethod]
        public void Level1_NumberLength()
        {
            Assert.IsTrue(m.NumberLength(12345) == 5);
            Assert.IsTrue(m.NumberLength(0) == 1);
            Assert.IsTrue(m.NumberLength(-235) == 4);
            Assert.IsTrue(m.NumberLength(1000) == 4);
        }

        [TestMethod]
        public void Level1_BorderSumm()
        {
            Assert.IsTrue(m.BorderSum(new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } }) == 33);
            Assert.IsTrue(m.BorderSum(new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } }) == 10);
        }

        [TestMethod]
        public void Level2_DoubleArray()
        {
            var arr2 = m.DoubleArray(new int[] { 1, 2, 3, 4, 5 });
            Assert.IsTrue(arr2[0] == 2 && arr2[1] == 4 && arr2[2] == 6 && arr2[3] == 8 && arr2[4] == 10);


            var arr3 = m.DoubleArray(new int[] { 8, 3, 12 });
            Assert.IsTrue(arr3[0] == 16 && arr3[1] == 6 && arr3[2] == 24);
        }

        [TestMethod]
        public void Level2_UniqueArray()
        {
            var arr2 = m.UniqueArray(new int[] { 1, 2, 2, 4, 4 });
            Assert.IsTrue(arr2[0] == 1 && arr2[1] == 2 && arr2[2] == 4);

            var arr3 = m.UniqueArray(new int[] { 8, 3, 12, 12, 8, 2 });
            Assert.IsTrue(arr3[0] == 8 && arr3[1] == 3 && arr3[2] == 12 && arr3[3] == 2);
        }

        [TestMethod]
        public void Level2_GenerateArray()
        {
            var arr2 = m.GenerateArray(6);
            Assert.IsTrue(arr2[0] == 6 && arr2[1] == 7 && arr2[2] == 8 && arr2[3] == 9 && arr2[4] == 10 && arr2[5] == 11);

            var arr3 = m.GenerateArray(3);
            Assert.IsTrue(arr3[3] == 8 && arr3[4] == 3 && arr3[5] == 12);
        }

        [TestMethod]
        public void Level2_GenerateMatrix()
        {
            var arr2 = m.GenerateMatrix(4, 5);
            Assert.IsTrue(
                arr2[0, 0] == 1 &&
                arr2[0, 1] == 1 &&
                arr2[0, 2] == 1 &&
                arr2[0, 3] == 1 &&
                arr2[0, 4] == 1 &&

                arr2[1, 0] == 1 &&
                arr2[1, 1] == 0 &&
                arr2[1, 2] == 0 &&
                arr2[1, 3] == 0 &&
                arr2[1, 4] == 1 &&

                arr2[2, 0] == 1 &&
                arr2[2, 1] == 0 &&
                arr2[2, 2] == 0 &&
                arr2[2, 3] == 0 &&
                arr2[2, 4] == 1 &&

                arr2[3, 0] == 1 &&
                arr2[3, 1] == 1 &&
                arr2[3, 2] == 1 &&
                arr2[3, 3] == 1 &&
                arr2[3, 4] == 1);

        }

        [TestMethod]
        public void Level3_PolynomSumma()
        {
            var a1 = new Polynom() { coefficients = new double[] { 1, 2, 3, 4, 5 } };
            var a2 = new Polynom() { coefficients = new double[] { 4, 3, 1, 5, 8 } };

            var a3 = a1 + a2;
            Assert.IsTrue(
                a3.coefficients[0] == 5 &&
                a3.coefficients[1] == 5 &&
                a3.coefficients[2] == 4 &&
                a3.coefficients[3] == 9 &&
                a3.coefficients[4] == 13);
        }

        [TestMethod]
        public void Level3_PolynomDifference()
        {
            var a1 = new Polynom() { coefficients = new double[] { 1, 2, 3, 4, 5 } };
            var a2 = new Polynom() { coefficients = new double[] { 4, 3, 1, 5, 8 } };

            var a3 = a1 - a2;
            Assert.IsTrue(
                a3.coefficients[0] == -3 &&
                a3.coefficients[1] == -1 &&
                a3.coefficients[2] == 2 &&
                a3.coefficients[3] == -1 &&
                a3.coefficients[4] == -3);
        }

        [TestMethod]
        public void Level3_PolynomMultiplying()
        {
            var a1 = new Polynom() { coefficients = new double[] { 5, -2, 8 } };
            var a2 = new Polynom() { coefficients = new double[] { -2, 1, -2 } };

            var a3 = a1 * a2;
            Assert.IsTrue(
                a3.coefficients[0] == 10 &&
                a3.coefficients[1] == 9 &&
                a3.coefficients[2] == -28 &&
                a3.coefficients[3] == 12 &&
                a3.coefficients[4] == -16);
        }

        [TestMethod]
        public void Level3_PolynomDegree()
        {
            var a1 = new Polynom() { coefficients = new double[] { 5, 8 } };

            var a3 = m.Degree(a1, 3);
            Assert.IsTrue(
                a3.coefficients[0] == 125 &&
                a3.coefficients[1] == 600 &&
                a3.coefficients[2] == 960 &&
                a3.coefficients[3] == 512);
        }

        [TestMethod]
        public void Level4_TestingSetter()
        {
            HateLongNames a = new HateLongNames();
            a.Name = "Vovanella95";
            Assert.IsTrue(a.Name == "Vovanell");

            a.Name = "lol";
            Assert.IsTrue(a.Name == "lol");
        }

        [TestMethod]
        public void Level5_PolynomDegree()
        {
            Player a = new Player()
            {
                Name = "Uladzimir",
                SurName = "Paliukhovich"
            };

            Assert.IsTrue(a.FullName == "Uladzimir Paliukhovich");
        }
    }
}
