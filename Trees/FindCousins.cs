using System;

class FindCousins {

     public static void CousinsOfGivenNode(Node root1,Node root, Node a) {

            if (root == null){
                return ;
            }


            if(Level(root1,root,1)==Level(root1,a,1) && !isSibling(root1,root,a) && (root!=a)){
                Console.WriteLine(root.val + " ");
                return;
            }
            CousinsOfGivenNode(root1,root.left, a);
            CousinsOfGivenNode(root1,root.right, a);







        }

         public static int Level(Node root, Node temp, int count){

            if (root == null) {
                return 0;
            }

            if (root == temp) {
                return count;
            }



          return Level(root.left, temp,count+1)!=0 ? Level(root.left, temp,count+1): Level(root.right, temp,count+1);
            

           
        }


        public static bool isSibling(Node root, Node a , Node b) {

            if (root == null){
                return false;
            }


            return ((root.left == a && root.right ==b) ||
                     (root.left == b && root.right ==a) ||
                     isSibling(root.left, a, b) ||
                     isSibling(root.right, a,b)


            );


        }
 


}