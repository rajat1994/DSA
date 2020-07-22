using System;
using System.Collections;
using System.Collections.Generic;

class InorderwithoutRecursion {

     public static void InorderTraversalWithoutRecursion(Node root)

           {

               Node curr = root;

               Stack<Node> s = new Stack<Node>();

              

               while(true) {

                   if (curr !=null) {

                       s.Push(curr);
                       curr = curr.left;

                   }

                   if (s.Count != 0 && curr==null) {
                       Node p = s.Pop();

                       Console.Write(p.val+" ");

                       if(p.right!= null) {
                           curr=p.right;
                       }
                   }

                   if (s.Count == 0 && curr == null){
                       break;
                   }


               }



           }




}