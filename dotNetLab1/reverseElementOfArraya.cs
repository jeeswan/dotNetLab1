using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetLab1
{
    class arrayReversal
    {
        public int[] ReverseArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                // Swap elements at positions i and (n - i - 1)
                int temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
            return array;
        }
    }
    internal class reverseElementOfArraya
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            arrayReversal reverser = new arrayReversal();

            int[] reversedArray = reverser.ReverseArray(array);

            Console.WriteLine("\nReversed Array:");
            foreach (int item in reversedArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(); 
        }
    }
}
