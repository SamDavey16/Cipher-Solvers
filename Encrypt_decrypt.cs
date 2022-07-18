using System;
using System.Collections.Generic;

namespace Cipher_Solver
{
    class Solvers
    {
        public void Caeser_Encrypt()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Enter text to be encrypted: ");
            string txt = Console.ReadLine().ToUpper();
            char[] characters = txt.ToCharArray();
            Console.WriteLine("Enter shift: ");
            int shift = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < characters.Length; i++)
            {
                int Index = Array.IndexOf(alpha, characters[i]);
                if (Index + shift >= alpha.Length) // prevents going out of the range of the alphabet array
                {
                    int sub = Index + shift - alpha.Length; // goes back to the start of the alphabet and finds the index value of the original letter index + shift if shift + index exceeds 26
                    characters[i] = alpha[sub]; // Updates the array value to the new encrypted character
                }
                else
                {
                    characters[i] = alpha[Index + shift];
                }
            }
            Console.WriteLine(characters);
        }

        public void Caeser_Decrypt()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Enter text to be decrypted: ");
            string txt = Console.ReadLine().ToUpper();
            char[] characters = txt.ToCharArray();
            List<char> output = new List<char>();
            for (int shift = 0; shift < 25; shift++)
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    int Index = Array.IndexOf(alpha, characters[i]);
                    if (Index + shift >= alpha.Length) 
                    {
                        int sub = Index + shift - alpha.Length;
                        output.Add(alpha[sub]);
                    }
                    else
                    {
                        output.Add(alpha[Index + shift]);
                    }
                }
                string s = string.Concat(output);
                Console.WriteLine(s);
                output.Clear();
            }
        }

        public void Substitution_decrypt()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Enter text to be decrypted: ");
            string txt = Console.ReadLine().ToUpper();
            char[] characters = txt.ToCharArray();
            for (int x = 0; x < characters.Length; x++)
            {
                for (int i = 0; i < alpha.Length; i++)
                {
                    Console.WriteLine("magic happens");
                }
            }
        }
    }
}
