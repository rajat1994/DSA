using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;


namespace Trees
{
    public class Program
    {



       
        public static Stack s = new Stack();

       

       
      

       //public static int max =0;
        public static void Main(string[] args)
        {

            Node root = new Node(5);

            root.left = new Node(1);

           root.left.left = new Node(3);

           root.left.right = new Node(11);

            root.right = new Node(6);

            root.right.left = new Node(7);

           root.right.right = new Node(4);

            root.right.right.right = new Node(90);

           

        

    
      
        }



        
}

}
