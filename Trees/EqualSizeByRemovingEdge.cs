using System;

class EqualSizeByRemovingEdge {

     //int n =  NumberOfNodes(root);

    public static int NumberOfNodes (Node root)  {

            if (root == null) {
                return 0;
            }


            return 1+ NumberOfNodes(root.left) + NumberOfNodes(root.right);



        }


         public static bool EqualSizeOrNot(Node root, int n) {
             if (root == null) {
                 return false;
             }


             if (NumberOfNodes(root) == n-NumberOfNodes(root)){


                 return true;

             }


             return EqualSizeOrNot(root.left,n) || EqualSizeOrNot(root.right,n);
         }
}