namespace 二叉树最近公共祖先
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                return root;
            }

            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
            {
                return root;
            }

            return left != null ? left : right;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(5);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(6);
            root.left.right = new TreeNode(2);
            root.left.right.left = new TreeNode(7);
            root.left.right.right = new TreeNode(4);
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(8);

            // 定义 p 和 q
            TreeNode p = root.left; // 节点 5
            TreeNode q = root.right.right; // 节点 8

            Solution solution = new Solution();
            TreeNode lca = solution.LowestCommonAncestor(root, p, q);

            Console.WriteLine($"最近公共祖先是: {lca.val}");
        }
    }
}
