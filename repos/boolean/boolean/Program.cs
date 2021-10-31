using System;

namespace boolean
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            
            bool value = Convert.ToBoolean("true");
            if (value == true)
                { Console.WriteLine("yes"); }
             value = Convert.ToBoolean("false");

            if (value == false)
            { Console.WriteLine("no"); }          
        }
           
        }

    

    }

