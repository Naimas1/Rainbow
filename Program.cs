using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    class Programt
    {
        static void Main()
        {
            string text = "Hello, world!";
            string word = "world";

            Func<string, string, bool> checkWord = (text, word) =>
            {
                return text.Contains(word);
            };

            bool result = checkWord(text, word);
            Console.WriteLine($"Текст містить слово '{word}': {result}");
        }
    }
}
