// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.Arm;

int[] Input2Nums()
{
  int[] inputNums = new int[2];
  while (true)
  {
    Console.Write("Введите натуральное число M: ");
    if (int.TryParse(Console.ReadLine(), out inputNums[0]))
    {
      if (inputNums[0] > 0)
        { break; }
    }
    Console.WriteLine("Ошибка! Введено не натуральное число. Попробуйте снова.");
  }
  while (true)
  {
    Console.Write("Введите натуральное число N: ");
    if (int.TryParse(Console.ReadLine(), out inputNums[1]))
    {
      if (inputNums[1] > 0)
        { break; }
    }
    Console.WriteLine("Ошибка! Введено не натуральное число. Попробуйте снова.");
  }
  return inputNums;
}

void PrintNums(int min, int max)
{
  if (min == max)
  {
    Console.WriteLine($"{min}");
    return;
  }
  Console.Write($"{min} ");
  min++;
  PrintNums(min, max);
}

void PrintInterval(int[] nums)
{
  int min = new int();
  int max = new int();
  if (nums[0] < nums[1])
  { 
    min = nums[0];
    max = nums[1];  
  }
  else
  { 
    min = nums[1];
    max = nums[0];  
  }
  Console.Write($"Числа между {min} и {max}: ");
  PrintNums(min, max);
}

int[] inputNums = Input2Nums();
PrintInterval(inputNums);