using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Natasha3
{
 class Program
 {
  static void Main(string[] args)
  {
   double a, b, c, m, n, alfa, bet, z, eps = 0.001;
   bool FlgAccess = true;
   Console.Write("Введите число m: "); FlgAccess &= double.TryParse(Console.ReadLine(), out m);
   Console.WriteLine(" ");
   Console.Write("Введите число n: "); FlgAccess &= double.TryParse(Console.ReadLine(), out n);
   Console.WriteLine(" ");
   Console.Write("Введите число a: "); FlgAccess &= double.TryParse(Console.ReadLine(), out a);
   Console.WriteLine(" ");
   Console.Write("Введите число b: ");
   FlgAccess &= double.TryParse(Console.ReadLine(), out b); Console.WriteLine(" ");
   Console.Write("Введите число c: ");
   FlgAccess &= double.TryParse(Console.ReadLine(), out c); Console.WriteLine(" ");
   if (FlgAccess)
   {
    if (m > n)
    {
     alfa = m;
    }
    else if (m == n)
    {
     alfa = n * Math.Cos(n);
    }
    else
    {
     alfa = n;
    }
    if (m < 5)
    {
     bet = a;
    }
    else if (m == 5)
    {
     bet = b;
    }
    else
    {
     bet = c;
    }
    FlgAccess = Math.Abs(Math.Cos(b)) >= eps;
    if (FlgAccess)
    {
     z = Math.Pow(Math.Pow(alfa, 2) + bet, 1.0 / 3) + Math.Pow(Math.E, alfa) - Math.Cos(bet);
     Console.WriteLine("Решение уравнения (Z): " + z);
    }
    else
    {
     z = Math.Pow(Math.Pow(alfa, 2) + bet, 1.0 / 3) + Math.Pow(Math.E, alfa);
     Console.WriteLine("Решение уравнения (Z): " + z);
    }
   }
   else
   {
    Console.WriteLine("Введены некорректные данные");
   }
   Console.ReadKey(true);
  }
  }
 }
