using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.DoublyLinkedList;
using DataStructures.EasyQueue;
using DataStructures.Set;
using DataStructures.Stack;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EasySet

            EasySet<int> set = new EasySet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            
            EasySet<int> setTrue = new EasySet<int>();
            setTrue.Add(1);
            setTrue.Add(2);
            setTrue.Add(5);
            
            EasySet<int> setFalse = new EasySet<int>();
            setTrue.Add(1);
            setTrue.Add(2);
            setTrue.Add(7);
            
            Console.Write(set.Subset(setTrue) + " ");
            Console.Write(set.Subset(setFalse) + " ");

            #endregion
            #region LinkedListTest
            Training.DataStructure.LinkedList<int> intList = new Training.DataStructure.LinkedList<int>();
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

            #region EasyQueue

            Console.WriteLine("Easy Queue");
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            #endregion

        }
    }
}