using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BaseAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms.Tests
{
    [TestClass()]
    public class CoctailSortTests : SortTestBase
    {
        [TestMethod()]
        public void SortTest()
        {
            var coctail = new CoctailSort<int>();
            Init(coctail, 1000);
        }
    }
}