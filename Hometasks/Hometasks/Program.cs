using System;
using System.Runtime.Intrinsics.X86;

namespace Hometasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first program
            //Console.WriteLine("1 ci Ededi daxil ele");
            //string input = Console.ReadLine();
            //int number1 = Convert.ToInt32(input);

            //Console.WriteLine("2 ci Ededi daxil ele");
            //string input2 = Console.ReadLine();
            //int number2 = Convert.ToInt32(input2);

            //string output = "Netice" + number1 + number2;
            //output = $"{number1}+{number2} = {number1 + number2}";


            //Console.WriteLine(output);

            //var sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum += i;
            //}
            //sum = 0;
            //var num = 3;
            //while (num <= 100)
            //{
            //    sum += num;
            //    num += 3;

            //}
            //int[] numbers = new int[] { 5, 10, 35, -8, };
            //sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        break;      
            //    }
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region fromnumber den tonumbere geder olan deyerlerin cemini tapan!
            //var sum = 0;
            //Console.WriteLine("Baslangic deyerini daxil et!");
            //var fromNumberstring = Console.ReadLine();
            //int fromNumber = Convert.ToInt32(fromNumberstring);

            //string toNumberStr;
            //int toNumber;
            //do
            //{
            //    Console.WriteLine("Bitme deyerini daxil et:");
            //     toNumberStr = Console.ReadLine();
            //     toNumber = Convert.ToInt32(toNumberStr);
            //}
            //while (fromNumber >= toNumber);



            //for (int i = fromNumber; i < toNumber; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            Console.WriteLine("Heftenin gununu daxil edin:");
            var dayStr = Console.ReadLine();
            int day = Convert.ToInt32(dayStr);

            if (day == 1)
            {
                Console.WriteLine("Bazar ertesi");
            }
            else if (day == 2)
            {
                Console.WriteLine("Cersenbe axsami");
            }
            else if (day == 3)
            {
                Console.WriteLine("Cersenbe");
            }
            else if (day == 4)
            {
                Console.WriteLine("Cume axsami");
            }
            else if (day == 5)
            {
                Console.WriteLine("Cume");
            }
            else if (day == 6)
            {
                Console.WriteLine("Senbe");
            }
            else if (day == 7)
            {
                Console.WriteLine("Bazar ");
            }
            else
            {
                Console.WriteLine("Heftenin gunu sef daxil edilmisdir!");
            }
            switch (day)
            {
                //case 1:
                //    Console.WriteLine("Bazar ertesi");
                //    break;
                //case 2:
                //    Console.WriteLine("Cersenbe axsami");
                //    break;
                //case 3:
                //    Console.WriteLine("Cersenbe");
                //    break;
                //case 4:
                //    Console.WriteLine("Cume axsami");
                //    break;
                //case 5:
                //    Console.WriteLine("Cume");
                //    break;
                //case 6:
                //    Console.WriteLine("Heftesonu");
                //    break;
                //case 7:
                //    goto case 6;
                //default:
                //    Console.WriteLine("Yanlisdir!");
                //    break;

            }




        }


    }


}
