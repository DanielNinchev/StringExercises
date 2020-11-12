using System;

namespace FillStringWith20Symbols
{
    class Program
    {
        //Напишете програма, която чете от конзолата стринг от максимум 20 символа и ако е по-кратък го допълва отдясно със "*" до 20 символа.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            FillStringWith20Chars(text);
        }
        static void FillStringWith20Chars(string text)
        {
            if (text.Length <= 20)
            {
                text = text.PadRight(20, '*');
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Error! The text is too long!");
            }
        }
    }
}
