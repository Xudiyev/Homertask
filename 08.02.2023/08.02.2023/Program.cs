using System;
using System.Dynamic;

namespace _08._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();

            empl.FullName = "Arif Alizade";

            empl.Salary = 450;

            Console.WriteLine(empl.Salary);

            Engineer eng = new Engineer();
            eng.FullName = "Ismayil Mamedov";
            eng.Salary = 1100;
            Console.WriteLine(eng.Salary);



            //Console.WriteLine("Engineer count");
            //int count = Convert.ToInt32(Console.ReadLine());
            Engineer[] engineers = new Engineer[0];

            string ch;
            do
            {
                
                
                    Engineer neweng = new Engineer();

                    Console.WriteLine("FullName: ");
                    neweng.FullName = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("Salary: ");
                        neweng.Salary = Convert.ToDouble(Console.ReadLine());

                    } while (neweng.Salary < 1000);


                    Array.Resize(ref engineers, engineers.Length + 1);
                    engineers[engineers.Length - 1] = neweng;

                
                


                do
                {
                    Console.WriteLine("If you want to add new employee press y/n");
                    ch = Console.ReadLine();
                } while (ch != "y" && ch != "n");



            } while (ch == "y"); ;


            double sum = 0;



            for (int i = 0; i < engineers.Length; i++)
            {
                sum += engineers[i].Salary;

            }
            double result = sum / engineers.Length;
            Console.WriteLine(result);











        }
    }
}
