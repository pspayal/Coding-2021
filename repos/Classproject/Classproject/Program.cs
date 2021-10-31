using System;

namespace Classproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            P.Greet();
            P.Setage(6); 
            Student S = new Student();
           // S.Showage();
            S.Setage(6);
            S.Showage();

            Teacher T = new Teacher();
            T.Gotoclasses();

            Console.WriteLine("Hello World!");
        }
    }

    class Student : Person
    {
        //public void Setage(int n)
       // {
          //  age = n+ 10;
       // }
        public void Showage()
        {
            Console.WriteLine("My AGE IS " + age);
        }
    }
    class Teacher : Person
    {
        public void Gotoclasses()
        {
            Console.WriteLine("I am going to CLass");
        }
    }


}
