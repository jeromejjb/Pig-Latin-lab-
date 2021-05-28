using System;

namespace Pig_Latin_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a line to be translated:");
            string sentence = Console.ReadLine();
            string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(pigLatin.ToLower());

        }

        static string ToPigLatin(string sentence)
        {

            while (true)
            {
                const string vowels = "AEIOUaeio";
                System.Collections.Generic.List<string> pigWords = new System.Collections.Generic.List<string>();
                foreach (string word in sentence.Split(' '))
                {
                    string firstLetter = word.Substring(0, 1);
                    string restOfWord = word.Substring(1, word.Length - 1);
                    int currentLetter = vowels.IndexOf(firstLetter);

                    if (currentLetter == -1)
                    {
                        pigWords.Add(restOfWord + firstLetter + "ay");
                    }
                    else
                    {
                        pigWords.Add(word + "way");
                    }
                }
                return string.Join(" ", pigWords);
            }
            Console.WriteLine("Would you like to continue? y/n");
            
        }
        
    }

}
