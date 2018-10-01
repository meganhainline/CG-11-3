using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace StudentMinMax
{
    class Student
    {
        public List<int> scores = new List<int>();
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void AddScore(int score)
        {
            scores.Add(score);
        }

        public int MinGrade()
        {
            return scores.Min();
        }

        public int MaxGrade()
        {
            return scores.Max();
            {
            }
        }
    }
} 
