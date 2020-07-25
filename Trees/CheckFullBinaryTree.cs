using System;

class CheckFullBinaryTree {
     


     
        public static bool FullBinaryTree (Node root) {

            if (root == null) {
                return true;
            }

            if (
               (root.left != null && root.right == null)||
               (root.left == null && root.right != null)
               )

               {
                   return false;
               }

              


            return FullBinaryTree (root.left) && FullBinaryTree(root.right);
        }




}