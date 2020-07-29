using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
           int [] wt  =  {5,2,1,3};
           int  [] val = {4,5,6,9};
           int n = wt.Length;
           Console.WriteLine(KnapSackRecursive(wt,val,7,n));
        }


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
