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

            foreach (var code in listUnicode)
                message += Convert.ToChar((long)BigInteger.ModPow(code, (int)keyGeneration.d, keyGeneration.compositionPQ));

            return message;
        }
    }
}
