using System;

namespace Project_new3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;
            Console.WriteLine("nullable int first value :" + i);
            i = i + 42;
            Console.WriteLine("nullable int second value :" + i);
            i = 10;
            Console.WriteLine("nullable int third  value :" + i);
            i = i + 42;
            Console.WriteLine("nullable int fourth value :" + i);

        }
    }
}
