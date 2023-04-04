using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_1
{
    class Class1
    {
        public double task1(double a, double x)
        {
            return ((x * x * x + 2 * a * x + 3) / Math.Pow((x - 1), 2)) + (Math.Cos(Math.Pow(x, 2)) / (a + 2));
        }
    }

    class Class2
    {
        public bool task2(int num, int squared)
        {
            while (num > 0)
            {
                if (num % 10 != squared % 10)
                    return false;
                num = num / 10;
                squared = squared / 10;
            }
            return true;
        }
    }

    class Class3
    {
        public float h(float a, float b)
        {
            float c;
            c = (float)(a / (1 + Math.Pow(b, 2)) + (b / (1 + Math.Pow(a, 2))) - Math.Pow((a - b), 3));
            return c;
        }
        public double get()
        {
            double s, t, result;
            Console.WriteLine(" Enter s: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter t: ");
            t = Convert.ToDouble(Console.ReadLine());
            result = h((float)s, (float)t) + Math.Max(h(((float)s - (float)t), ((float)s * (float)t)), h(((float)s - (float)t), ((float)s + (float)t))) + h(1, 1);
            return result;
        }
    }
}