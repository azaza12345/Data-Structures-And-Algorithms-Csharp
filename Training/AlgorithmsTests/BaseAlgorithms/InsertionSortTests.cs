using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BaseAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms.Tests
{
    [TestClass()]
    public class InsertionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var insertion = new InsertionSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            insertion.Items.AddRange(items);
            insertion.Sort();
            items.Sort();

            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(insertion.Items[i], items[i]);
            }
        }
    }
}