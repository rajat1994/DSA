using System;

class UncoverCoverNodes {

    public static void CoverUncoverNodes(Node root) {

            int  sumofNodes =  SumofAllNodes(root);

            int uncoverNodes = root.val + UncoverLeft(root.left) + UncoverRight(root.right);

            Console.WriteLine(uncoverNodes);
            Console.WriteLine(sumofNodes);

            if (sumofNodes == 2*uncoverNodes) {
                Console.WriteLine(true);
            }

            else {
                 Console.WriteLine(false);
            }

         }


         public static int SumofAllNodes (Node root) {
             if (root == null){
                 return 0;
             }


             return root.val + SumofAllNodes(root.left) + SumofAllNodes(root.right);
         }


         public static int UncoverLeft (Node root) {
             if (root == null){
                 return 0;
             }

             if (root.left != null){
                 return  root.val+UncoverLeft(root.left);
             }
             else {
                 return root.val + UncoverLeft(root.right);
             }
         }


         public static int UncoverRight (Node root) {
             if (root == null){
                 return 0;
             }

             if (root.right != null){
                 return  root.val+UncoverRight(root.right);
             }
             else {
                 return root.val + UncoverRight(root.left);
             }
         }
}