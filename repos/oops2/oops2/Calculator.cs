using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2
{
    class Calculator
    {
        int num1 = 20;
        int num2 = 23;

        public  int Add(int n1, int n2 )
        {
            return (n1 + n2);
        }
        public int Subtract(int n1, int n2)
        {
            return (n1 -n2);
        }
        public int Multiply(int n1, int n2)
        {
            return (n1 * n2);
        }
        public int Division(int n1, int n2)
        {
            return (n1 / n2);
        }
        
        public string Add(string n1, string n2)
        {
            return (n1 + n2);
        }
        

    }
}
