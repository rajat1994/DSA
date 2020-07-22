using System;

class NodeInorder {

     public static int count = 0;
    public static void NthNodeInorder(Node root, int n) {

            if (root == null) {
                return ;
            }


            if (count<=n) {

                NthNodeInorder(root.left,n);
                count++;

                if (count == n){
                    Console.WriteLine(root.val);
                    return;
                }

                NthNodeInorder(root.right, n);

            }

           



        }

}