namespace 移动零
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int slow = 0;

            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            for (int i = slow; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            Solution solution = new Solution();
            solution.MoveZeroes(nums);

            Console.WriteLine("移动零之后的数组:");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
