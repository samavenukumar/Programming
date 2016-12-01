using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student() {StudentId = 1,Name="venu",Age =23,Gender = "M" },
new Student() {StudentId=2,Name = "IMCS", Age = 24, Gender = "M" },
new Student() {StudentId=3,Name = "Saina", Age = 14, Gender = "F" },
new Student() {StudentId=4,Name = "Sania", Age = 22, Gender = "F" },
            };
            Console.WriteLine(student.Count);
            double age = 0;
            var count = 1;
            foreach (var std in student)
            {
                age = age + std.Age;
                Console.WriteLine("student " + (student.IndexOf(std) + 1) + " age is " + std.Age);
                count = student.IndexOf(std) + 1;

            }
            double averageAge = Convert.ToDouble(age / count);
            Console.WriteLine("overall avergae age of the " + count + " members in Student list is " + averageAge);
            //Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
