using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gracheva_4
{
 class Program
 {
  static void Main(string[] args)
  {
   double x1, x2, x3, y1, y2, y3;
   double eps = 0.0001;
   bool flg1, flg2, flg3, flg4, flg5, flg6;
   Console.WriteLine("Введите координаты первой точки (x1, y1):");
   flg1 = double.TryParse(Console.ReadLine(), out x1);
   flg2 = double.TryParse(Console.ReadLine(), out y1);

   Console.WriteLine("Введите координаты второй точки (x2, y2):");
   flg3 = double.TryParse(Console.ReadLine(), out x2);
   flg4 = double.TryParse(Console.ReadLine(), out y2);

   Console.WriteLine("Введите координаты третьей точки (x3, y3):");
   flg5 = double.TryParse(Console.ReadLine(), out x3);
   flg6 = double.TryParse(Console.ReadLine(), out y3);

   if (flg1 && flg2 && flg3 && flg4 && flg5 && flg6)
   {
    if (Math.Abs((y3 - y2) * (x2 - x1) - (y2 - y1) * (x3 - x2)) <= eps)
    {
     Console.WriteLine("Точки лежат на одной прямой");
     Console.ReadKey(true);
    }
    else
    {
     Console.WriteLine("Точки НЕ лежат на одной прямой");
     Console.ReadKey(true);
    }
   }
   else
   {
    Console.WriteLine("Введены некорректные данные");
    Console.ReadKey(true);
   }
  }
 }
}
