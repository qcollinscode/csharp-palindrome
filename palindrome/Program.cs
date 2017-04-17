
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" " + "Hello, Please enter a word\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string words = Console.ReadLine();
            Console.WriteLine("\n");
            Console.ResetColor();

            char[] charArray = words.ToCharArray();
            Array.Reverse(charArray);
            string wordRev = new string(charArray);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------");
            Console.WriteLine(" " + "Palindrome?");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;

            var result = wordRev == words;
            
            if (result == false)
            {
                Console.WriteLine("No" + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes" + "\n");
                Console.ResetColor();
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}