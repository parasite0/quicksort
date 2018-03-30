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
            Qsclass.HoareSort(array);
            Assert.IsTrue(array[1] >= array[0] && array[2] >= array[1]);
        }
        [TestMethod]
        public void SameElements()
        {
            var array = new int[100];
            for (int i = 0; i < 100; i++)
                array[i] = 5;
            Qsclass.HoareSort(array);
            for (var j = 0; j < 99; j++)
                Assert.IsTrue(array[j] == array[j + 1]);
        }
    }
}
