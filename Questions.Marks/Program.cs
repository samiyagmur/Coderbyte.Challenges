using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Questions.Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
        }
        public static string QuestionsMarks(string str)
        {   
             
            Regex r = new Regex(@"[0-9]+[a-zA-Z?]+[0-9]");
            MatchCollection matches = r.Matches(str);
            int flag = 0;
            if (matches != null)
            {
                foreach (Match member in matches)
                {
                    string memberFirstAndLast = member.ToString();
                    int sumOfMemberFirstAndLast = Convert.ToInt32(memberFirstAndLast.First().ToString()) + Convert.ToInt32(memberFirstAndLast.Last().ToString());

                    if (sumOfMemberFirstAndLast == 10)
                    {
                        int countOfQuestionMark = memberFirstAndLast.Count(x => x == '?');
                        if (3 <= countOfQuestionMark)
                        {   
                            flag=1;//if question mark count is more than 3,flag set=1 becouse this operation happen successful.
                        }
               
                    }                 
                    
                }

            }
            if (flag==1)
            {
                return "True";
            }
            else
            {
                return "False";
            }

            
        }
    }
}
//acc?7??sss?3rr1??????5
