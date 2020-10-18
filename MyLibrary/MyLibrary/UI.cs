using System;
using System.Globalization;

namespace MyLibrary
{
    public class UI
    {
        public static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        public static ConsoleColor currentBackgroundColor = Console.BackgroundColor;
        public static ConsoleColor currentForegroundColor = Console.ForegroundColor;
        public static string doubleLines = "============================================";
        public static string separator = "---------------------------";
        private static TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        public static void Footer(string footerText)
        {
            Console.WriteLine($"{doubleLines}");
            Console.WriteLine($"{footerText}");
        }

        public static void Header(string headerText)
        {
            Console.WriteLine($"{headerText.ToUpper()}");
            Console.WriteLine($"{doubleLines}");
        }

        public static void ColoredAlert(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);

            Console.ResetColor();
        }

        public static void Separator()
        {
            Console.WriteLine(separator);
        }

        public static string TitleCase(string text)
        {
            text = myTI.ToTitleCase(text);
            return text;
        }
    }
}
