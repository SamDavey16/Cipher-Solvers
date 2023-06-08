using System;
using Cipher_Solver;

namespace Running
{
    class Go
    {
        static void Main(string[] args)
        {
            bool finished = false;
            while (finished == false)
            {
                Solvers s = new Solvers();
                Console.WriteLine("Would you like to encrypt (Caeser), decrypt (Caeser) or run the RSA algorithm? ");
                string answer = Console.ReadLine().ToLower();
                if (answer.Contains("encrypt") == true)
                {
                    s.Caeser_Encrypt();
                    finished = true;
                }
                else if (answer.Contains("decrypt") == true && answer.Contains("caeser") == true)
                {
                    s.Caeser_Decrypt();
                    finished = true;
                }
                else if (answer.Contains("rsa") == true)
                {
                    s.Asymetric_encryption();
                    finished = true;
                }
                else
                {
                    Console.WriteLine("That method is unavailable, please choose another");
                }
            }
        }
    }
}