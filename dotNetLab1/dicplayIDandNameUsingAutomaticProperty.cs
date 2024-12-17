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


        public void DisplayStudentDetails()
        {

            StudentId = 1;
            StudentName = "Alice";

            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Student Name: {StudentName}");
        }


    }
} 


