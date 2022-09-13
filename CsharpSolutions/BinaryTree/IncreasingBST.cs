using System.Collections.Generic;

namespace SOLs.BinaryTree
{
    //Leetcode Problems: 700
    public class IncreasingBST
    {
        public TreeNode IncreasingOrder(TreeNode root, int val)
        {
            if(root == null) return null;
            if(val<root.val) return IncreasingOrder(root.left, val);
        
            if(val> root.val) return IncreasingOrder(root.right, val);
        
            return root;
        }
    }
}