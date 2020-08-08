using System;
using System.Collections.Generic; 

namespace Traversals
{



public class Node {
    
    public Node left= null;
    public Node right = null;
    public int val = 0;
    
    public Node (int key) {
        this.left =null;
        this.right = null;
        this.val =  key;
    }
    
    
}



public class Program{
    
	static public void Main (){
	    
	    Node root = new Node(10);

		root.left = new Node(4);
		root.right = new Node(70);
		root.left.left = new Node(8);
		root.left.right =new Node(9);
		root.left.left.left = new Node(11);
		root.left.right.right =new Node(9);
		root.left.right.right.right =new Node(9);
		root.left.right.right.right.right =new Node(9);
		root.left.right.right.right.right.right =new Node(9);
		//root.left.right.right.right.right.right.right =new Node(9);


		int res =-1;

		MaxPathSumLeafToLeaf(root, ref res);

		Console.WriteLine(res);
		

		

		
	    	
		
	}


	public static int MaxPathSumLeafToLeaf(Node root, ref int res){


		if (root == null) {
			return 0;
		}

		int l = MaxPathSumLeafToLeaf(root.left, ref res);
		int r = MaxPathSumLeafToLeaf(root.right, ref res);

		int temp = Math.Max(l,r)+root.val;

		if (root.left == null && root.right == null){
			temp = Math.Max(temp, root.val);
		}

		int ans = Math.Max(temp, l+r+root.val);

		res = Math.Max(ans, res);

		return temp;



	}

	


	
}


}
