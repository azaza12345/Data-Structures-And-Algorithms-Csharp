using System;
using System.Collections;
using DataStructures.Stack;
using Training.DataStructure;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedListTest
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
            #endregion

            #region EasyStackListTest

            var easyStack = new EasyStack<int>();
            easyStack.Push(1);
            easyStack.Push(2);
            easyStack.Push(3);

            var item1 = easyStack.Pop();
            var item2 = easyStack.Peek();
            
            Console.WriteLine(item1);
            Console.WriteLine(item2);
            #endregion

            #region LinkedStack

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(5);
            linkedStack.Push(10);
            linkedStack.Push(15);

            Console.WriteLine("Linked Stack");
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            #endregion

        }
    }
}