using System;

namespace _11._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Course course = new Course();

            string option;
            do
            {
                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Bütün qruplara bax");
                Console.WriteLine("3. Verilmiş point araliğindaki qruplara bax");
                Console.WriteLine("4. Verilmiş nömresi uzre qrupa bax");
                Console.WriteLine("5. Verilmiş qruplar üzre axtariş et");
                Console.WriteLine("0 .Menudan cix");

                Console.WriteLine("\nSecim edin");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var groups = course.AddGroup();


                        break;
                    case "2":
                        groups = course.Groups();

                        break;
                    case "3":
                        groups = course.GetGroupsByPointRange();
                        break;
                    case "4":
                        groups = course.GetGroupByNo();

                        break;

                    case "5":
                        groups = course.Search();

                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Secim duzgun deil!");
                        break;



                }

            } while (option != "0");

        }
    }
}
