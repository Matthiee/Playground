using System;

namespace StrykerExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Process()
        {
            int result1 = MyLocalFunction(true);
            int result2 = MyLocalFunction(false);

            return result1 + result2;

            int MyLocalFunction(bool input)
            {
                return input ? 10 : -1;
            }
        }
    }
}
