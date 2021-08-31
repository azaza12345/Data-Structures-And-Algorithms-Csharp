using System;
using System.Collections;
using Training.DataStructure;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intList = new LinkedList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            
            intList.AssertAfter(3, 77);

            foreach (var i in intList)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}