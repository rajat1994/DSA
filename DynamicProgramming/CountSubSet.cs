using System;

public class SubsetCount  {
    
    public static int [,] t = new int[8,10];
	static public void Main (){
	    
	    int [] arr =  {1,3,4,5,8,10,9};
	    
	    int sum = 9;
	    
	    int n = arr.Length;
	   
	    Console.WriteLine(CountSubset(arr, n, sum));
	    
	    
	}
	
	
	public static int CountSubset(int []arr, int n, int sum){
	    
	    for (int i = 0; i<n+1; i++){
	        for (int j = 0; j<sum+1;j++){
	            if (i==0){
	                
	                t[i,j] = 0;
	                
	            }
	            
	            if (j==0){
	                t[i,j] = 1;
	            }
	        }
	    }
	    
	    
	    
	    
	    for (int i = 1; i<n+1;i++) {
	        for (int j = 1; j<sum+1;j++){
	            
	            if (arr[i-1]<=j){
	            t[i,j] = t[i-1,j]+t[i-1,j-arr[i-1]];
	        }
	        
	         else {
	        t[i,j] =t[i-1,j];
	    }
	    }
	    
	    }
	    
	   return t[n,sum];
	    
	   
	    
	    
	    
	}
}
