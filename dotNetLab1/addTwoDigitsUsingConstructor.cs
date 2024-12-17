using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace dotNetLab1
{
    class addTwoNumbers
    {
        int sum;
        public addTwoNumbers()
        {
            Console.WriteLine("Sum is: ");
        }
        public addTwoNumbers(int a, int b)
        {
            sum = a + b;
        }

        public void display()
        {
            Console.WriteLine(sum);
        }
    }

        internal class addTwoDigitsUsingConstructor
        {
            public void addNumbers()
            {
                int a, b;

                Console.Write("Enter two numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                addTwoNumbers t1 = new addTwoNumbers();

                addTwoNumbers t2 = new addTwoNumbers(a, b);
                t2.display();
            }
        }
   
}
