namespace 两数之和
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 11, 15, 7 };
            int target = 4;

            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine("两个数的索引是: [" + result[0] + ", " + result[1] + "]");
            }
            else
            {
                Console.WriteLine("没有找到符合条件的两个数。");
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i};
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            return null;
        }
    }
}
