using System;

namespace Kookaburra.SDK
{
    /// <summary>
    /// Alert Class for the Kookaburra SDK.
    /// </summary>
    public static class Alert
    {
        /// <summary>
        /// Displays an Alert.  (1. Note | 2. Message | 3. Warning | 4. Error | 5. Help | 6. Update)
        /// </summary>
        public static void Display(string Message, int Style, bool NewLine = true)
        {
            switch (Style)
            {
                case 1:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Yellow");
                    Console.Write("Note");
                    Format.SetForegroundColor("White");
                    Console.Write("] " + Message);
                    break;
                case 2:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Blue");
                    Console.Write("Message");
                    Format.SetForegroundColor("White");
                    Console.Write("] " + Message);
                    break;
                case 3:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("DarkYellow");
                    Console.Write("Warning");
                    Format.SetForegroundColor("White");
                    Console.Write("] " + Message);
                    break;
                case 4:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Red");
                    Console.Write("Error");
                    Format.SetForegroundColor("White");
                    Console.Write("] " + Message);
                    break;
                case 5:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Green");
                    Console.Write("Help");
                    Format.SetForegroundColor("White");
                    Console.Write("] " + Message);
                    break;
                case 6:
                    if (NewLine)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Console.Write("Update");
                    Console.Write("] " + Message);
                    break;
                default:
                    throw new Exception("Incorrect Style. Choose 1 to 6.");
            }
        }
    }
}
