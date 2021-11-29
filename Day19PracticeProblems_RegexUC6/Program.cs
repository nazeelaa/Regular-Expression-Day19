using System;

namespace Day19PracticeProblems_RegexUC6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your Password ex : Aa9 length atleast 8 .");
            Console.Write("\n Enter Password : ");
            string name = Console.ReadLine();
            PasswordRule2.Password(name);
        }
    }
}
