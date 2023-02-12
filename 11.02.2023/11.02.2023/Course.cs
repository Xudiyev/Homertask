using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace _11._02._2023
{
    internal class Course
    {
        string _addGroup;
        string _groups;
        string _getGroupByNo;
        double _getGroupsByPonitRange;
        string _search;

       

        public Group[] Group = new Group[0];

        public Group[] AddGroup()
        {
            

            Console.WriteLine("Add a new group");
            string no = Console.ReadLine();

            Console.WriteLine("Add a group averagepoint!");
            double avgpoint = Convert.ToDouble(Console.ReadLine());

            Group newgroup = new Group()

            {
                No = no,
                AvgPoint = avgpoint
            };

            Array.Resize(ref Group, Group.Length + 1);
            Group[Group.Length - 1] = newgroup;

         return Group;
               
        }



       


        public Group[] Groups()
        {
            Group[] allGroups=new Group[0];

            Console.WriteLine("All Groups:");

            for (int i = 0; i < Group.Length; i++)
            {
                Console.WriteLine($"Group: {Group[i].No}");
                Console.WriteLine($"AvgPoint: {Group[i].AvgPoint}\n");
            }

            
            return allGroups; 
        }


        public Group[] GetGroupByNo()
        {
            Group[] findGroup=new Group[0];
            Console.WriteLine("Write the group you want to find");

            string noqroup = Console.ReadLine();


            for (int i = 0; i < Group.Length; i++)
            {
                if (Group[i].No == noqroup)
                {
                    Console.WriteLine($"Group: {Group[i].No}");
                    Console.WriteLine($"AvgPoint: {Group[i].AvgPoint}\n");

                }
                else
                {
                    noqroup = null;
                    Console.WriteLine("We did not find such a group");


                }
                
            }
            return findGroup;
        }



        public Group[] GetGroupsByPointRange()
        {
            Group[] getGroups=new Group[0];
            Console.WriteLine("Write a min point");

            double min = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write a max point");
            double max = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < Group.Length; i++)
            {
                if (Group[i].AvgPoint > min && Group[i].AvgPoint < max)
                {
                    Console.WriteLine($"Group: {Group[i].No}");
                    Console.WriteLine($"AvgPoint: {Group[i].AvgPoint}\n");
                }
            }
            return getGroups;
        }




        public Group[] Search() 
        {
            Group[] showGroup=new Group[0];

            Console.WriteLine("Write some number or letter of the group: ");
            string str=(Console.ReadLine());

            for (int i = 0; i < Group.Length; i++)
            {
                if (Group[i].No.Contains(str))
                {
                    Console.WriteLine($"Group: {Group[i].No}");
                    Console.WriteLine($"AvgPoint: {Group[i].AvgPoint}\n");
                }
                else
                {
                    Console.WriteLine("No such group:");
                }

            }

            return showGroup;
        
        }
    }
}
 