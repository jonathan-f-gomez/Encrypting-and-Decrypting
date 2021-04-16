using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypting_and_Decrypting
{
    class Menu
    {
        private int SelectedIndex;
        private string Title;
        private string[] Options;

        public Menu(string title, string[] options)
        {
            this.Title = title;
            this.Options = options;
            this.SelectedIndex = 0; //Sets the default select value in the array to 0
        }

        //How the options that the user can select are displayed
        private void DisplayOptions()
        {
            Console.WriteLine(Title);
            Console.WriteLine();

            for (int i = 0; i < Options.Length; i++)
            {
                string prefix;
                string currentOption = Options[i];


                if (i == SelectedIndex)
                {
                    prefix = ">> ";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = "   ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}{currentOption}");
            }
            Console.ResetColor();
        }
        public int MainMenu()
        {
            ConsoleKey consoleKey;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;

                if (consoleKey == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1) SelectedIndex = Options.Length - 1;
                }
                else if (consoleKey == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length) SelectedIndex = 0;
                }
            } while (consoleKey != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
