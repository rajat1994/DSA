using System;

namespace  DynamicProgramming
{

    class KnapsackRec {



         public static int KnapSackRecursive(int [] wt, int [] val, int W, int n){
            if(n==0 || W == 0) {
                return  0;
            }

            else if (wt[n-1]<=W){
                return Math.Max(val[n-1]+KnapSackRecursive(wt,val,W-wt[n-1],n-1),
                      KnapSackRecursive(wt,val,W,n-1));
            }

            else 
            {
                return  KnapSackRecursive(wt,val,W,n-1);
            }

            
        }
    }
    
}

