using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] {' ', ',','.','?','\t','\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            
            return str[0].ToString().ToUpper() + str.Substring(1);
        }

        public static string Decapitalize(this String str)
        {

            return str[0].ToString().ToLower() + str.Substring(1);
        }

        public static string Titlize(this String title)
        {
            List<string> article = new List<string>()
            {
                "a","an","the"
            };
            List<string> parts = new List<string>(title.Split(" "));
            string first = parts[0];
            if (article.Contains(parts[0].ToLower()))
            {
                parts.RemoveAt(0);
                parts.Add(", ");
                parts.Add(first);
                first = parts[0];
                while (article.Contains(first.ToLower()))
                {
                    parts.RemoveAt(0);
                    parts.Add(" ");
                    parts.Add(first);
                    first = parts[0];
                }
            }
            string result = "";
            foreach(string part in parts)
            {
                result += part + " ";
            }
            return result;
        }
    }
}
