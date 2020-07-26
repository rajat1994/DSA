using System;


class PrintMiddleLevelWithoutHeight {


    
        public static void PrintMiddleLevel(Node a, Node b) {

            if (a==null||b==null){
                return;
            }

            if (b.left == null && b.right == null) {
                Console.Write(a.val + " ");
                return;
            }


            PrintMiddleLevel(a.left, b.left.left);
            PrintMiddleLevel(a.right,b.left.left);


        }



}