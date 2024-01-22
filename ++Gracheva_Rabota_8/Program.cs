using System;

class Program
{
 static void Main(string[] args)
 {
  Console.Write("Введите длину массива: ");
  bool flg = Int32.TryParse(Console.ReadLine(), out int n);
  if (flg == true)
  {
   int[] array = new int[n];
   for (int i = 0; i < array.Length; i++)
   {
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    flg = Int32.TryParse(Console.ReadLine(), out array[i]);
    if (flg == false)
    {
     break;
    }
   }
   if (flg == true)
   {
    int positiveIndex = 0;
    while (positiveIndex < array.Length && array[positiveIndex] >= 0)
    {
     positiveIndex++;
    }
    int negativeIndex = positiveIndex;
    while (negativeIndex < array.Length && array[negativeIndex] < 0)
    {
     negativeIndex++;
    }
    while (positiveIndex < array.Length && negativeIndex < array.Length)
    {
     int temp = array[positiveIndex];
     array[positiveIndex] = array[negativeIndex];
     array[negativeIndex] = temp;

     positiveIndex++;
     negativeIndex++;

     while (positiveIndex < array.Length && array[positiveIndex] >= 0)
     {
      positiveIndex++;
     }

     while (negativeIndex < array.Length && array[negativeIndex] < 0)
     {
      negativeIndex++;
     }
    }

    Console.WriteLine("Результирующий массив:");

    for (int i = 0; i < array.Length; i++)
    {
     Console.Write($"{array[i]} ");
    }
   }
   else
   {
    Console.WriteLine("Введены неверные данные");
   }
  }
  else
  {
   Console.WriteLine("Введены неверные данные");
  }
  Console.ReadKey(true);
 }
}

