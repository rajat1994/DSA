using System;

class SpiralOrderPart1 {

      public static void LevelOrderTraversalSpiralform(Node root) {
            
            Node temp = root;
            if (temp == null) {
                return;
            }

            int h = Height(temp);
            
            
            for (int i = 1; i<=h;i++) {
                if (i%2 == 0){
                    printEvenLevel(temp,i);
                }

                else {
                     printOddLevel(temp,i);
                }
            }


        }


        public static int Height (Node temp) {
            if (temp ==null){
                return 0;
            }

            return Math.Max(Height(temp.left), Height(temp.right))+1;
        }

        public static void printEvenLevel (Node temp, int n) {
            
            if (temp == null){
                return ;
            }

            if (n == 1){
                Console.Write(temp.val + " ");
            }


         
             printEvenLevel (temp.left, n-1);
             printEvenLevel(temp.right,n-1);
          


        }


        public static void printOddLevel (Node temp, int n) {
            
            if (temp == null){
                return ;
            }

            if (n == 1){
                Console.Write(temp.val + " ");
            }

           

             printOddLevel (temp.right, n-1);
             printOddLevel(temp.left,n-1);

        
        }
}