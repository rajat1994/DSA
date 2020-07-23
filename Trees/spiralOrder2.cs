using System;

using System.Collections.Generic;

class SpiralOrder2 {

    
        public static void spiralOrderPart2(Node root){

           
           Stack<Node>  s1 = new Stack<Node>();

           Stack<Node> s2=  new Stack<Node>();

           Node curr =  root;

           

           s1.Push(curr);

           while (s1.Count> 0 || s2.Count> 0){

                    while (s1.Count>0){
                        curr = s1.Peek();

                        s1.Pop();

                        Console.Write(curr.val + " ");

                        if (curr.right!= null){
                            s2.Push(curr.right);
                        }

                        if (curr.left!= null){
                            s2.Push(curr.left);
                        }


                    }


                     while (s2.Count>0){
                        curr = s2.Peek();

                        s2.Pop();

                        Console.Write(curr.val + " ");


                        if (curr.left!= null){
                            s1.Push(curr.left);
                        }

                        if (curr.right!= null){
                            s1.Push(curr.right);
                        }

                        


                    }


           }


        }


}