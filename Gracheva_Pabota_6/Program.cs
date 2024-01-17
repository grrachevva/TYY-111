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
   int count = 0;
   Console.WriteLine("---Ввод значений для констант---");
   Console.Write("Введите значение k: ");
   flg1 = Double.TryParse(Console.ReadLine(), out k) && (k > eps);
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
     count += 1;
     flg1 = Math.Pow(a, 2) + b * Math.Cos(b) >= eps;
     if (flg1)
     {
      flg2 = Math.Abs(Math.Sqrt(Math.Pow(a, 2) + b * Math.Cos(b))) >= eps;
      if (flg2)
      {
       flg3 = Math.Abs(Math.Cos(a * a)) >= eps;
       if (flg3)
       {
        flg5 = (Math.Abs(k) >= eps) && (Math.Abs(a) >= eps);
        if (flg5)
        {
         e = (0.1 * k) + ((Math.Pow(Math.PI, ((1f / k) + d)) * Math.Tan(a * a) * Math.Pow(k, (1f / a))) / (Math.Sqrt(Math.Pow(a, 2) + b * Math.Cos(b))));
         Console.WriteLine($"{count}) При а = {a:F3}, e = {e:F3}");
        }
        else
        {
         Console.WriteLine($"{count}) При а = {a:F3}, e Не существует");
        }
       }
       else
       {
        Console.WriteLine($"{count}) При а = {a:F3}, e Не существует");
       }
      }
      else
      {
       Console.WriteLine($"{count}) При а = {a:F3}, e Не существует");
      }
     }
     else
     {
      Console.WriteLine($"{count}) При а = {a:F3}, e Не существует");
     }
     if (count % 20 == 0)
      Console.ReadKey(true);
     a += da;
    }
   }
   else
    Console.WriteLine("Введены некорректные данные");
   Console.ReadKey(true);
  }
 }
}