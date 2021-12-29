using System;
using System.Collections.Generic;

namespace DataStructures.BinarySearchTree
{
    public class BinarySearchTree<T> where T: IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }
            
            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }
        
        public List<T> Postorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }
        
        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);
                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }
            }
            return list;
        }

        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
                list.Add(node.Data);
            }
            return list;
        }
        
        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }
                list.Add(node.Data);
                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }
    }
}