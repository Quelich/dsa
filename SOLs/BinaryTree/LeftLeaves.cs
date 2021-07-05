namespace SOLs.BinaryTree
{
    //INCOMPLETE
    public class LeftLeaves
    {
        // public static void Main(string[] args)
        // {
        //     
        // }
        public int SumOfLeftLeaves(TreeNode root)
        {
            var sum = 0;
            if (root.left != null)
            {
                sum += SumOfLeftLeaves(root.left);
            }

            SumOfLeftLeaves(root.right);
            return sum;
        }
    }
}