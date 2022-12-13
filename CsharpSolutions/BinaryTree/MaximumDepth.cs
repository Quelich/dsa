using System;

namespace SOLs.BinaryTree
{
    public class MaximumDepth
    {
        int answer = 0;

        public int MaxDepth(TreeNode root, int depth)
        {
            if (root == null)
                return -1;

            if (root.left == null && root.right == null)
            {
                answer = Math.Max(answer, depth);
            }

            MaxDepth(root.right, depth + 1);
            MaxDepth(root.left, depth + 1);
            return answer;
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            if (leftDepth > rightDepth)
            {
                return leftDepth + 1;
            }

            return rightDepth + 1;
        }
    }
}
