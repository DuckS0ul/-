namespace 有效括号
{

    internal class Program
    {
        public static bool IsValid(string s)
        {
            // 如果字符串长度是奇数，不可能是有效的括号
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            string input = "()[]{}";  // 你可以改变这个输入来测试不同的括号组合
            bool result = IsValid(input);
            Console.WriteLine($"输入: {input}, 括号是否有效: {result}");
        }
    }
}
