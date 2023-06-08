using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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

        public void Asymetric_encryption()
        {
            BigInteger p = 61;
            BigInteger q = 53;
            BigInteger phi = p * q;
            BigInteger g = GCD(p, q);
            Console.WriteLine("GCD(" + p + " , " + q
                              + ") = " + g);
            BigInteger e = E(p, q);
            Console.WriteLine("E is: " + e);
            BigInteger d = D(p, q, e);
            Console.WriteLine("D is: " + d);
            Console.WriteLine("Public Key is: (" + phi + ", " + e + ")");
        }

        public BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger remainder = a % b;
                a = b;
                b = remainder; 
            }

            return a;
        }

        public BigInteger E(BigInteger a, BigInteger b)
        {
            BigInteger phi = (a - 1) * (b - 1);
            BigInteger e = 65537;

            while(GCD(e, phi) != 1)
            {
                e++;
            }

            return e;
        }

        public static BigInteger EGCD(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            BigInteger x1, y1;
            BigInteger gcd = EGCD(b % a, a, out x1, out y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }

        public static BigInteger D(BigInteger p, BigInteger q, BigInteger e)
        {
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger d, y;
            EGCD(e, phi, out d, out y);

            // Ensure d is positive
            d = (d % phi + phi) % phi;

            return d;
        }
    }
}
