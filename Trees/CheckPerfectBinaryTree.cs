using System;


class CheckPerfectBinaryTree {


      public static Node rt = null;

      // rt = root;

     public static int Height(Node root) {
            if (root == null){
                return 0;
            }

            return  Math.Max(Height(root.left),Height(root.right))+1;
        }


        public static bool CheckPerfectBinarytree (Node root, int h) {

            if (root == null) {
                return true;
            }


            if (root.left == null && root.right == null){
                if (LeafLevel(rt,root,1) == h){
                    return true;
                }


                else {
                    return false;
                }
            }

            if (root.left == null || root.right == null){
                return false;
            }


             


            return CheckPerfectBinarytree(root.right,h) && CheckPerfectBinarytree(root.left,h);



        }


        public static int LeafLevel (Node root,Node leaf,int count) {
            if (root == null){
                return 0;
            }


            if (root == leaf){
                return count;
            }

            return LeafLevel (root.left,leaf,count+1) !=0 ? LeafLevel (root.left,leaf,count+1) : LeafLevel (root.right,leaf,count+1);
        }
       


}