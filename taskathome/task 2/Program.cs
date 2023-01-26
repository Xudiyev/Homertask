using System;
using System.Globalization;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Verilmiş 3 ədədən ən böyüyünü tapan proqram
            int num1 = 10;
            int num2 = 50;
            int num3 = 100;

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("num1 boyukdur num2 ve num3 den!");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("num2 boyukdur num 1 ve num 3 den!");
            }
            else
            {
                Console.WriteLine("num3 boyukdur num 1 ve num 2 den!");
            }

            #endregion
            #region Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram
            //int[] numbers = { 10, 54, 300,500 };
            //int maxNumber = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    if (numbers[i] > maxNumber )
            //    {
            //        maxNumber = numbers[i];

            //    }

            //}
            //Console.WriteLine(maxNumber);
            #endregion
            #region Verilmiş ədələr siyahısında mənfi ədəd olub olmadığını tapan proqram
            //int[] numbers1 = { 5, 15, 25, 60 };
            //int count = 0;
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    if (numbers1[i] < 0)
            //    {
            //        Console.WriteLine("menfi eded var!");
            //        count++;
            //        break;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("menfi eded yoxdur");
            //}
            #endregion















        }
    }
}
