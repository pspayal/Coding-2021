﻿using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.Read();
        }
    }
}
