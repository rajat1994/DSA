using System;


class InorderSucc {

            public static Node x = null;
            public static void InorderSuccessor(Node root, Node temp){

            if (root == null) {
                Console.WriteLine("Tree is Empty!");
            }

            else if (temp == null) {
                Console.WriteLine("Fuck Off!");
            }

            else if (temp.right != null) {
                Node p = LeftMostNode(temp.right);

                Console.WriteLine("Inorder Successor is {0}", p.val);
            }

            else if (temp.right == null) {

                Node s = RightMostNode(root);

                if (s==temp){

                    Console.WriteLine("No Inorder Successor");

                }


                else {
                    FindRecursiveSuccesssor(root, temp);
                }
            }
            



        }


        public static Node LeftMostNode(Node z) {
            if (z== null) {
                return null;
            }

            while (z.left != null) {

                z=z.left;

            }
            return z;
        }

         public static Node RightMostNode(Node z) {
            if (z== null) {
                return null;
            }

            while (z.right != null) {

                z=z.right;

            }
            return z;
        }


        public static Node FindRecursiveSuccesssor(Node root, Node temp) {

               if (root == null){
                   return null;
               }


               if (root == temp || (x = FindRecursiveSuccesssor(root.left,temp))!= null ||
                     (x = FindRecursiveSuccesssor(root.right,temp))!= null
               )

                {

                    if (x != null) {
                        if (root.left == x){
                             Console.WriteLine("Inorder Successor is {0}", root.val);
                             return null;
                        }
                    }

                    return root;
                }

                return null;

        }
}