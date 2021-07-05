namespace SOLs.BinaryTree
{
    //INCOMPLETE
    public class MaximumDepth
    {
        public int MaxDepth(TreeNode root) {
            var counter = 0;
            if (root.left != null)
            {
                counter++;
                counter += MaxDepth(root.left);
            }
            else if (root.right != null)
            {
                counter++;
                counter += MaxDepth(root.right);
            }
            return counter;
        }
    }
}