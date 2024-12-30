using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetLab1
{
    internal class dicplayIDandNameUsingAutomaticProperty
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }


        static void Main(string[] args)
        {

            dicplayIDandNameUsingAutomaticProperty student = new dicplayIDandNameUsingAutomaticProperty();

            student.StudentId = 001;
            student.StudentName = "Rose";

            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Student Name: {student.StudentName}");
        }


    }
} 


