using System;

class LevelDirectionchange{


    public static void LevelOrderDirectionchange(Node root) {

            int count = 0;

            int h = TreeHeight(root);
            bool a = false;

            for (int i =  1; i<=h; i++) {

                if (count == 2){
                    count = 0;
                    a = !a;


                }


                PrintByLevel(root,a,i);
                count++;
                Console.WriteLine(" ");
            }

        }


        public static int TreeHeight(Node root) {

             if (root == null) {
                 return 0;
             }


             return Math.Max(TreeHeight(root.left), TreeHeight(root.right))+1;

        }


        public static void PrintByLevel(Node root, bool a, int k) {

            if (root == null){
                return ;
            }

            if (k == 1){
                Console.Write(root.val+ " ");
            }

            if (a== false) {
                PrintByLevel(root.left, a, k-1);
                PrintByLevel(root.right, a, k-1);
            }

            if (a== true) {
                PrintByLevel(root.right, a, k-1);
                PrintByLevel(root.left, a, k-1);
            }


        }



}