using System;

class FullNodes {


     public static void PrintFullNodes(Node root) {
            if (root ==null) {
                return;
            }

            
            if(root.left != null && root.right != null){
                Console.Write(root.val + " ");
            }

            PrintFullNodes(root.left);
            PrintFullNodes(root.right);



        }

}