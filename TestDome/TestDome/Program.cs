using System;

public class TreeNode
{
    public TreeNode LeftChild { get; private set; }
    public TreeNode RightChild { get; private set; }

    public TreeNode(TreeNode leftChild, TreeNode rightChild)
    {
        this.LeftChild = leftChild;
        this.RightChild = rightChild;
    }
}

public class TreeHeight
{
    public static int rheight = 0;
    public static int lheight = 0;
    public static int CalculateHeight(TreeNode root)
    {
        if (root == null)
            return 0;
        int lheight = CalculateHeight(root.LeftChild);
        int rheight = CalculateHeight(root.RightChild);
        if (lheight > rheight)
            return lheight + 1 ;
        else
            return rheight + 1 ;
    }

    public static void Main(string[] args)
    {
        TreeNode leaf1 = new TreeNode(null, null);
        TreeNode leaf2 = new TreeNode(null, null);
        TreeNode node = new TreeNode(leaf1, null);
        TreeNode root = new TreeNode(node,leaf2);

        Console.WriteLine(TreeHeight.CalculateHeight(root));

        Console.Read();
    }
}