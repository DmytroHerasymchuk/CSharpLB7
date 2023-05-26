using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLB7.Models
{
    public class Teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public List<Lesson> Lessons { get; set; }

        public Teacher()
        {
            Id = string.Empty;
            Name = string.Empty;
            Salary = 0;
            Lessons = new List<Lesson>();
        }
        public Teacher(string name, double salary)
        {
            Name = name;
            Salary = salary;
            Lessons = new List<Lesson>();
        }
        public Teacher(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Lessons = new List<Lesson>();
        }

        public IEnumerable<Lesson> GetDisciplines()
        {
            foreach (var item in Lessons)
            {
                yield return item;
            }
        }

        public void Add_Discipline(Lesson new_discipline)
        {
            Lessons.Add(new_discipline);
        }

    }
}

