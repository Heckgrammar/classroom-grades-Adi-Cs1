using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankCSDotNet8
{
    internal class Program
    {
        struct Student
        {
            public string Name;
            public int studentID;
            public string formGroup;

            public Student(string nameb, int studentIDb, string formGroupb)
            {
                Name = nameb;
                studentID = studentIDb;
                formGroup = formGroupb;
            }
        }

        static void Main(string[] args)
        {
            const int maxStudents = 5;
            Student[] stuNames = new Student[maxStudents];
            string[] subjects = { "English Language", "English Literature", "Mathematics", "Biology", "Chemistry", "Physics", "History", "Geography", "Religious Studies", "Spanish", "French", "Art & Design", "Business", "Computer Science", "Drama", "Food Preparation and Nutrition", "DT Graphics", "Music", "Physical Education", "DT Resistant Materials" };
            int maxSubjects = subjects.Length;
            int[,] grades = new int[maxStudents, maxSubjects];
            while (true)
            {
                Console.WriteLine("Options");
                Console.WriteLine();
            }



        }
    }
}
