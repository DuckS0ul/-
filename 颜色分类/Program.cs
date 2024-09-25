namespace 颜色分类
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int low = 0;
            int current = 0;
            int high = nums.Length - 1;

            while (current <= high)
            {
                if (nums[current] == 0)
                {
                    Swap(nums, current, low);
                    low++;
                    current++;
                }
                else if (nums[current] == 2)
                {
                    Swap(nums, current, high);
                    high--;
                }
                else
                {
                    current++;
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
