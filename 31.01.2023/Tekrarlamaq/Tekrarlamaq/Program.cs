using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Tekrarlamaq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region consol yazmag consoldan almaq
            //Console.WriteLine("1 ci ededi daxil ele");
            //string input = Console.ReadLine();
            // var number=Convert.ToInt32(input);

            //Console.WriteLine("2 ci ededi daxil ele");
            //string input2= Console.ReadLine();
            //var number2= Convert.ToInt32(input2);

            //var output = "Netice="+(number+number2);
            //output = number + "+" + number2 + "=" + (number + number2);
            //output = $"{number}+{number2}={number+number2}";

            //Console.WriteLine(output);
            #endregion

            #region  baslangic deyer bitme deyer cemini tapib qaytarir
            //var sum = 0;


            //Console.WriteLine("baslangic deyer");
            //var input = Console.ReadLine();
            //int fromNumber= Convert.ToInt32(input);


            //string toNumberInput;
            //int tonumber;

            //do
            //{
            //    Console.WriteLine("bitme deyeri daxil et");
            //     toNumberInput = Console.ReadLine();
            //     tonumber = Convert.ToInt32(toNumberInput);
            //}

            //while (tonumber <= fromNumber);




            //for (int i = fromNumber; i < tonumber; i++)
            //{
            //    sum +=i;
            //}

            //Console.WriteLine(sum);
            #endregion
            #region heften gunnu tapmax
            //Console.WriteLine("dayte den nedeli odin kakoy nibud");

            //string day=Console.ReadLine();
            //int dayNumber = Convert.ToInt32(day);

            //if (dayNumber==1)
            //{
            //    Console.WriteLine("1 gundu");
            //}
            //else if (dayNumber == 2)
            //{
            //    Console.WriteLine("2 gundu");
            //}
            //else if (dayNumber == 3)
            //{
            //    Console.WriteLine("3gundu");
            //}
            //else if (dayNumber == 4)
            //{
            //    Console.WriteLine("4 gundu");
            //}
            //else if (dayNumber == 5)
            //{
            //    Console.WriteLine("5 gundu");
            //}
            //else if (dayNumber == 6)
            //{
            //    Console.WriteLine("6 gundu");
            //}
            //else if (dayNumber == 7)
            //{
            //    Console.WriteLine("7 gundu");
            //}
            //else
            //{
            //    Console.WriteLine("heften gunnu sef daxil etmisiniz");
            //}
            #endregion


            #region esli cifro bolse 65 mezunsan esli 64 mense to mezun deilsen 
            //int number;
            //do
            //{
            //    var input = Console.ReadLine();
            //       number = Convert.ToInt32(input);
            //}
            //while (number < 0 || number > 100);


            //if (number > 64)
            //{
            //    Console.WriteLine("mezun oldu");
            //}
            //else
            //{
            //    Console.WriteLine("mezun olmadiniz");
            //}
            #endregion


            #region Verilmiş ədədlər siyahısındaki 21-ə bölunən ədədlərin ədədi ortasını tapan proqram

            //int[] numbers =  { 42, 63, 3, 12, 53, 61 };
            //int sum = 0;
            //int count = 0;
            //int result = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 21 == 0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //}


            //if (count == 0)
            //{
            //    Console.WriteLine("Bole bilmirem(");
            //}
            //else
            //{
            //    result = sum / count;
            //    Console.WriteLine(result);
            //}
            #endregion

            #region yazini tersine cevirir
            //Console.WriteLine("yazi daxil edin");
            //string name = Console.ReadLine();

            //string newname = "";
            //for (int i =name.Length-1;i>=0;i--)
            //{
            //    newname += name[i];
            //}
            //Console.WriteLine(newname);
            #endregion





            #region SetZero ref nen out nan deismek
            //    int num = -4;
            //    Power(ref num);
            //    Console.WriteLine(num);


            //    string text = "salam necesen yaxsiyam";
            //     DeleteSpace( ref text);
            //    Console.WriteLine(text);

            //    int num1;
            //    SetZero(out num1);
            //    Console.WriteLine(num1);






            //}

            //static void Power(ref int num1)
            //{
            //    num1 *= -1;



            //}

            //static void DeleteSpace( ref string text)
            //{
            //    string newtext = "";

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i] != ' ') 
            //        {
            //            newtext += text[i];
            //        }


            //    }

            //    text= newtext;

            //}

            //static void SetZero(out int num1)
            //{
            //    num1= -1;

            //}



            #endregion


            #region string char methods
            //Console.WriteLine(char.IsLetter('a'));
            //Console.WriteLine(char.IsDigit('5'));

            //Console.WriteLine(char.ToUpper('a'));
            //Console.WriteLine(char.IsUpper('A'));

            //string word = "Salam  necesen?";


            //var word1 = word.ToUpper();
            // word1= word1.ToLower();

            //Console.WriteLine(word.Contains("la"));
            //Console.WriteLine(word.IndexOf('A'));
            //Console.WriteLine(word.LastIndexOf('a'));

            //Console.WriteLine(word.Substring(5,3));


            //var index = word.IndexOf("necesen?");
            //var word2 = word.Substring(index,4);
            //Console.WriteLine(word2);

            //word = "Hello P138 group!";
            //var arr= word.Split(" ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //word = "Hello P138 group!";


            //string[] names = { "hikmet", "abbas", "arkan" };
            //var result = String.Join('-', names);
            //Console.WriteLine(result);



            //yazi boyuk heriflemi baslir yoxlamag Salam necesendise 0 ci indexi yoxlurug S boyukduse if icindekini yazdirir
            //if (char.IsUpper(word[0]))
            //{
            //    Console.WriteLine("yaziniz boyuk herfle baslayir");
            //}




            //yazi daxil edirik whilda baxir 0 index eger boyuk deilse yeniden deir yazi daxil ele eger boyuk olsa yazdigimizi verir 


            //string input;
            //do
            //{
            //    Console.WriteLine("yazi daxil edin");
            //    input = Console.ReadLine();
            //}
            //while (!char.IsUpper(input[0]));

            //Console.WriteLine(input);
            #endregion



            string text = "alovsat aye     sakjdak alkjkljaf";
            Console.WriteLine(HasDigit(text));
        }
       

        static int HasDigit(string str)
        {
           var arr= str.Split(' ');

            return arr.Length;
        }
           
        
          
      

    }



}

