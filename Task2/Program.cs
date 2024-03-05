// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int[] Input2Nums()
{
  int[] inputNums = new int[2];
  while (true)
  {
    Console.Write("Введите неотрицательное число M: ");
    if (int.TryParse(Console.ReadLine(), out inputNums[0]))
    {
      if (inputNums[0] >= 0)
        { break; }
    }
    Console.WriteLine("Ошибка введения данных! Попробуйте снова.");
  }
  while (true)
  {
    Console.Write("Введите неотрицательное число N: ");
    if (int.TryParse(Console.ReadLine(), out inputNums[1]))
    {
      if (inputNums[1] >= 0)
        { break; }
    }
    Console.WriteLine("Ошибка введения данных! Попробуйте снова.");
  }
  return inputNums;
}

int GetAkkermanFunction(int Mnum, int Nnum)
{
  if (Mnum == 0)
  { return Nnum + 1; }
  else if (Nnum == 0)
  { return GetAkkermanFunction(Mnum - 1, 1); }
  else
  { return GetAkkermanFunction(Mnum - 1, GetAkkermanFunction(Mnum, Nnum - 1)); }
}

int[] inputNums = Input2Nums();
int Mnum = inputNums[0];
int Nnum = inputNums[1];
int akkFunc = GetAkkermanFunction(Mnum, Nnum);
Console.WriteLine($"Функция Аккермана А({Mnum},{Nnum}): {akkFunc}");