using System;
using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace _31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var newtext = RemoveStartSpaces("   salam usaglar necesiz?");
            Console.WriteLine(newtext);


            int[] numbers = { -10, 20, -40, 50, -6, 48 };

            Console.WriteLine(NewArr(numbers));

        }

        //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod

        static int FindFirstNonSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }
        static string RemoveStartSpaces(string str)
        {
            string newStr = "";

            var firstIndex = FindFirstNonSpace(str);

            if (firstIndex == -1)
                return newStr;

            for (int i = firstIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
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
