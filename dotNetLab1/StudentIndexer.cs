using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetLab1
{
    class StudentCollection
    {
        // Private list to store student names
        private List<string> studentNames = new List<string>();

        // Indexer to access student names
        public string this[int index]
        {
            get
            {
                // Check if index is valid
                if (index >= 0 && index < studentNames.Count)
                {
                    return studentNames[index];
                }
                else
                {
                    return "Index out of range";
                }
            }
            set
            {
                // Update if the index is valid; otherwise, add a new student
                if (index >= 0 && index < studentNames.Count)
                {
                    studentNames[index] = value;
                }
                else if (index == studentNames.Count)
                {
                    studentNames.Add(value);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

        // Method to display all student names
        public void DisplayStudents()
        {
            Console.WriteLine("Students List:");
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"[{i}] {studentNames[i]}");
            }
        }
    }
    internal class StudentIndexer
    {
        static void Main(string[] args) 
        {
            StudentCollection students = new StudentCollection();

            // Add students using the indexer
            students[0] = "Rose";
            students[1] = "Krisha";
            students[2] = "Jeeswan";

            // Retrieve and display students using the indexer
            Console.WriteLine("Retrieving students by index:");
            Console.WriteLine($"Student at index 0: {students[0]}");
            Console.WriteLine($"Student at index 1: {students[1]}");
            Console.WriteLine($"Student at index 2: {students[2]}");

            // Attempt to access an invalid index
            Console.WriteLine($"Student at index 5: {students[5]}");

            // Update a student's name using the indexer
            students[1] = "Krishna";

            // Display all students
            students.DisplayStudents();

            Console.ReadLine();
        }
    }
}

