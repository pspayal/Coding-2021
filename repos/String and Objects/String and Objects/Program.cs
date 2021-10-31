using System;

namespace String_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            string world = "world";
            object concat = hello + " " + world;

            Console.WriteLine(concat);
        }
    }
}
