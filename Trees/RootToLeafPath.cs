using System;

class RootToLeafPaths {

     public static void PrintRootToLeafPaths(Node root,  string path) {

            if (root == null){
                 return;
             }

             path = path + root.val.ToString();

           

            if (root.left == null && root.right == null){
                
             
                
                
              Console.WriteLine(path);

                
            }

            else {

            

            PrintRootToLeafPaths(root.left, path+"->");
            PrintRootToLeafPaths(root.right, path+"->");
            

            }


        }

    

}