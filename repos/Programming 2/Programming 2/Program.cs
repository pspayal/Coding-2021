﻿using System;

namespace Programming_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input a number: ");
            int num = 6;//Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the desired width: ");
            int width = 6;//Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }
                
                Console.WriteLine("");
                width--;
            }
        }
    }
}

