using System;

namespace Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string   userid;
            string password1;

            do
            {
                a++;
                Console.WriteLine("Incorrect password");
                Console.WriteLine("Try again");
                Console.WriteLine("Enter user ID:");
                userid = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                password1 = Console.ReadLine();

            }
            while ((userid != "p" || password1 != "ps") && a < 3);

             if (a>2)
            {  
                Console.WriteLine("Incorrect password"); 
                Console.WriteLine("Number of attempt crossed"); 
            }

            else
            { 
                Console.WriteLine("Congrats you have keyed in correct userid and passowrd "); }

        }
    }
}
