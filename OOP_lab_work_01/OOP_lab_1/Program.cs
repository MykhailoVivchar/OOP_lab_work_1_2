using System;
using System.Collections;
using System.Text;
namespace OOP_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1 ");
            Class1 t1 = new Class1();
            double y = t1.task1(4,3.2);
            Console.WriteLine(y);

            Console.WriteLine(" \n Task 2 ");
            Console.WriteLine("Enter a natural number n ");
            Class2 t2 = new Class2();
            int n = Convert.ToInt32(Console.ReadLine());
            while (n-- > 1)
            {
                int nn = n * n;
                if (t2.task2(n, nn))
                {
                    Console.WriteLine(n + "^2  = " + nn);
                }
            }

            Console.WriteLine(" \n Task 3 ");
            Class3 t3 = new Class3();
            double x = t3.get();
            Console.WriteLine(x);
            
        }
    }
}