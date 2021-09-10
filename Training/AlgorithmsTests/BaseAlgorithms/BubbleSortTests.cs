using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BaseAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests : SortTestBase
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();
            Init(bubble, 1000);
        }
    }
}