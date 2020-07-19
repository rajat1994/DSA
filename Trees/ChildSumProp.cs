using System;


class ChildSum

{

public  bool Childsum(Node temp) {
            
            int l = 0;
            int r = 0;

            if (temp == null || ((temp.left ==null) && (temp.right == null))) {
                return true;
            }

            if (temp.left != null) {
                 l =  temp.left.val; 
            }

            if (temp.right != null) {
                 r = temp.right.val;
            }
            
            
            if ((temp.val == (l + r))
                && (Childsum(temp.left)) && (Childsum(temp.right))){
                    return true;
                }

           return false;


        }

}
    