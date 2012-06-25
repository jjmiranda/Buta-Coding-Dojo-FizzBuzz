using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata001FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ":" + FizzBuzz(i));
            }
            Console.ReadLine();
        }

        public static string FizzBuzz (int numero)
        {
            string retorno = numero.ToString();
            if (numero % 3 == 0) retorno = "Fizz";
            if (numero % 5 == 0) retorno = "Buzz";
            if ((numero % 3 == 0) && (numero % 5 == 0)) retorno = "FizzBuzz";

            return retorno;
        }
    }
}
