using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace _31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var newtext = RemoveStar("   salam usaglar necesiz?");
            Console.WriteLine(newtext);


            int[] numbers = { -10, 20, -40, 50, -6, 48 };

            Console.WriteLine(NewArr(numbers));

        }

        //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod

        static string RemoveStar(string text)
        {
            string word = "";
            int count = 0;

            for (int i = count; i < text.Length; i++)
            {
                if (text[i] ! == ' ')
                {
                    break;
                }
                else
                {
                    word += text[i];
                }
                for (i = count; i < text.Length; i++)
                {
                    if (text[i]! == ' ')
                    {
                        word += text[i];
                    }


                }





            }

            return word;

        }

        // Verilmiş ədədlər siyahısından yalnız müsbət ədədlərindən ibarət yeni bir array düzəldib qaytaran metod


        static int NewArr(int[] numbers)
        {
            int newnumb = 0;



            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    newnumb += numbers[i];
                }

            }
            return newnumb;
        }

    }
}
