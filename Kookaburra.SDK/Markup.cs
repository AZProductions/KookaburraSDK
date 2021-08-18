using System;
using System.Collections.Generic;

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
        /// <summary>
        /// Sets the foreground color to the specified string.
        /// </summary>
        public static void SetForegroundColor(string Color)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Color);
        }
        /// <summary>
        /// Sets the background color to the specified string.
        /// </summary>
        public static void SetBackgroundColor(string Color)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Color);
        }
        /// <summary>
        /// Sets the foreground color to the specified ConsoleColor.
        /// </summary>
        public static void SetForeground(ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
        }
        /// <summary>
        /// Sets the background color to the specified ConsoleColor.
        /// </summary>
        public static void SetBackground(ConsoleColor Color)
        {
            Console.BackgroundColor = Color;
        }
        /// <summary>
        /// Creates a blank line.
        /// </summary>
        public static void WhiteSpace()
        {
            Console.WriteLine(Environment.NewLine);
        }
        /// <summary>
        /// Creates a blank line using ANSI charaters. '\x0A'
        /// </summary>
        public static void WhiteSpaceANSI()
        {
            Console.Write("\x0A");
        }
        /// <summary>
        /// Removes the first character from string and returns it.
        /// </summary>
        public static string RemoveFirstChar(string Value) 
        {
            return Value.Remove(0, 1);
        }
        /// <summary>
        /// Removes the last character from string and returns it.
        /// </summary>
        public static string RemoveLastChar(string Value)
        {
            return Value.Remove(Value.Length - 1);
        }
        /// <summary>
        /// Clears the terminal window and resets the colors.
        /// </summary>
        public static void Reset()
        {
            Console.WriteLine("\x1b[3J");
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Clears the terminal window using ANCI characters.
        /// </summary>
        public static void Clear()
        {
            Console.WriteLine("\x1b[3J");
            Console.Clear();
        }
        /// <summary>
        /// Returns the coorinates of the console cursor.
        /// </summary>
        public static Tuple<int, int> GetPos()
        {
            return Tuple.Create(Console.CursorTop, Console.CursorLeft);
        }
        /// <summary>
        /// Sets the coorinates of the console cursor.
        /// </summary>
        public static void SetPos(int top, int left)
        {
            Console.CursorTop = top;
            Console.CursorLeft = left;
        }
        /// <summary>
        /// Splits the string and removes the part where it got splitted.
        /// </summary>
        public static string[] SplitAndRemove(string Value, string SplitValue) 
        {
            var ListValue = new List<string>(Value.Split(SplitValue));
            ListValue.Remove(SplitValue);
            return ListValue.ToArray();
        }
    }
}
