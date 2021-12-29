using System;
using System.Collections.Generic;
using Algorithms.BaseAlgorithms;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.BaseAlgorithms.Tests
{
    public class SortTestBase
    {
        protected void Init(AlgorithmBase<int> algorithm, int maxCount)
        {
            var rnd = new Random();
            var items = new List<int>();
            items.Clear();
            for (int i = 0; i < maxCount; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            algorithm.Items.AddRange(items);
            algorithm.Sort();
            items.Sort();

            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(algorithm.Items[i], items[i]);
            }
        }
    }
}
