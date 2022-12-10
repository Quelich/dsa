using System.Collections.Generic;

namespace SOLs.BinaryTree
{
    public class BinaryTreeTraversals
    {
        List<int> _preorderList = new List<int>();
        List<int> _inorderList = new List<int>();
        List<int> _postorderList = new List<int>();

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            var q = new Queue<TreeNode>();

            q.Enqueue(root);
            while (q.Count != 0)
            {
                var len = q.Count;
                List<int> level = new List<int>();
                for (var i = 0; i < len; i++)
                {
                    var node = q.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }

                if (level != null)
                {
                    res.Add(level);
                }
            }

            return res;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return _preorderList;
            _preorderList.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            return _preorderList;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return _inorderList;
            InorderTraversal(root.left);
            _inorderList.Add(root.val);
            InorderTraversal(root.right);
            return _inorderList;
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
                return _postorderList;
            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            _postorderList.Add(root.val);
            return _postorderList;
        }
    }
}
