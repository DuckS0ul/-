namespace 根到叶子节点的数字之和
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
        public int SumNumbers(TreeNode root, int currentSum = 0)
        {
            if (root == null) return 0;

            currentSum = currentSum * 10 + root.val;

            if (root.left == null && root.right == null)
            {
                return currentSum;
            }

            return SumNumbers(root.left, currentSum) + SumNumbers(root.right, currentSum);
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 构造一个二叉树
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(9);
            root.right = new TreeNode(0);
            root.left.left = new TreeNode(5);
            root.left.right = new TreeNode(1);

            Solution solution = new Solution();
            int result = solution.SumNumbers(root);

            Console.WriteLine($"根到叶子节点的数字之和是: {result}");

        }
    }
}
