using System;
using System.Collections.Generic;
namespace MyLibrary
{
    public class Menu
    {
        private List<string> _items = new List<string>();
        public string Title { get; set; }

        public Menu(string title, List<string> items)
        {
            Title = title;
            items = _items;
        }

        public void Display(bool displayTitle = true)
        {
            if (displayTitle)
            {
                Console.WriteLine(UI.TitleCase($"{Title}"));
                Console.WriteLine(UI.doubleLines);
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int i = 0; i < _items.Count; i++)
            {

                Console.WriteLine(UI.TitleCase($"[{i + 1}]  {_items[i]}"));
            }

            Console.WriteLine("");
        }

    }
}
