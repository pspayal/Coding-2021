using System;

namespace oops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine(c1.Add(6,3));
            Console.WriteLine(c1.Subtract(6, 3));
            Console.WriteLine(c1.Multiply(6, 3));
            Console.WriteLine(c1.Division(6, 3));
            Console.WriteLine(c1.Add("Payal", "swarnkar"));


            Console.WriteLine("Hello World!");
        }
    }
}
