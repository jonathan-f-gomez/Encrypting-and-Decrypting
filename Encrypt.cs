using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypting_and_Decrypting
{
    class Encrypt
    {
        public static int[] MakeKey(string input)
        {
            int[] output = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] >= 97) //Checks Lowercase
                {
                    output[i] = (int)input[i] - 96;
                }
                else
                {
                    output[i] = (int)input[i] - 64;
                }                
            }
            return output;
        }
        public static int[] MakeKey(string userPlainText /*catjonat*/, string userKey) //cat
        {
            //the key is .length of the user plaintext

            //int[] key = new int[userPlainText.Length];

            int[] output = new int[userPlainText.Length];

            for (int i = 0; i < userKey.Length; i++)
            {
                if ((int)userKey[i] >= 97) //Checks Lowercase
                {
                    output[i] = (int)userKey[i] - 96;
                }
                else
                {
                    output[i] = (int)userKey[i] - 64;
                }
            }

            for (int i = 0; i < userPlainText.Length - userKey.Length; i++)
            {
                if ((int)userPlainText[i] >= 97) //Checks Lowercase
                {
                    output[i + userKey.Length] = (int)userPlainText[i] - 96;
                }
                else
                {
                    output[i + userKey.Length] = (int)userPlainText[i] - 64;
                }
            }
            return output;
        }

        public static string SimpleCipher(string input, int[] key)
        {
            string output = "";
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97 ) //Lowercase
                {
                    int charInt = (input[i] + key[count]);

                    if (charInt > 122)
                    {
                        charInt -= 26;
                    }
                    output += (char)charInt;
                }
                else
                {
                    int charInt = (input[i] + key[count]);

                    if (charInt > 90)
                    {
                        charInt -= 26;
                    }                    
                    output += (char)charInt;
                }
            }
            return output;
        }
        
        public static string NotSoSimpleCipher(string input, int[] key)
        {
            string output = "";
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97) //Lowercase
                {
                    int charInt = (input[i] + key[count]);

                    if (charInt > 122)
                    {
                        charInt -= 26;
                    }
                    output += (char)charInt;
                }
                else
                {
                    int charInt = (input[i] + key[count]);

                    if (charInt > 90)
                    {
                        charInt -= 26;
                    }
                    output += (char)charInt;
                }
                count++;
                if (count >= key.Length) count = 0;
            }
            return output;


            //for (int i = 0; i < input.Length; i++)
            //{
            //    int x = (input[i] + key[count]);

            //    output += (char)(x);
            //    count++;
            //    if (count >= key.Length) count = 0;
            //}
            //return output;
        }
    }
}
