using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


namespace Trees
{
    class Program
    {



      
        public static Stack s = new Stack();

       
        static void Main(string[] args)
        {

            Node root = new Node(9);

            root.left = new Node(2);

            root.left.left = new Node(4);

            root.left.right = new Node(5);

            root.right = new Node(3);

            root.right.right =new Node(6);

            root.left.left.left = new Node(10);

            root.left.left.right = new Node(11);

             root.left.left.left.left = new Node(12);

            root.left.left.left.right = new Node(13);


        
        }


        


       
        

        
}

}
