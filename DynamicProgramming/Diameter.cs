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
		root.right = new Node(7);
		root.left.left = new Node(8);
		root.left.right =new Node(9);
		root.left.left.left = new Node(11);
		root.left.right.right =new Node(9);
		root.left.right.right.right =new Node(9);
		root.left.right.right.right.right =new Node(9);
		root.left.right.right.right.right.right =new Node(9);
		root.left.right.right.right.right.right.right =new Node(9);


		int res =-1;

		Diameter(root, ref res);

		Console.WriteLine(res);
		

		

		
	    	
		
	}


	public static int Diameter(Node root, ref int res){


		if (root == null) {
			return 0;
		}

		int l = Diameter(root.left, ref res);
		int r = Diameter(root.right, ref res);

		int temp = 1+Math.Max(l,r);

		int ans = Math.Max(temp, 1+l+r);

		res = Math.Max(ans, res);

		return temp;





	
}


}
