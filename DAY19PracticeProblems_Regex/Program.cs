using System;
using System.Text.RegularExpressions;

namespace DAY19PracticeProblems_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your name. 1st character should be Capital ");
            Console.Write("\n Enter First Name : ");
            string name = Console.ReadLine();
            FirstName.Firstname(name);

        }
    }

}
