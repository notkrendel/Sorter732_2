using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _732_2
{
    public class Sort
    {

        char[] characters;
        char N;

        public Sort()
        {
            characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            N = (char)characters.Length;
        }

        public string Encrypt(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();

            string result = "";
            int keywordIndex = 0;

            foreach (char symbol in input)
            {
                if (Char.IsLetter(symbol))
                {
                    int c = (Array.IndexOf(characters, symbol) +
                             Array.IndexOf(characters, key[keywordIndex])) % N;

                    result += characters[c];
                    keywordIndex++;

                    if (keywordIndex == key.Length)
                        keywordIndex = 0;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }

        public string Decrypt(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();

            string characters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            string result = "";

            int keywordIndex = 0;

            foreach (char symbol in input)
            {
                if (Char.IsLetter(symbol))
                {
                    int p = (characters.IndexOf(symbol) + characters.Length -
                        characters.IndexOf(key[keywordIndex])) % characters.Length;

                    result += characters[p];
                    keywordIndex++;

                    if (keywordIndex == key.Length)
                        keywordIndex = 0;
                }
                else
                {
                    result += symbol;
                }
            }

            return result;
        }
    }   
}
