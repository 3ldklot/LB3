using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public class Polubius
    {
        private string _decryptedMessage = "";
        private string _encryptedMessage = "";
        private char[,] alfrus = {     {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                   {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                   {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                   {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                   {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                   { '2','3', '4', '5', '6', '7', '8'},
                                   {'9', ' ', ',', '.', '!', '?', ';'}
                               };
        public Polubius(string Message)
        { 
            _decryptedMessage = Message;
            _encryptedMessage = Message;
        }
        public string toEncryptMessage() 
        {
            _encryptedMessage = "";
            for (int i = 0; i < _decryptedMessage.Length; i++)
            {
                for (int j = 0; j < alfrus.GetLength(0); j++)
                    for (int k = 0; k < alfrus.GetLength(1); k++)
                        if (Char.ToLower(alfrus[j, k]) == _decryptedMessage[i] || Char.ToUpper(alfrus[j, k]) == _decryptedMessage[i])
                        {
                            _encryptedMessage += (Convert.ToString(j) + Convert.ToString(k));
                            break;
                        }
            }
            return _encryptedMessage;
        }
        public string toDecryptMessage() 
        {
            _decryptedMessage = "";
            for (int a = 0; a < _encryptedMessage.Length; a += 2)
            {
                _decryptedMessage += alfrus[Convert.ToInt32(_encryptedMessage[a].ToString()), Convert.ToInt32(_encryptedMessage[a + 1].ToString())];
            }
            return _decryptedMessage;
        }
    }
}
