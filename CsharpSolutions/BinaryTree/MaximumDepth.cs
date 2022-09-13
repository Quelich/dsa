namespace SOLs.BinaryTree
{
    
    public class MaximumDepth
    {
        public class TreeNodeAttr
        {
            public int Depth {get;set;}
            public int Sum {get;set;}
        
            public TreeNodeAttr(int depth, int sum)
            {
                Depth = depth;
                Sum = sum;
            }
        }
        public TreeNodeAttr DeepestLeavesSumRecursive(TreeNode root) 
        {
            if (root == null) return new TreeNodeAttr(-1,-1);
            if (root.left == null && root.right == null) return new TreeNodeAttr(0,root.val);
        
            var left = DeepestLeavesSumRecursive(root.left);
            var right = DeepestLeavesSumRecursive(root.right);
        
            if (left.Depth > right.Depth)
            {
                left.Depth++;
                return left;
            }
            if (left.Depth < right.Depth)
            {
                right.Depth++;
                return right;    
            }
            left.Depth++;
            left.Sum+=right.Sum;
            return left;
        }
        public int DeepestLeavesSum(TreeNode root) {
            return DeepestLeavesSumRecursive(root).Sum;
        }
    }
}