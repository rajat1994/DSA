using System;

class Diameter {

    public static int DiameterOfaBinaryTree(Node root, int max) {

            if (root == null) {
                return 0 ;
            }

            int lh = Height(root.left);
            int rh = Height(root.right);

            max = Math.Max(max,1+lh+rh);

            DiameterOfaBinaryTree(root.left, max);
            DiameterOfaBinaryTree(root.right, max);

            return max;


        }


        public static int Height(Node root){
            if (root == null) {
                return 0;
            }

            return Math.Max(Height(root.left), Height(root.right))+1;
        }
}