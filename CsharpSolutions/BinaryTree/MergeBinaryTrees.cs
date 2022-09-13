namespace SOLs.BinaryTree
{
    //Leetcode solutions: 617
    public class MergeBinaryTrees
    {
       
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;
            root1.val += root2.val;
            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);
            return root1;
        }
    }
}