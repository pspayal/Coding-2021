using System;

namespace Oops4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook p = new Phonebook();
            int count = new int();

            for (count = 0; count < 50; count++)
            {
                p.ph1[count] = "54564464" + count;

            }

            for (count = 0;count<50; count++)
            {
                Console.WriteLine(p.ph1[2]);

            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
