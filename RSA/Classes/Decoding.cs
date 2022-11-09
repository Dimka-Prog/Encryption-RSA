using System;
using System.Collections.Generic;
using System.Numerics;

namespace RSA
{
    public class Decoding
    {
        public string decryptedMessage = "";
        KeyGeneration keyGeneration;

        public Decoding(KeyGeneration keyGeneration, Encryption encryption)
        {
            this.keyGeneration = keyGeneration;

            decryptedMessage = decodingMessage(encryption.listUnicode);
        }

        /// <summary>
        /// Принимает List содержащий код зашифрованного сообщения и декодирует его, возвращая строку с сообщением.
        /// </summary>
        /// <param name="listUnicode"></param>
        /// <returns></returns>
        private string decodingMessage(List<long> listUnicode)
        {
            string message = "";
            long symbol;

            foreach (var code in listUnicode)
            {
                symbol = code;
                for (long i = 0; i < keyGeneration.d; i++)
                {
                    symbol %= keyGeneration.compositionPQ;
                    if (i != keyGeneration.d - 1)
                    {
                        symbol *= code;
                    }
                }
                message += Convert.ToChar((int)symbol); //(BigInteger.Pow(code, (int)keyGeneration.d) % keyGeneration.compositionPQ)
            }
            
            return message;
        }
    }
}
