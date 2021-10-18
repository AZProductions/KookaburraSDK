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
            if (Equals(type, Type.Note()))
            {
                if (newline)
                    Console.Write("\x0A");
                Format.SetForegroundColor("White");
                Console.Write("[");
                Format.SetForegroundColor("Yellow");
                Console.Write(AlertData.NOTE_DATA);
                Format.SetForegroundColor("White");
                Console.Write("] " + message);
            }
            
            if (Equals(type, Type.Message()))
            {
                if (newline)
                    Console.Write("\x0A");
                Format.SetForegroundColor("White");
                Console.Write("[");
                Format.SetForegroundColor("Blue");
                Console.Write(AlertData.MESSAGE_DATA);
                Format.SetForegroundColor("White");
                Console.Write("] " + message);
            }
            
            if (Equals(type, Type.Warning()))
            {
                if (newline)
                    Console.Write("\x0A");
                Format.SetForegroundColor("White");
                Console.Write("[");
                Format.SetForegroundColor("DarkYellow");
                Console.Write(AlertData.WARNING_DATA);
                Format.SetForegroundColor("White");
                Console.Write("] " + message);
            }
            
            if (Equals(type, Type.Error()))
            {
                if (newline)
                    Console.Write("\x0A");
                Format.SetForegroundColor("White");
                Console.Write("[");
                Format.SetForegroundColor("Red");
                Console.Write(AlertData.ERROR_DATA);
                Format.SetForegroundColor("White");
                Console.Write("] " + message);
            }
            
            if (Equals(type, Type.Help()))
            {
                if (newline)
                    Console.Write("\x0A");
                Format.SetForegroundColor("White");
                Console.Write("[");
                Format.SetForegroundColor("Green");
                Console.Write(AlertData.HELP_DATA);
                Format.SetForegroundColor("White");
                Console.Write("] " + message);
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


        public struct Type
        {
            public Type(string test)
            {

            }

            public static Type Message()
            {
                return new Type(AlertData.MESSAGE_DATA);
            }

            public static Type Note()
            {
                return new Type(AlertData.NOTE_DATA);
            }

            public static Type Warning()
            {
                return new Type(AlertData.WARNING_DATA);
            }

            public static Type Error()
            {
                return new Type(AlertData.WARNING_DATA);
            }
            
            public static Type Help()
            {
                return new Type(AlertData.HELP_DATA);
            }
        }
    }
}
