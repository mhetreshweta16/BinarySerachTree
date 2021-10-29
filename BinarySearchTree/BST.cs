using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        /// <summary>
        /// data = user input  
        /// Node having a data , Left and Right 
        /// </summary>
        public int Data;
        public Node Left;
        public Node Right;

        public Node(int New_Data)
        {
            Data = New_Data;  
            Left = null;
            Right = null;

        }

    }
    class BST
    {
        public Node root;
        public void Insert(int new_data)
        {
            Node newNode = new Node(new_data); // creating new Node
            
            //check whetre tree is empty
            //if there is empty ,then set root to newNode
            if (root == null)
                root = newNode;
            else
            {
                //if there is not empty then check whether the
                //value is smaller or larger
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (new_data < current.Data) //if new_data is smaller then move to left child 
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }

                    else
                    { // else move to right childe side
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                    
                }
            }
        }

        void inorderRec(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                inorderRec(root.Left);
                Console.WriteLine(root.Data);
                inorderRec(root.Right);
            }
        }
        /// <summary>
        /// for display this Nodes.
        /// </summary>
        public void inorder()
        {
            inorderRec(root);
        }

        /// <summary>
        /// Ifs the exists.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <param name="num">The number.</param>
        /// <returns></returns>
        bool ifExists(Node root, int num)
        {
            if (root == null)
            {
                
                return false;

            }
            if (root.Data == num)
            {
                
                return true;
            }

            bool res1 = ifExists(root.Left, num);

            if (res1)
                return true;

            bool res2= ifExists(root.Right, num);

            return res2;
        }
        /// <summary>
        /// Searches the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Search(int element)
        {
            if (ifExists(root, element))
            {
                Console.WriteLine("elements {0} is present",element);
            }
            else {
                Console.WriteLine("the element {0} is not present",element);
            }
        
        }
    }
}
