using System;

namespace Day19PracticeProblem_RegexEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\n Enter Email Address : ");
            string name = Console.ReadLine();
            EmailAddress.Emailaddress(name);
        }
    }
}
