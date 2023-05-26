using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpLB7.Models
{
    public class Lesson
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        public Lesson()
        {
            Id = string.Empty;
            Title = string.Empty;
            Hours = 0;
        }
        public Lesson(string title, int hours)
        {
            Title = title;
            Hours = hours;
        }
        public Lesson(string title, int hours, string teacherid)
        {
            Title = title;
            Hours = hours;
            TeacherId = teacherid;
        }
        public Lesson(string id, string title, int hours, string teacherid)
        {
            Id = id;
            Title = title;
            Hours = hours;
            TeacherId = teacherid;
        }
    }
}

