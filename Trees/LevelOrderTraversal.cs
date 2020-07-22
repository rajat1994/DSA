using System;
using System.Collections;
using System.Collections.Generic;

class LevelOrder  {
    

    public static void LevelOrderTraversal(Node root) {

            Queue<Node> q = new Queue<Node>();

            Node curr = root;

            q.Enqueue(curr);

           


            while(q.Count !=0 ) {

                Node peek = q.Peek();

               

                Console.Write(peek.val + " ");

                if (peek.left!= null) {
                    q.Enqueue(peek.left);
                   
                }

                if (peek.right!= null) {
                    q.Enqueue(peek.right);
                   
                }
               

              

                q.Dequeue();

            

            }

        }


}