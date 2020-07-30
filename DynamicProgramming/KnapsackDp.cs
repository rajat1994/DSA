using System;

namespace DynamicProgramming
{

    class KnapsackDp {

         static int[,] t = new int[5,8];

         for (int i = 0; i<5; i++){
               for (int j =  0; j<8; j++){

                   t[i,j] = -1;
               }
           }


        public static int KnapSackDp(int [] wt,int[] val, int W, int n){

            if(n==0 || W == 0){
                return 0;
            }

            else if (t[n,W] != -1)
            {
                return t[n,W];
            }

            else if (wt[n-1]<=W)
            {

                t[n,W] = Math.Max(val[n-1]+KnapSackDp(wt,val,W-wt[n-1],n-1),
                                  KnapSackDp(wt,val,W,n-1));

                return t[n,W];
            
                 
            }

            else {
                t[n,W] =  KnapSackDp(wt,val,W,n-1);
                return t[n,W];
            }


        }
    }
    
}