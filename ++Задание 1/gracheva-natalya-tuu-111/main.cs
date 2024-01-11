using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MinValue;

            Console.WriteLine("Введите 1-е число:");
            x = Math.Max(x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 2-е число:");
            x = Math.Max(x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 3-е число:");
            x = Math.Max(x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 4-е число:");
            x = Math.Max(x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 5-е число:");
            x = Math.Max(x, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Максимальное среди введённых: " + x);
            Console.ReadKey(true);

            /*
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(x, x));
            x = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(x, x));
            x = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(x, x));
            x = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(x, x));
            x = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальное число");
            Console.WriteLine(Math.Max(x, x));
            x = Math.Max(Convert.ToInt32(Console.ReadLine()));
            Math.Max(Convert.ToInt32(Console.ReadLine()));
            */

            //Console.WriteLine($"Максимальное среди введённых: {x}");
            //Console.WriteLine("Максимальное {1} среди введённых: {0}", x, x*x);
        }
    }
}
