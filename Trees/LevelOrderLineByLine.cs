using System;

using System.Collections.Generic;

class LevelOrderLineByLine {

        public static void LevelOrderTraversalLineByLine(Node root) {

            

            Node curr =  root;
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(curr);

            q.Enqueue(null);

            
            while (q.Count != 0) {

                curr = q.Dequeue();
            

            if (curr == null) {

                if (q.Count> 0) {
                    Console.WriteLine(" ");
                    q.Enqueue(null);
                   
                }

            }
         

         else {
               
                if (curr.left != null) {
                    q.Enqueue(curr.left);
                
                }

                 if (curr.right != null) {
                    q.Enqueue(curr.right);
                
                }

                 Console.Write(curr.val + " ");


         }

                

            

            }

        

        }

}