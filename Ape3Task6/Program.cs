
using System;

namespace Ape3Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ziya Gachakhanli", "Assisant");
            Console.WriteLine(student.GroupName);

            Student student1 = new Student("Kamal Abishli", "Student");
            Console.WriteLine(student1.GroupName);


            Student student2 = new Student("Amal Gachakhanli", "Engineer");
            Console.WriteLine(student2.GroupName);


        }
    }
}
