using System;

class LeavesAreSameLevel {

      public static Node rt = null;

     // Here rt == root and h is height;
    

        public static bool LeafLevel(Node root, int h){


            if(root == null){
                return true;
            }

            if (root.left == null && root.right == null){
                if (h ==  FindLeafLevel(rt,root,1)){
                    Console.WriteLine(FindLeafLevel(rt,root,1));
                    return true;
                }

                else {
                    return false;
                }
            }

            

           

            return  LeafLevel(root.left, h) &&
            LeafLevel(root.right,h);



            



        }



        public static int FindLeafLevel(Node root, Node leaf, int count) {

            if (root == null){
                return 0;
            }

            if (root == leaf){
                return count;
            }

             return FindLeafLevel(root.left, leaf,count+1)!=0 ? FindLeafLevel(root.left, leaf,count+1): FindLeafLevel(root.right,leaf,count+1);
            

        }
}