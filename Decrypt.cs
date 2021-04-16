using System;
using System.Collections.Generic;
using System.Text;

namespace Encrypting_and_Decrypting
{
    class Decrypt
    {

        public static string SimpleDecipher(string input, int[] key)
        {
            string output = "";
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97) //Lowercase
                {
                    int charInt = (input[i] - key[count]);

                    if (charInt < 97)
                    {
                        charInt += 26;
                    }
                    output += (char)charInt;
                    
                }
                else
                {
                    int charInt = (input[i] - key[count]);

                    if (charInt < 65)
                    {
                        charInt += 26;
                    }
                    output += (char)charInt;
                }
            }
            return output;
        }

        public static string SecondDecipher(string input, int[] key)
        {
            string output = "";
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97) //Lowercase
                {
                    int charInt = (input[i] - key[count]);

                    if (charInt < 97)
                    {
                        charInt += 26;
                    }
                    output += (char)charInt;
                }
                else
                {
                    int charInt = (input[i] - key[count]);

                    if (charInt < 65)
                    {
                        charInt += 26;
                    }
                    output += (char)charInt;
                    
                }
                    count++;
                    if (count >= key.Length) count = 0;
            }
            return output;
        }

      //  public static string LastDecipher(string input, string key)
      //  {
      //     return Encrypt.HardCipher(-26)
      //  }
    }
}
