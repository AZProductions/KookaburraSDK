using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Markup Class for the Kookaburra SDK.
    /// </summary>
    public static class Markup
    {
        /// <summary>
        /// Returns True if the string start with a uppercase letter.
        /// </summary>
        public static bool StartsWithUpper(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
        /// <summary>
        /// Returns True if the string start with a lowercase letter.
        /// </summary>
        public static bool StartsWithLower(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsLower(ch);
        }
        /// <summary>
        /// Returns a lowercase version of the string.
        /// </summary>
        public static string ToLower(string Value) 
        {
            return Value.ToLower();
        }
        /// <summary>
        /// Returns an uppercase version of the string.
        /// </summary>
        public static string ToUpper(string Value) 
        {
            return Value.ToUpper();
        }
        /// <summary>
        /// Returns True if the selected string is in the array.
        /// </summary>
        public static bool IsInArray(string[] List, string Value) 
        {
            bool Return = false;
            foreach (string Array in List)
            {
                if (Array == Value)
                    Return = true;
            }
            return Return;
        }
        /// <summary>
        /// Returns True if the selected int is in the array.
        /// </summary>
        public static bool IsInIntArray(int[] List, int Value)
        {
            bool Return = false;
            foreach (int Array in List)
            {
                if (Array == Value)
                    Return = true;
            }
            return Return;
        }
        /// <summary>
        /// Deletes specified character from the string and returns it.
        /// </summary>
        public static string DeleteChar(char Char, string Value)
        {
            return Value.Replace(Char, '\0');
        }
        /// <summary>
        /// Deletes specified charaters (string) from the string and returns it.
        /// </summary>
        public static string DeleteString(string Remove, string Value)
        {
            return Value.Replace(Remove, string.Empty);
        }
    }
}
