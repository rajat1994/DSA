﻿using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


namespace Trees
{
    public class Program
    {



       
        public static Stack s = new Stack();

        public static Node rt = null;

      

       
        public static void Main(string[] args)
        {

            Node root = new Node(5);

            root.left = new Node(1);

            root.left.left = new Node(3);

            root.left.right = new Node(11);

            root.right = new Node(6);

            root.right.left = new Node(7);

            root.right.right = new Node(4);

            rt = root;
            int h =  Height(root);

            Console.WriteLine(CheckPerfectBinaryTree(root, h));

      
        }


        public static int Height(Node root) {
            if (root == null){
                return 0;
            }

            return  Math.Max(Height(root.left),Height(root.right))+1;
        }


        public static bool CheckPerfectBinaryTree (Node root, int h) {

            if (root == null) {
                return false;
            }


            if (root.left == null && root.right == null){
                if (LeafLevel(rt,root,1) == h){
                    return true;
                }


                else {
                    return false;
                }
            }

            if (root.left == null || root.right == null){
                return false;
            }


             


            return CheckPerfectBinaryTree(root.right,h) && CheckPerfectBinaryTree(root.left,h);



        }


        public static int LeafLevel (Node root,Node leaf,int count) {
            if (root == null){
                return 0;
            }


            if (root == leaf){
                return count;
            }

            return LeafLevel (root.left,leaf,count+1) !=0 ? LeafLevel (root.left,leaf,count+1) : LeafLevel (root.right,leaf,count+1);
        }
       


        
  

        
}

}
