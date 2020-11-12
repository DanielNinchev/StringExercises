using System;
using System.Linq;

namespace PrintSentencesThatContainASpecificWord
{
    class Program
    {
        //Напишете програма, която извлича от даден текст всички изречения, които съдържат определена дума. Считаме, че изреченията са разделени едно от друго със символа ".",
        //а думите са разделени една от друга със символ, който не е буква. Примерен текст:
        //"We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Enter a chosen word:");
            string word = Console.ReadLine();
            PrintSentencesThatContainSpecificWord(text, word);
        }

        static void PrintSentencesThatContainSpecificWord(string text, string word)
        {
            string validation = "no";
            string sentence;
            string[] sentences = text.Split(".", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                sentence = sentences[i];
                string[] words = sentence.Split(' ');
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == word)
                    {
                        Console.Write($"{sentence}.");
                        validation = "yes";
                    }
                }
            }
            if (validation != "yes")
            {
                Console.WriteLine("There is no such word in the text.");
            }
            Console.WriteLine();
        }
    }
}
