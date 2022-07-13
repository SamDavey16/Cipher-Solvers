using System;
using Cipher_Solver;

namespace Running
{
    class Go
    {
        static void Main(string[] args)
        {
            Solvers s = new Solvers();
            Console.WriteLine("Would you like to encrypt or decrypt? ");
            string answer = Console.ReadLine();
            if (answer == "encrypt")
            {
                s.Caeser_Encrypt();
            }
            else
            {
                s.Caeser_Decrypt();
            }
        }
    }
}