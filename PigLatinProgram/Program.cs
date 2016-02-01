using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinProgram
{
    /// <summary>
    /// The Pig Latin Program will translate the sentence that you type into Pig Latin. Enjoy.
    /// By Anthony Senior II, 10/22/2015
    /// </summary>
    class PigLatin
    {
        static void Main(string[] args)
        {
            Console.Title = "Pig Latin Program";

            Console.WriteLine("Welcome to the Pig Latin Program! Press ENTER to get started. Type \"quit\" at any time to exit the program.");
            Console.ReadLine();
            Console.WriteLine();

            string sentence = "";            
            string pigWord = "";
            string vowels = "AEIOUaeiou";
            int vowelCheck;

            while (sentence.ToLower() != "quit")
            {
                Console.WriteLine("Please write a sentence that you would like to be translated into Pig Latin then press ENTER. Type \"quit\" at any time to exit the program.");
                Console.Write("Your sentence: ");
                sentence = Console.ReadLine();

                if (sentence.Length > 0)
                {
                    Console.Write("Translation: ");

                    foreach (string word in sentence.Split())
                    {
                        string firstLetter = word.Substring(0, 1);
                        string restOfWord = word.Substring(1, word.Length - 1);

                        // checks to see if the word starts with a vowel or nah
                        vowelCheck = vowels.IndexOf(firstLetter);
                        if (vowelCheck == -1)
                        {
                            // first letter in the word is a consonant
                            pigWord = restOfWord + firstLetter + "ay";
                            Console.Write("{0} ", pigWord);
                        }
                        else
                        {
                            // first letter in the word is a vowel
                            pigWord = word + "way";
                            Console.Write("{0} ", pigWord);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }//end Main

    }//end class
}//end namespace
