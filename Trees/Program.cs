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

            root.left = new Node(4);

            root.left.left = new Node(3);

            root.left.right = new Node(6);

            root.left.right.left = new Node(68);

            root.left.right.right = new Node(1);

            root.right = new Node(17);

            root.right.right =new Node(22);

            root.right.right.right =new Node(20);


        
        }



         



        


       
        

        
}

}
