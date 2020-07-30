using System;
using System.Text;

public class GFG{
    
    static bool[,] dp = new bool[6,20];
	static public void Main (){
	    
	    
	    int [] arr = {4,5,6,9,10};
	    int sum =19;
	    int n = arr.Length;
	    
	    for (int i = 0; i<6; i++){
	        for (int j = 0;j<10;j++){
	            
	            if(i==0){
	                dp[i,j] =false;
	            }
	            
	            if (j == 0){
	                dp[i,j] = true;
	            }
	            
	        }
	    }
	    
	    
	    Console.WriteLine(SubsetSum(arr,sum,n));
	    


         
		
	}
	
	
	public static bool SubsetSum(int[]arr,int sum, int n) {
	    
	    for(int i =  1; i<n+1; i++){
	        for(int j = 1;j<sum+1; j++){
	            if(arr[i-1]<=j){
	                dp[i,j] = dp[i-1,j-arr[i-1]]||dp[i-1,j];
	            }
	            
	            else {
	                dp[i,j] =dp[i-1,j];
	            }
	        }
	    }
	    
	    return dp[n,sum];
	    
	}
	


}
