class SumTree {

      
      public static int SumofNodes(Node root) {

            if (root == null) {
                return 0;
            }

            

            return root.val+SumofNodes(root.left)+SumofNodes(root.right);
                
        

        }


        public static bool Sumtree (Node root) {

            int l = 0;
            int r = 0;

            if (root == null || (root.left == null && root.right == null)) {
                return true;
            }

            if (root.left !=null ) {
                l= SumofNodes(root.left);
               
               
            }

            if (root.right != null) {
                r = SumofNodes(root.right);
                
                
            }

            if ((root.val == l + r)&& (Sumtree(root.left)) && (Sumtree(root.right))) {
                
                return true;
            }

            return false;

        }

}