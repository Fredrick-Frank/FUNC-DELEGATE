using System;

namespace Func_Delegate
{
    public class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            Func<int, int, int> add = Sum;
            int result = add(20, 20);

            Console.WriteLine(result); // returning the third int as an output
        }
    }
}