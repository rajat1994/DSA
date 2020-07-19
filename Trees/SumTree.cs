class SumTree {

      static int sum = 0;
      public static int SumofNodes(Node root) {

            if (root == null) {
                return 0;
            }

            SumofNodes(root.left);
            sum = sum + root.val;
            SumofNodes(root.right);


            return sum;


        }


        public static bool Sumtree (Node root) {

            int l = 0;
            int r = 0;

            if (root == null || (root.left == null && root.right == null)) {
                return true;
            }

            if (root.left !=null ) {
                l= SumofNodes(root.left);
                sum=  0;
               
            }

            if (root.right != null) {
                r = SumofNodes(root.right);
                sum=0;
                
            }

            if ((root.val == l + r)&& (Sumtree(root.left)) && (Sumtree(root.right))) {

                sum =0;
                
                return true;
            }

            return false;

        }

}