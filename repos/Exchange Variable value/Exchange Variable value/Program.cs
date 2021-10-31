using System;

namespace Exchange_Variable_value
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("Before:");
            Console.WriteLine("a = " +a);
            Console.WriteLine("b = " +b);
            c = a;
            a = b;
            Console.WriteLine("After:");
            Console.WriteLine("a = " +b);
            Console.WriteLine("b = " +c);

        }
    }
}
