namespace SOLs.BinaryTree
{
    // Leetcode Problems: 112
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum) {
            if(root == null) return false;
            if(root.val == targetSum &&  root.right == null && root.left == null) 
            {
                return true;
            }
            return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }  
    }
}