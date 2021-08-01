using System;

namespace Check_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter List of space seprated words");
            string[] words = Console.ReadLine().Split(' ');
            foreach(string str in words)
            {
                string word = str.ToLower();
                int length = word.Length;
                bool isPalindrome = true;
                for (int i = 0; i < length / 2; i++)
                {
                    if (word[i] != word[length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine("\n" + word + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("\n" + word + " is not a Palindrome!");
                }
            }
        }
    }
}
