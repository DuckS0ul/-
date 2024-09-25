namespace 轮转数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int k = 3;


        }

        static void RotateArray(int[] array, int k)
        {
            int length = array.Length;
            k = k % length; // 确保轮转次数不超过数组长度

            Reverse(array, 0, length - 1);
            Reverse(array, 0, k - 1);
            Reverse(array, k, length - 1);
        }

        static void Reverse(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
