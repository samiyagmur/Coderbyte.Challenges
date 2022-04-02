using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codeland.Username.Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
        }
        public static bool CodelandUsernameValidation(string str)
        {   
           
                Regex regex = new Regex(@"^([a-zA-Z])([a-zA-Z0-9_]{2,23})([^_])$");

                Match match = regex.Match(str);

                return match.Success;
  
                

        }

    }
}
//1.The username is between 4 and 25 characters.
//2.It must start with a letter.
//3. It can only contain letters, numbers, and the underscore character.
//4. It cannot end with an underscore character.
