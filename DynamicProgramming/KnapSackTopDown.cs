using System;
using System.Text;

public class GFG{
    
    static int[,] dp = new int[5,8];
	static public void Main (){
	    
	    int []  wt  =  {5,2,1,3};
           int  [] val = {4,5,6,9};
           int n = wt.Length;


           Console.WriteLine(KnapSackTopDown(wt, val, 7, n));
		
	}
	
	public static int KnapSackTopDown(int[] wt, int[] val ,int W, int n) {

            for (int i = 0; i<n+1; i++){
                for(int j =  0; j<W+1; j++){
                    
                        dp[i,j] = 0;

                    
                }
            }


            for (int i = 1; i<n+1; i++) {
                for (int j = 1; j<W+1; j++){

                       if (wt[i-1]<=j){
                           dp[i,j] = Math.Max(val[i-1]+dp[i-1,j-wt[i-1]], dp[i-1,j]);
                       }

                       else {
                           dp[i,j] = dp[i-1,j];
                       }
                }
            }

            return dp[n,W];


        }


}
