using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace ReverseWordsInAText
{
    class Program
    {
        //Напишете програма, която обръща думите в дадено изречение без да променя пунктуацията и интервалите.Например: "C# is not C++ and PHP is not Delphi" → "Delphi not is PHP and C++ not is C#".
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            ReverseWordsInText(text);

        }
        static void ReverseWordsInText(string text)
        {
            char[] punctuation = { '!', '?', ';', ':', ',', '.', '/', '|', '\\' };
            //string[] reversedWords = new string[words.Length];
            StringBuilder reversedWords = new StringBuilder();
            char endingSymbol = '.';
            for (int i = 0; i < punctuation.Length; i++)
            {
                if (text.EndsWith(punctuation[i]))
                {
                    endingSymbol = text[text.Length - 1];
                    text = text.Remove(text.Length - 1);
                }
            }
            string[] words = text.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {   
                reversedWords.Append(words[i] + " ");
            }
            string reversedText = reversedWords.ToString().Trim();
            reversedText = string.Concat(reversedText, endingSymbol);
            Console.WriteLine(reversedText);
        }
    }
}
