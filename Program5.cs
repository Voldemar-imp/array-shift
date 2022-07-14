using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySise = 30;
            int[] numbersArray = new int[arraySise];
            int randomMin = 0;
            int randomMax = 30;
            int firstNumber;
            int userInput;
            Random random = new Random();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = random.Next(randomMin, randomMax);
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine("- массив");
            Console.WriteLine("Введите насколько позиций нужно сдвинуть массив влево");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                firstNumber = numbersArray[0];
                
                for (int j =  0; j < arraySise-1; j++)
                {
                    numbersArray[j] = numbersArray[j + 1];                   
                }
                
                numbersArray[arraySise - 1] = firstNumber;
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine("- массив смещенный на {0} позиций влево", userInput);
        }
    }
}
