// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int max = 0;
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
  max = number1;
   Console.Write("max = ");
   Console.WriteLine(max);
}
else
{
  max = number2;
  Console.Write("max = ");
  Console.WriteLine(max);
}
