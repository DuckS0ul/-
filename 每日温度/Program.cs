namespace 每日温度
{
    internal class Program
    {
        public static int[] GetDailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] result = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevDay = stack.Pop();
                    result[prevDay] = i - prevDay;
                }
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                result[stack.Pop()] = 0;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] result = GetDailyTemperatures(temperatures);

            Console.WriteLine("每日温度结果: ");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
