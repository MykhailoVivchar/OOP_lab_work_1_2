using System;
using System.Collections.Generic;

namespace OOP_lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" TASK 1");
            Task1();
            
            Console.WriteLine(" TASK 2");
            Task2();
        }
        public static void Task1()
        {
            Console.WriteLine(" Enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Element [" + i + "] = ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            // пошук суми елементів масиву з непарними елементами
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(" The sum of the elements of an array with odd elements: " + sum);
            
            // сума елементів масиву, які розташовані між першим і останнім від’ємними елементами.
            double sum1 = 0, element = 0;
            bool started = true;

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    if (started)
                    {
                        element = 0;
                        started = false;
                    }
                    else
                    {
                        sum1 += element;
                        element = array[i];
                    }
                }
                else
                {
                    element += array[i];
                }
            }
            Console.WriteLine(" The sum between the first and last negative elements: " + sum1);

            Console.WriteLine(" Array : " + String.Join(" ", array));
            Console.WriteLine(" Enter the number of elements to be inserted at the end of the array: ");
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k);
            Array.Reverse(array, k, array.Length - k);
            Array.Reverse(array);
            Console.WriteLine("Result: " + String.Join(" ", array));
        }

        public static void Task2()
        {
            string str;
            int wrd, l;
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = 0;
            wrd = 1;
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' )
                {
                    wrd++;
                }
                l++;
            }
            Console.Write("Total number of words in the string is : {0}\n", wrd);
            
            //кількість голосних букв
            int i, len, vowel;
            vowel = 0;
            len = str.Length;
            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
            }
            Console.Write("The total number of vowel in the string is : {0}\n", vowel);

            // видалення пробілів
            static String removeSpace(String str)
            {
                str = str.Replace(" ", "");
                return str;
            }
            Console.WriteLine(removeSpace(str));
           

        }
    }
}
