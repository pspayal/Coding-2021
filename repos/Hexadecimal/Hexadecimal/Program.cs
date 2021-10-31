using System;

namespace Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable and assigning hex value
            string hex_value = "0xFE";

            //converting hex to integer
            int int_value = Convert.ToInt32(hex_value, 16);

            //printing the values
            Console.WriteLine("hex_value = {0}", hex_value);
            Console.WriteLine("int_value = {0}", int_value);
                  
            //declaring a variable and assigning hex value
            string hex_value1 = "0x37";
                        //converting hex to integer
            int int_value1 = Convert.ToInt32(hex_value1, 16);

            //printing the values
            Console.WriteLine("hex_value1 = {0}", hex_value1);
            Console.WriteLine("int_value2 = {0}", int_value1);

            //declaring a variable and assigning hex value
            string hex_value2 = "0x10";
            //converting hex to integer
            int int_value2 = Convert.ToInt32(hex_value2, 16);

            //printing the values
            Console.WriteLine("hex_value2 = {0}", hex_value2);
            Console.WriteLine("int_value2 = {0}", int_value2);



            //hit ENTER to exit
            Console.ReadLine();
        }
    }
}
