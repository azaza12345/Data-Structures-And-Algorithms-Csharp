using System;
using System.Collections;
using DataStructures.DoublyLinkedList;
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

            #region LinkedStackTest

            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(5);
            linkedStack.Push(10);
            linkedStack.Push(15);

            Console.WriteLine("Linked Stack");
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            #endregion

            #region DoublyLinkedListTest

            var doublyList = new DoublyLinkedList<int>();
            doublyList.Add(1);
            doublyList.Add(2);
            doublyList.Add(3);
            doublyList.Add(4);

            foreach (var item in doublyList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();
            var reverseList = doublyList.Reverse();
            
            foreach (var item in reverseList)
            {
                Console.WriteLine(item);
            }
            
            
            #endregion

        }
    }
}