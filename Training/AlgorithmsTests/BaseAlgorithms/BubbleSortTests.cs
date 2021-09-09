using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BaseAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for(int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            bubble.Items.AddRange(items);

            bubble.Sort();
            items.Sort();

            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(bubble.Items[i], items[i]);
            }
        }
    }
}