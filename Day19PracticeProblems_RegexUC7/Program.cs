using System;

namespace Day19PracticeProblems_RegexUC7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Password containig atleast 1 Number");
            Console.WriteLine("enter the password");
            string name = Console.ReadLine();
            Password.password(name);
        }
    }
}
