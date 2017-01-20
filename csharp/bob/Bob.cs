using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercism.Bob
{
    public class Bob
    {
        public Bob() 
        {
            var aDic= new Dictionary<byte, string>();   //answer dictionary. ha.
                aDic.Add(0,"Sure.");
                aDic.Add(1,"Whoa, chill out!");
                aDic.Add(2,"Fine. Be that way!");
                aDic.Add(3,"Whatever.");
            Answers = aDic; 
        }

        public string Hey(string input)
        { 
            var output = string.Empty;

            input = input.TrimEnd();
            // input = Regex.Replace(input, "[0-9]", "");

            if (string.IsNullOrWhiteSpace(input))
            { output = Answers[2]; }
            else if (input == input.ToUpper() && input != input.ToLower())
            { output = Answers[1]; }
            else if (input.EndsWith("?"))
            { output = Answers[0]; }
            else
            { output = Answers[3]; }

            return output;
        }

        private enum Input : byte
        {
            Question, 
            Yell,
            Nothing,
            EverythingElse
        }
        private Dictionary<byte, string> Answers {get;set;}
        
    }
}