using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{
    public class CesarEncryptor
    {
        private string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private char[] newAlphabet = new char[33];

        public string toEncrypt(string Message)
        {
            string res = "";
            foreach (char ch in Message)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (ch == alphabet[i])
                    {
                        res += newAlphabet[i];
                        break;
                    }
                }
            }
            return res;
        }

        public string toDecrypt(string Message)
        {
            string res = "";
            foreach (char ch in Message)
            {
                for (int i = 0; i < newAlphabet.Length; i++)
                {
                    if (ch == newAlphabet[i])
                    {
                        res += alphabet[i];
                        break;
                    }
                }
            }
            return res;
        }

        public void createNewAlphapet(string keyWord, int key) // создаёт новый алфавит с помощью ключа
        {
            bool findSame = false;
            key=(((key--) % 33) + 33) % 33;
            int beg = 0, current = key;
            // добавить ключевое слово в новый алфавит
            for (int i = key; i < keyWord.Length + key; i++)
            {
                for (int j = key; j < keyWord.Length + key; j++)
                {
                    if (keyWord[i - key] == newAlphabet[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)// если повторений нету, то буква добавляется в новый алфавит
                {
                    newAlphabet[current] = keyWord[i - key];
                    current++;
                }
                findSame = false;
            }

            // добавить буквы после ключевого слова
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < newAlphabet.Length; j++)
                {
                    if (alphabet[i] == newAlphabet[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newAlphabet[current] = alphabet[i];
                    current++;
                }
                findSame = false;
                if (current == newAlphabet.Length)
                {
                    beg = i;
                    break;
                }
            }
            current = 0;
            for (int i = beg; i < alphabet.Length; i++)
            {
                for (int j = 0; j < newAlphabet.Length; j++)
                {
                    if (alphabet[i] == newAlphabet[j])
                    {
                        findSame = true;
                        break;
                    }
                }
                if (!findSame)
                {
                    newAlphabet[current] = alphabet[i];
                    current++;
                }
                findSame = false;
            }
        }

        public string getNewAlpha()
        {
            string strNewAlpha = new string(newAlphabet);
            return strNewAlpha;
        }
    }
}
