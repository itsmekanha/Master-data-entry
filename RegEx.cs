using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp4
{
    public class RegEx
    {
        public static bool IsPatternMatch(string regexString, string input)
        {
            Regex regex = new Regex(regexString);
            return regex.IsMatch(input);
        }
        public static string ExtractPattern(string regesString, string input)
        {
            Regex regex= new Regex(regesString);
            Match match = regex.Match(input);
            if (match.Success)
                return match.Value;
            return string.Empty;
        }
    }
}
 