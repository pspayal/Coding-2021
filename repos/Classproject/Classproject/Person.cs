using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classproject
{
    class Person
    {
        string name;
        protected int age; 
        public void Setage(int n)
        {
            age = n;
        }
        public string SetName(string  b)
        {
            name = b;
            return name;
        }
        public void Greet()
        {
            Console.WriteLine("hello");
        }
    }
}
