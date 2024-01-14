using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_6
{
 internal class Program
 {
  static void Main(string[] args)
  {
   double k, b, d, a, a0, ak, da, e, eps = 0.001;
   bool flg1, flg2, flg3, flg4, flg5, flg6;
   Console.WriteLine("---Ввод значений для констант---");
   Console.Write("Введите значение k: ");
   flg1 = Double.TryParse(Console.ReadLine(), out k);
   Console.Write("Введите значение b: ");
   flg2 = Double.TryParse(Console.ReadLine(), out b);
   Console.Write("Введите значение d: ");
   flg3 = Double.TryParse(Console.ReadLine(), out d);
   Console.WriteLine("---Ввод начала и конца диапазона---");
   Console.Write("Введите начало диапазона: ");
   flg4 = Double.TryParse(Console.ReadLine(), out a0);
   Console.Write("Введите конец диапозона: ");
   flg5 = Double.TryParse(Console.ReadLine(), out ak);
   Console.WriteLine("---Ввод шага---");
   Console.Write("Введите шаг: ");
   flg6 = Double.TryParse(Console.ReadLine(), out da);
   if (flg1 & flg2 & flg3 & flg4 & flg5 & flg6)
   {
    a = a0;
    while (a <= ak)
    {
     flg1 = Math.Sqrt(Math.Pow(a,2) + b * Math.Cos(b))) >= eps;
     if (flg1)
     {
      e = (0.1 * k) + (Math.Pow(Math.PI,(1/k) + d)) * Math.Tan(Math.Pow(a,2)) * Math.Pow(k,1/a0) / (Math.Sqrt(Math.Pow(a, 2) + b * Math.Cos(b)));
      Console.WriteLine($"При x = {a:F3}, e(a) = {e}");
     }
     else
      Console.WriteLine($"При x = {a:F3}, e(a) не существует");
     a += da;
    }
   }
   else
    Console.WriteLine("Введены некорректные данные");
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
   Console.ReadKey(true);
  }
 }
}

