using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BST tree = new BST();
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            Console.WriteLine(" After insert node the Binary Tree is:");
            tree.inorder();
        }
    }
}
