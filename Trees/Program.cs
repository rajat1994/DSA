﻿using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node(10);

            root.left = new Node(8);

            root.right = new Node(2);

            root.left.left = new Node(3);

            root.left.right = new Node(5);

            root.right.left = new Node(2);

            

        }


        
}

}
