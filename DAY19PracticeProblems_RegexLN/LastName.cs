using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DAY19PracticeProblems_RegexLN
{
    class LastName
    {
        public static void Lastname(string name)
        {
            string LastName = "^[A-Z][A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
            }
        }
    }
}