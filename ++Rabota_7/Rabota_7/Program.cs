using System;
class Program
{

 static void Main(string[] args)
 {
  int n, fact1 = 1, fact2 = 1, f1 = 2, f2 = 0, yDegree = 0, xDegree = 1, tgDegree = 1;
  double x, y, eps = 0.001, e = 0;
  bool flg1, flg2, flg3;

  Console.Write("Введите x: ");
  flg1 = Double.TryParse(Console.ReadLine(), out x);
  Console.Write("Введите y: ");
  flg2 = Double.TryParse(Console.ReadLine(), out y);
  Console.Write("Введите кол-во элементов ряда: ");
  flg3 = Int32.TryParse(Console.ReadLine(), out n);

  if (flg1 && flg2)
  {
   flg1 = Math.Abs(Math.Cos(y)) >= eps;
   if (flg1)
   {
    flg2 = Math.Abs(Math.Sin(y)) >= eps;
    if (flg2)
    {
     for (int i = 1; i <= n; i++)
     {
      f1++;

      f2 += 2;
      yDegree += 2;
      xDegree *= 2;
      tgDegree++;
      for (int j = 1; j <= f1; j++)
      {
       fact1 *= j;
      }
      for (int g = 1; g <= f2; g++)
      {
       fact2 *= g;
      }
      if (i % 4 == 1)
      {
       e += (Math.Pow(y, yDegree) + Math.Sin(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
      }
      if (i % 4 == 2)
      {
       e -= (Math.Pow(y, yDegree) + Math.Cos(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
      }
      if (i % 4 == 3)
      {
       e += (Math.Pow(y, yDegree) + Math.Tan(fact1)) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
      }
      if (i % 4 == 0)
      {
       e -= (Math.Pow(y, yDegree) + (Math.Cos(fact1) / Math.Sin(fact1))) / (Math.Pow(Math.Tan(y), tgDegree) + Math.Sqrt(Math.Pow(x, xDegree) + fact2));
      }
      fact1 = 1;
      fact2 = 1;
     }
     Console.WriteLine($"e = {e}");
    }
   }
   else
   {
    Console.WriteLine("Невозможно решить задачу");
   }
  }
  else
  {
   Console.WriteLine("Введеные некорретные данные");
  }
  Console.ReadKey(true);
 }
}

