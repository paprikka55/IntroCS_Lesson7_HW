// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateRandomArray(int length)
{
  int[] arr = new int[length];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 100);
  }
  return arr;
}

int InputArrayLength()
{
  int length = new int();
  while (true)
  {
    Console.Write("Введите длину массива: ");
    if (int.TryParse(Console.ReadLine(), out length))
    {
      if (length > 0)
      { break; }
      else
      { Console.WriteLine("В массиве не может быть меньше одного элемента! Попробуйте снова."); }
    }
    else
    { Console.WriteLine("Неверный формат данных! Попробуйте снова."); }
  }
  return length;
}

void PrintArray(int[] arr, int startIndex = 0)
{
  if (startIndex != arr.Length - 1)
  {
    if (startIndex == 0)
    { Console.WriteLine("Массив: "); }
    Console.Write($"{arr[startIndex]}\t");
    PrintArray(arr, startIndex + 1);
  }
  else
  {
    Console.Write($"{arr[startIndex]}\t");
    Console.WriteLine();
    return;
  }
}

void PrintReverseArray(int[] arr, int startIndex = 0)
{
  if (startIndex != arr.Length - 1)
  {
    PrintReverseArray(arr, startIndex + 1);
    Console.Write($"{arr[startIndex]}\t");
  }
  else
  {
    Console.WriteLine("В обратном порядке: ");
    Console.Write($"{arr[startIndex]}\t");
    return;
  }
}

int[] _randomNums = CreateRandomArray(InputArrayLength());
PrintArray(_randomNums);
PrintReverseArray(_randomNums);