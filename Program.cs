//Задача 2: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//Напримет: 4 -> да; -3 -> нет; 7 -> нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}
