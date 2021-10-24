using System;

namespace Kookaburra.SDK
{
    partial class AlertData
    {
        public static readonly string NOTE_DATA = "Note";
        public static readonly string MESSAGE_DATA = "Message";
        public static readonly string WARNING_DATA = "Warning";
        public static readonly string ERROR_DATA = "Error";
        public static readonly string HELP_DATA = "Help";
    }
    /// <summary>
    /// Alert Class for the Kookaburra SDK.
    /// </summary>
    public class Alert
    {
        public Alert(string message, Type type, bool newline = true)
        {
            switch (type)
            {
                default:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Yellow");
                    Console.Write(AlertData.NOTE_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
                case Type.Note:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Yellow");
                    Console.Write(AlertData.NOTE_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
                case Type.Message:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Blue");
                    Console.Write(AlertData.MESSAGE_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
                case Type.Warning:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("DarkYellow");
                    Console.Write(AlertData.WARNING_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
                case Type.Error:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Red");
                    Console.Write(AlertData.ERROR_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
                case Type.Help:
                    if (newline)
                        Console.Write("\x0A");
                    Format.SetForegroundColor("White");
                    Console.Write("[");
                    Format.SetForegroundColor("Green");
                    Console.Write(AlertData.HELP_DATA);
                    Format.SetForegroundColor("White");
                    Console.Write("] " + message);
                    break;
            }
        }

        /// <summary>
        /// Displays an Alert.  (1. Note | 2. Message | 3. Warning | 4. Error | 5. Help | 6. Update)
        /// </summary>
        [Obsolete("Alert.Display will be removed in the next version. Use 'new Alert(\"Hello World!\", Alert.Type.Note());'")]
        public static void Display(string Message, int Style, bool NewLine = true)
        {
            switch (Style)
            {
                case 1:
                    
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


        public enum Type
        {
            Note,
            Message,
            Warning,
            Error,
            Help
        }
    }
}
