using System;

namespace Cipher_Solver
{
    class Solvers
    {
        public void Caeser_Encrypt()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Enter text to be encrypted: ");
            string txt = Console.ReadLine();
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
    }
}
