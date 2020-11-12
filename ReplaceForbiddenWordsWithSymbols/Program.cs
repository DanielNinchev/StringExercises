using System;
using System.Linq;
using System.Text;

namespace ReplaceForbiddenWordsWithSymbols
{
    class Program
    {
        //Даден е символен низ, съставен от няколко "забранени" думи, разделени със запетая. Даден е и текст, съдържащ тези думи. 
        //Да се напише програма, която замества забранените думи в текста със звездички. 
        //Примерен текст: Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.
        //Примерен низ от забранените думи: "C#,CLR,Microsoft".
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string str = "C#,CLR,Microsoft";
            ReplaceForbiddenWordsWithSymbols(text, str);
        }

        static void ReplaceForbiddenWordsWithSymbols(string text, string forbiddenString)
        {
            string[] forbiddenWords = forbiddenString.Split(',');
            string[] words = text.Split(' ', '.', '!', '?');
            string forbiddenWord = null;

            for (int i = 0; i < words.Length; i++)
            {
                StringBuilder result = new StringBuilder();
                if (forbiddenWords.Contains(words[i]))
                {
                    forbiddenWord = words[i];
                    char[] ch = new char[forbiddenWord.Length];
                    for (int j = 0; j < forbiddenWord.Length; j++)
                    {
                        ch[j] = '*';
                        result.Append(ch[j]);
                    }
                    text = text.Replace(forbiddenWord, result.ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
