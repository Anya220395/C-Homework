/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число больше 1: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
while (count <= number)
{
    int FoundNumber = count % 2;
    if (FoundNumber == 0)
    {
        Console.Write($"{count} ");
        count++;
    }
    else count++;
}
