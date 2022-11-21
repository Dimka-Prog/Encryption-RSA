using System;
using System.Collections.Generic;
using System.Numerics;

namespace RSA
{
    public class Encryption
    {
        public string encryptedMessage = "";
        public List<long> listUnicode = new List<long>();
        private readonly KeyGeneration keyGeneration;

        public Encryption(KeyGeneration keyGeneration, string message)
        {
            this.keyGeneration = keyGeneration;
            encryptedMessage = getASCII(message);
        }


        /// <summary>
        /// Возвращает строку содержающую код (ASCII) зашифрованного сообщения.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string getASCII(string message)
        {
            string encodedMessage = "";

            foreach (char symbol in message)
            {
                long unicode = symbol;

                if (!(unicode < keyGeneration.compositionPQ)) throw new Exception("Ошибка шифрования! Произведение p и q меньше значения входного сообщения.");
                {
                    unicode = (long)BigInteger.ModPow(unicode, keyGeneration.e, keyGeneration.compositionPQ);

                    listUnicode.Add(unicode);
                    encodedMessage += unicode.ToString();
                }
            }
            return encodedMessage;
        }
    }
}
