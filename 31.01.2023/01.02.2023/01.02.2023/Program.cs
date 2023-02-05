using System;
using System.Security.Cryptography.X509Certificates;

namespace _01._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add new value
            //    int[] number = { 21, 7, 5, };

            //    var result = Add(number,10);
            //    Console.WriteLine(result);


            //}

            //static int[] Add(int[] numbers,int value)
            //{

            //    int[] newArr= new int[numbers.Length+1 ];

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        newArr[i] = numbers[i];
            //    }

            //    newArr[numbers.Length-1] = value;

            //    return newArr;

            #endregion

            #region SetZero
            //    int num = 45;
            //    SetZero(ref num);
            //    Console.WriteLine(num);

            //    string num1 = "33";
            //    SetZero(ref num1);
            //    Console.WriteLine(num1);

            //    int[] number = { 1, 4, 5, 7 };
            //    SetZero(  number);
            //    Console.WriteLine(number[0]);
            //}


            //static void SetZero(ref int num)
            //{
            //    num= 23;
            //}

            //static void SetZero( ref string num1)
            //{
            //    num1 = "56";
            //}

            //static void SetZero(  int[] num)
            //{

            //    num[0] = 39;
            //}
            #endregion


            // Verilmiş yazıda rəqəm olub olmadığını tapan metod.Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır.

            string text = " 6 salam necesen?";
            FindNumber(text,6);
            Console.WriteLine(FindNumber(text,6));


        }

        static bool FindNumber(string text,int value)
        {
           
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] ==6)
                {
                    return true;
                }
            }
            return false;

        }
        

    }
}
