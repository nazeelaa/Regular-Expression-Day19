using System;

namespace Day19PracticeProblems_RegexMobileNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your Mobile Number ex : +91 7563214879 .");
            Console.Write("\n Enter Mobile Number : ");
            string name = Console.ReadLine();
            MobileNumber.Mobilenumber(name);
        }
    }
}
 