using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19PracticeProblems_RegexUC7
{
    class Password
    {
        public static void password(string name)
        {
            string Password = "^[A - Za-z0-9]{8}";
            Regex regex = new Regex(Password);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid.");
            }
        }
    }
}

