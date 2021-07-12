using System;

namespace SOLs.BinaryTree
{
    // Leetcode Problems: 111
    public class MinimumDepth
    {
        public int MinDepth(TreeNode root) {
            if (root == null) return 0;
            // If left subtree is NULL, recur for right subtree
            if (root.left == null) return MinDepth(root.right) + 1;
            // If right subtree is NULL, recur for left subtree
            if (root.right == null)return MinDepth(root.left) + 1;
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}