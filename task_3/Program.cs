/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] Array(int elem)
{
  int[] mass = new int[elem];
  for(int i = 0; i < elem; i++)
  {
    mass[i] = new Random().Next(0, 100);
  }
return mass;
  }

  Console.Clear();
  int[] array = Array(8);
  Console.WriteLine($"[{String.Join(",", array)}]");

