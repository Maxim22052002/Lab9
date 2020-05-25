using System;
using System.Collections.Generic;
using System.Text;

namespace Number5_9_
{
    public class BinaryTreeNode
    {
        public Match data;
        public BinaryTreeNode leftside = null;
        public BinaryTreeNode rightside = null;
    }
    public class BinaryTree
    {
        BinaryTreeNode root = new BinaryTreeNode();
        public BinaryTreeNode AddRoot(Match elem)
        {
            root = new BinaryTreeNode { data = elem };
            return root;
        }
        public BinaryTreeNode AddLeftSide(BinaryTreeNode node, Match elem)
        {
            var newnode = new BinaryTreeNode { data = elem };
            node.leftside = newnode;
            return newnode;
        }
        public BinaryTreeNode AddRightSide(BinaryTreeNode node, Match elem)
        {
            var newnode = new BinaryTreeNode { data = elem };
            node.rightside = newnode;
            return newnode;
        }
        public void PreOrder(BinaryTreeNode node, int indention = 0)
        {
            if (node != null)
            {
                for (int i = 0; i < indention; i++) Console.Write(" ");
                Console.WriteLine($"{node.data.team1} - {node.data.team2} : {node.data.score1} - {node.data.score2}");
                PreOrder(node.leftside, indention + 5);
                PreOrder(node.rightside, indention + 5);
            }
        }
        public void PreOrderTraversal()
        {
            PreOrder(root);
        }

    }
}

