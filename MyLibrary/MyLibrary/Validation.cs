using System;
using System.Collections.Generic;
namespace MyLibrary
{
    public class Validation
    {
        public static string Contains(string input, List<string> items)
        {
            while (!(items.Contains(input.ToLower())))
            {
                UI.ColoredAlert("That was not an option. Please try again: ", ConsoleColor.DarkRed);
                input = Console.ReadLine().ToLower();
            }
            return input;
        }

        public static int Convert(List<string> items, string input)
        {
            int selection = items.IndexOf(input);

            return selection + 1;
        }

        public static int GetChoice(List<string> items, string message = "Enter your selection...")
        {
            UI.Separator();
            string input = Required($"{message}", false);

            int choice;

            if (IsInt(input))
            {
                choice = Range(input, 0, items.Count);
                return choice;
            }
            else
            {
                Contains(input.ToLower(), items);
                choice = Convert(items, input);
                return choice;
            }
        }

        public static bool IsInt(string input)
        {
            int number;
            bool isInt = int.TryParse(input, out number);

            return isInt;
        }

        public static int Range(string input, int min, int max)
        {
            int number;

            while (!(Int32.TryParse(input, out number)) || number > max || number < min)
            {
                UI.ColoredAlert("Please enter a number within range:  ", ConsoleColor.DarkRed);
                input = Console.ReadLine();
            }
            return number;
        }

        public static string Required(string message, bool toTitleCase = true)
        {
            Console.Write(message);
            string value = Console.ReadLine().ToLower();
            while (String.IsNullOrWhiteSpace(value))
            {
                UI.ColoredAlert("This cannot be left blank. Please try again: ", ConsoleColor.DarkRed);
                value = Console.ReadLine().ToLower();
            }

            if (toTitleCase)
            {
                value = UI.TitleCase(value);
            }

            return value;
        }

        public static void Wait()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
