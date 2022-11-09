using System;

namespace RSA
{
    internal static class Algorithm
    {
        /// <summary>
        /// Проверят число на простоту. Если число простое, то возвращает true, в противном случае false.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool simplicity(long number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Проверяет, являются ли два числа взаимо простыми. Если числа взаимо простые, то возвращает true, в противном случае false
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static bool mutualSimplicity(long firstNumber, long secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                long num = firstNumber;
                firstNumber = secondNumber;
                secondNumber = num;
            }

            if (gcd(firstNumber, secondNumber) == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Возвращает наибольший общий делитель (НОД) двух чисел
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static long gcd(long firstNumber, long secondNumber)
        {
            while (firstNumber > 0 && secondNumber > 0)
            {
                if (firstNumber > secondNumber)
                    firstNumber %= secondNumber;
                else
                    secondNumber %= firstNumber;
            }

            return firstNumber + secondNumber;
        }
    }
}
