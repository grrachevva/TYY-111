using System;

class Program
{
 static void Main()
 {
  string inputString;
  char delimiter;

  Console.Write("Введите строку: ");
  inputString = Console.ReadLine();

  Console.Write("Введите разделитель: ");
  char.TryParse(Console.ReadLine(), out delimiter);
  Console.WriteLine();

  string[] resultArray = null;
  _eSplitString(ref resultArray, inputString, delimiter);

  Console.WriteLine("Результат: ");
  for (int i = 0; i < resultArray.Length; i++)
   Console.WriteLine(resultArray[i]);
  Console.ReadKey(true);

 }

 static void _eSplitString(ref string[] resultArray, string inputString, char delimiter)
 {
  int count, startIndex, arrayIndex;

  count = 1;

  for (int i = 0; i < inputString.Length; i++)
  {
   if (inputString[i] == delimiter)
   {
    count++;
   }
  }

  resultArray = new string[count];
  startIndex = 0;
  arrayIndex = 0;

  for (int i = 0; i < inputString.Length; i++)
  {
   if (inputString[i] == delimiter)
   {
    resultArray[arrayIndex] = inputString.Substring(startIndex, i - startIndex + 1);
    startIndex = i + 1;
    arrayIndex++;
   }
  }

  if (startIndex < inputString.Length)
  {
   resultArray[arrayIndex] = inputString.Substring(startIndex);
  }
 }
}
