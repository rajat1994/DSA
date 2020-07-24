using System;

class Cousins {

    public static void IsCousins(Node root, Node a, Node b) {

            if (!isSibling(root,a,b) && (FindLevel(root,a,1) == FindLevel(root,b,1))) {

                Console.WriteLine("Yes");

            }

            else {
                Console.WriteLine("No");
            }
        }



        public static int FindLevel(Node root, Node temp, int count){

            if (root == null) {
                return 0;
            }

            if (root == temp) {
                return count;
            }



          return FindLevel(root.left, temp,count+1)!=0 ? FindLevel(root.left, temp,count+1): FindLevel(root.right, temp,count+1);
            

           
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