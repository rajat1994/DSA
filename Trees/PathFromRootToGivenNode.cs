using System;

class PathFromRootToGivenNode {

     public static void PathFromRootToGivennode (Node root, Node a,String path ) {


            if (root == null) {
                return;
            }

            path += root.val;

            if (root == a){
                Console.WriteLine(path);
                return;
            }

            else {

                PathFromRootToGivennode (root.left, a,path+"->" );
                 PathFromRootToGivennode (root.right, a,path+"->" );
                
            }
        }



}