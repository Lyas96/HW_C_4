/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int NumSum(int n)
{
  int sum = 0;
  int a = n;
  for(int i = 0; n > 0; i++)
  {
    a = n % 10;
    sum += a;
    n /= 10;
  }
  return sum;
}

Console.Write("Enter number N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Sum number {n} = {NumSum(n)}");