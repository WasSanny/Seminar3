// Программа, которая на вход принимает координаты точки (Х, У), причем Х не = 0 и У не = 0,
// и выдает номер четверти плоскости в которой находится эта точка.
while (true)
{
  Task();
}

void Task()
{
  int x = ReadInt("X");
  int y = ReadInt("Y");

  int quater = GetQuarter (x, y);

  Console.WriteLine($"{quater}: [{x} - {y}]");
}

int GetQuarter(int x, int y)
{ 
  if (x == 0 || y == 0)
  {
    return -1;
  }

  if (x > 0 && y > 0)
  {
    return 1;
  }
  else if (x < 0 && y > 0)
  {
    return 2;
  }
  else if (x < 0 && y < 0)
  {
    return 3;
  }
  else
  {
    return 4;
  }
}

int ReadInt(string argumentName)      // создаем функцию
{
  Console.Write($"Input {argumentName}: ");
  int number = 0;
  while (!int.TryParse(Console.ReadLine(),  out number))
  {
    Console.WriteLine("It's not a number");
  }
  return number;
}