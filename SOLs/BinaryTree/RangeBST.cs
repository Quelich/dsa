
namespace SOLs.BinaryTree
{
    //Leetcode solutions: 938
    public class RangeBST
    {
        // public static void Main(string[] args)
        // {
        //     var root = new TreeNode(10);
        //     root.left = new TreeNode(5);
        //     root.right = new TreeNode(15);
        //     root.right.right = new TreeNode(18);
        //     root.left.left = new TreeNode(3);
        //     root.left.right = new TreeNode(7);
        // }

       
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            
            if (root == null) return 0;
            var sum = 0;
            if (low <= root.val && root.val <= high) sum = root.val;
            sum += RangeSumBST(root.left, low, high);
            sum += RangeSumBST(root.right, low, high);
            return sum;
        }
    }
}