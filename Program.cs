using System;

namespace Encrypting_and_Decrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            StarterMenu();         
        }

        public static void StarterMenu() 
        {
            string[] choices = { "Simple Cipher (Easiest to crack)", "Less Simple Cipher (Kinda hard to crack)", "Not so Simple Cipher (Hardest to crack)" };

            Console.WriteLine("\nUse the Arrow keys to navigate through the menu and press Enter to select.\n" +
                "User Arrow keys to cycle through options.\n");

            Menu menu = new Menu(Title(), choices);
            int selectedIndex = menu.MainMenu();

            switch (selectedIndex)
            {
                case 0:
                    CallSimpleCipher();
                    break;
                case 1:
                    CallLessSimpleCipher();
                    break;
                case 2:
                    CallNotSoSimpleCipher();
                    break;
            }
        }

        public static Tuple<string,string> SubMenu()
        {
            Console.Clear();
            Console.WriteLine(Title());
            Console.WriteLine();

            Console.Write("Type a word to encrypt: ");
            string UserString = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter your Key: ");
            string key = Console.ReadLine();
            Tuple<string, string> tuple = new Tuple<string, string>(UserString, key);
            return tuple;
        }

        public static void CallSimpleCipher()
        {
            var userChoice = SubMenu();
            
            string cipherText = Encrypt.SimpleCipher(userChoice.Item1, Encrypt.MakeKey(userChoice.Item2));
            Console.WriteLine($"Encrypted Data: {cipherText}");

            Console.WriteLine();

            string decipherText = Decrypt.SimpleDecipher(cipherText, Encrypt.MakeKey(userChoice.Item2));
            Console.Write($"Decrypted Data: {decipherText}");

            Console.ReadKey();
        }

        public static void CallLessSimpleCipher()
        {
            var userChoice = SubMenu();

            string cipherText = Encrypt.NotSoSimpleCipher(userChoice.Item1, Encrypt.MakeKey(userChoice.Item2));
            Console.WriteLine($"Encrypted Data: {cipherText}");

            Console.WriteLine();

            string decipherText = Decrypt.SecondDecipher(cipherText, Encrypt.MakeKey(userChoice.Item2));
            Console.Write($"Decrypted Data: {decipherText}");

            Console.ReadKey();
        }

        public static void CallNotSoSimpleCipher()
        {
            var userChoice = SubMenu();

            string cipherText = Encrypt.NotSoSimpleCipher(userChoice.Item1, Encrypt.MakeKey(userChoice.Item1, userChoice.Item2));
            Console.WriteLine($"Encrypted Data: {cipherText}");

            Console.WriteLine();

            string decipherText = Decrypt.SecondDecipher(cipherText, Encrypt.MakeKey(userChoice.Item1, userChoice.Item2));
            Console.Write($"Decrypted Data: {decipherText}");
            Console.ReadKey();
        }

        public static string Title()
        {
            return  @"╔═══╗──────────────╔╗────────────────╔╗╔═══╗──────────────╔╗────────╔═╗╔═╗
║╔══╝─────────────╔╝╚╗───────────────║║╚╗╔╗║─────────────╔╝╚╗───────║║╚╝║║
║╚══╦═╗╔══╦═╦╗─╔╦═╩╗╔╬╦═╗╔══╗╔══╦═╗╔═╝║─║║║╠══╦══╦═╦╗─╔╦═╩╗╔╬╦═╗╔══╗║╔╗╔╗╠══╦══╦══╦══╦══╦══╦══╗
║╔══╣╔╗╣╔═╣╔╣║─║║╔╗║║╠╣╔╗╣╔╗║║╔╗║╔╗╣╔╗║─║║║║║═╣╔═╣╔╣║─║║╔╗║║╠╣╔╗╣╔╗║║║║║║║║═╣══╣══╣╔╗║╔╗║║═╣══╣
║╚══╣║║║╚═╣║║╚═╝║╚╝║╚╣║║║║╚╝║║╔╗║║║║╚╝║╔╝╚╝║║═╣╚═╣║║╚═╝║╚╝║╚╣║║║║╚╝║║║║║║║║═╬══╠══║╔╗║╚╝║║═╬══║
╚═══╩╝╚╩══╩╝╚═╗╔╣╔═╩═╩╩╝╚╩═╗║╚╝╚╩╝╚╩══╝╚═══╩══╩══╩╝╚═╗╔╣╔═╩═╩╩╝╚╩═╗║╚╝╚╝╚╩══╩══╩══╩╝╚╩═╗╠══╩══╝
────────────╔═╝║║║───────╔═╝║──────────────────────╔═╝║║║───────╔═╝║─────────────────╔═╝║
────────────╚══╝╚╝───────╚══╝──────────────────────╚══╝╚╝───────╚══╝─────────────────╚══╝";
        }


    }
}
