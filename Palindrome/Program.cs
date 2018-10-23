namespace Palindrome
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter something to check if it is a Palindrome");
            string textToCheck = Console.ReadLine();

            var charsToCheck = new List<char>();

            foreach (char item in textToCheck)
            {
                if (item != ' ')
                {
                    charsToCheck.Add(item);
                }
            }

            string trimmedCharsToCheck = "";
            foreach (var item in charsToCheck)
            {
                trimmedCharsToCheck = trimmedCharsToCheck + item.ToString();
            }

            string reverseTextToCheck = "";

            for (int i = charsToCheck.Count; i > 0; )
            {
                reverseTextToCheck = reverseTextToCheck + charsToCheck[--i];
            }

            if (reverseTextToCheck.ToLower() == trimmedCharsToCheck.ToLower())
            {
                Console.WriteLine(textToCheck + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(textToCheck + " is not a Palindrome!");
            }

            Console.ReadKey();
        }
    }
}
