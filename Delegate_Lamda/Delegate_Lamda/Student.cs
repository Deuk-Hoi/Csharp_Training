using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Lamda
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }

        public Student(string Name, double Score)
        {
            this.Name = Name;
            this.Score = Score; 
        }
        public override string ToString()
        {
            return this.Name + " : " + this.Score;
        }
    }
    class Students
    {
        private List<Student> list = new List<Student>();
        public delegate void PrintStudent(Student s);

        public void Add(Student student)
        {
            list.Add(student);
        }

        public void Print() //PrintStudent델리게이트를 매개 메서드로 받음
        {
            Print((student) => { Console.WriteLine(student); });
        }

        public void Print(PrintStudent printStudent)
        {
            foreach(var item in list)
            {
                printStudent(item);
            }
        }
    }
}

