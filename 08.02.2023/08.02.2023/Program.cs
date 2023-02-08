using System;

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



            Console.WriteLine("Engineer count");
            int count = Convert.ToInt32(Console.ReadLine());
            Engineer[] engineers = new Engineer[count];


            for (int i = 0; i < count; i++)
            {
                Engineer neweng = new Engineer();

                Console.WriteLine("FullName: ");
                neweng.FullName = Console.ReadLine();
                Console.WriteLine("Salary: ");
                neweng.Salary = Convert.ToDouble(Console.ReadLine());

                engineers[i] = neweng;

            }


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
