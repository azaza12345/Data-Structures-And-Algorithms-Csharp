using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BaseAlgorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms.Tests
{
    [TestClass()]
    public class ShellSortTests : SortTestBase
    {
        [TestMethod()]
        public void SortTest()
        {
            var shell = new ShellSort<int>();
            Init(shell, 1000);
        }
    }
}