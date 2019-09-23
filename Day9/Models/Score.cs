using Day9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Day9.Models
{
    public class Score : IScore
    {
        public Score()
        {

        }
        
        public int CountTotalScore(string input)
        {
            var score = 0;
            var level = 0;
            string pattern = @"<(!!)*>|<(.*?)[^!](!!)*>";
            var cleanInput = Regex.Replace(input, pattern, "");

            foreach (var c in cleanInput)
            {
                if (c == '{') score += ++level;
                else if (c == '}') level--;
            }
            
            return score;
        }
    }
}