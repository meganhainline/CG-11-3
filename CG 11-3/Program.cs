using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace StudentMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\megha\\source\\repos\\CG 11-3\\CG 11-3\\studentNames.txt");

            List<Student> students = new List<Student>();

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split(" ");
                Student s = new Student(items[0]);

                for (int i = 1; i < items.Length; i++)
                {
                    s.AddScore(Int32.Parse(items[i]));
                }

                students.Add(s);

            }
            foreach (Student item in students)
            {

                Console.WriteLine(item.Name + " " + item.MinGrade() + " " + item.MaxGrade());

            }
            Console.ReadLine();
        }
    }
}
