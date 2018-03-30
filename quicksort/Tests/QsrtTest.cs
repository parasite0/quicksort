using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace qsrt.Test
{
    [TestClass]
    public class QsrtTest
    {
        static Random random = new Random();
        [TestMethod]
        public void ThreeElemnts()
        {
            var rnd = new Random();
            var array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = rnd.Next(0, 5);
            }
            Qsclass.QuickSort(array);
            Assert.IsTrue(array[1] >= array[0] && array[2] >= array[1]);
        }
        [TestMethod]
        public void SameElements()
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++)
                array[i] = 5;
            Qsclass.QuickSort(array);
            for (int j = 0; j < 99; j++)
                Assert.IsTrue(array[j] == array[j + 1]);
        }
        [TestMethod]
        public void ThousandElements()
        {
            var rnd = new Random();
            var array = new int[1000];
            var k = rnd.Next(0, 989);
            for (int i = 0; i < 1000; i++)
                array[i] = rnd.Next(0, 10);
            Qsclass.QuickSort(array);
            for (var j = k; j < k+10; j++)
                Assert.IsTrue(array[j] <= array[j + 10]);
        }
        [TestMethod]
        public void EmptyArray()
        {
            var array = new int[0];
            Qsclass.QuickSort(array);
            Assert.AreEqual(array.Length, 0);
        }
        [TestMethod]
        public void ManyElements()
        {
            var rnd = new Random();
            var array = new int[15000000];
            var k = rnd.Next(0, 1000);
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 10000);
            Qsclass.QuickSort(array);
            for (var j = k; j < k + 10; j++)
                Assert.IsTrue(array[j] <= array[j + 10]);
        }
    }
}