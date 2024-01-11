using System;


namespace GrachevaRabota2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1;
            double a2;
            double a;
            double b1;
            double b;
            double c1;
            double c2;
            double c;
            double d;
            double e1;
            double e2;
            double e3;
            double e;
            double g;
            double f;
            double result1;
            double result2;
            // способ с вводом всего одной переменной
            #region
            result1 = -Math.Pow(Math.Abs((-Math.Pow((2.625 + (8 + (9.0 / 11))), 1.0 / 3)) - (Math.Sqrt(((1.6 + 154.66 / 70.3) / 1.9) / ((Math.Pow((2 + (2.0 / 5) - (1.3)), 1.0 / 3)) / 4.3))) + (1 + (1.0 / 2) * (1.0 / 0.25)) / (6 - 46 / (1 + 2.2 * 10)) - (1 / Math.Sqrt(Math.PI))), 1.0 / 5);
            Console.WriteLine("Ответ, решение которого выведено с помощью использования одной переменной" + " " + result1);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            #endregion

            // способ с вводом нескольких переменных
            #region

            a1 = (2.625 + (8 + (9.0 / 11)));
            a2 = Math.Pow(a1, 1.0 / 3);
            a = -1 * a2;
            b1 = (1.6 + 154.66 / 70.3);
            b = b1 / 1.9;
            c1 = (2 + (2.0 / 5) - (1.3));
            c2 = Math.Pow(c1, 1.0 / 3);
            c = c2 / 4.3;
            d = Math.Sqrt(b / c);
            e1 = (1 + (1.0 / 2) * (1.0 / 0.25));
            e2 = 46 / (1 + 2.2 * 10);
            e3 = 6 - e2;
            e = e1 / e3;
            g = 1 / Math.Sqrt(Math.PI);
            f = (a - d + e - g);
            result2 = -(Math.Pow((Math.Abs(f)), 1.0 / 5));

            Console.WriteLine("Ответ, решение которого выведено с помощью использования нескольких переменных:" + " " + result2);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            #endregion
            Console.ReadKey(true);
            

        }
    }
}
