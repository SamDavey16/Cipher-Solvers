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
                if (Index + shift >= alpha.Length)
                {
                    int distance = alpha.Length - Index;
                    int sub = Index + shift - alpha.Length;
                    characters[i] = alpha[sub];
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
