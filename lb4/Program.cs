using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lb4
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public string Group { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>
            {
                new Student { Name = "Іван", Age = 20, GPA = 87.5, Group = "ІП-12" },
                new Student { Name = "Марія", Age = 19, GPA = 92.1, Group = "ІП-11" },
                new Student { Name = "Петро", Age = 21, GPA = 75.3, Group = "ІП-12" },
                new Student { Name = "Олена", Age = 20, GPA = 88.9, Group = "ІП-11" },
                new Student { Name = "Андрій", Age = 22, GPA = 69.4, Group = "ІП-13" }
            };

            
            var excellentStudents = students.Where(s => s.GPA > 85);
            var groupIP12 = students.Where(s => s.Group == "ІП-12");
            var names = students.Select(s => s.Name);

            
            var orderedByName = students.OrderBy(s => s.Name);
            var orderedByGPA = students.OrderByDescending(s => s.GPA);
            var thenByGroup = students.OrderBy(s => s.Group).ThenBy(s => s.Name);

            
            var anonymousType = students.Select(s => new { s.Name, s.GPA });
            var uniqueGroups = students.Select(s => s.Group).Distinct();

            
            var top3 = students.OrderByDescending(s => s.GPA).Take(3);

            Console.WriteLine("Найкращі студенти:");
            foreach (var s in top3)
                Console.WriteLine($"{s.Name} ({s.GPA})");

            Console.WriteLine("\nУнікальні групи:");
            foreach (var g in uniqueGroups)
                Console.WriteLine(g);

            Console.WriteLine("\nСтуденти групи ІП-12:");
            foreach (var s in groupIP12)
                Console.WriteLine(s.Name);
        }
    }
}
