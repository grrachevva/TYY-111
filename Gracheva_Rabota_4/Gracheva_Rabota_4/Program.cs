using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
 class Program
 {
  static void Main(string[] args)
  {
   double x1, x2, x3, y1, y2, y3;
   bool FlgAccess = true;
   Console.WriteLine("Введите координаты первой точки (x1, y1):");
   FlgAccess &= double.TryParse(Console.ReadLine(), out x1);
   FlgAccess &= double.TryParse(Console.ReadLine(), out y1);

   Console.WriteLine("Введите координаты второй точки (x2, y2):");
   FlgAccess &= double.TryParse(Console.ReadLine(), out x2);
   FlgAccess &= double.TryParse(Console.ReadLine(), out y2);

   Console.WriteLine("Введите координаты третьей точки (x3, y3):");
   FlgAccess &= double.TryParse(Console.ReadLine(), out x3);
   FlgAccess &= double.TryParse(Console.ReadLine(), out y3);

   if (FlgAccess)
   {
    if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
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
  }
 }
}
