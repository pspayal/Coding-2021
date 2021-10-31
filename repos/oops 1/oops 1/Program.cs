using System;

namespace oops_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Student s1 = new Student();
            s1.fullname = "Sam Dude";
            s1.course= "Sanskrit";
           // s1.university= "ExperienceIT";
            s1.subject = "C#";
            s1.eMail = "Sam_Dude@gmail.com";
            s1.phone_number = "2480000000";

            Console.WriteLine("Name : " + s1.fullname);
            Console.WriteLine("Course : " + s1.course);
            Console.WriteLine("University : "+ Student.university);
            Console.WriteLine("Subject : " + s1.subject);
            Console.WriteLine("e-Mail : " + s1.eMail);
            Console.WriteLine("Phone Number : " + s1.phone_number);
        }
    }
}
