using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19PracticeProblem_RegexEmail
{
    class EmailAddress
    {
        public static void Emailaddress(string name)
        {
            string Email = "^[a-z0-9a-z]{1,}([.#$^][a-z0-9]+)*[@][a-z]{2,}[.][a-z]{2,3}([.][a-z]{2})?$";
            Regex regex = new Regex(Email);
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