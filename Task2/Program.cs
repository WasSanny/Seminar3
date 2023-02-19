// See Программа, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек
// в этой четверти (x, y)

Console.OutputEncoding = System.Text.Encoding.UTF8; // для знака
Console.InputEncoding = System.Text.Encoding.UTF8;  // бесконечности!

Console.WriteLine("Введите номер четверти: ");
int GetQuerter = int.Parse(Console.ReadLine());

int[] x = new int[] {1, -1, -1, 1};
int[] y = new int[] {1, 1, -1, -1};

if (GetQuerter == 1)
{
  Console.WriteLine($"X от {x[0]} до +∞");
  Console.WriteLine($"Y от {y[0]} до +∞");
}
else if (GetQuerter == 2)
{
  Console.WriteLine($"X от {x[1]} до -∞");
  Console.WriteLine($"Y от {y[1]} до +∞");
}
else if (GetQuerter == 3)
{
  Console.WriteLine($"X от {x[2]} до -∞");
  Console.WriteLine($"Y от {y[2]} до -∞");
}
else if (GetQuerter == 4)
{
  Console.WriteLine($"X от {x[3]} до +∞");
  Console.WriteLine($"Y от {y[3]} до -∞");
}