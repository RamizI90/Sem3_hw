// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string? numberstring = Console.ReadLine();
if (numberstring!.Length == 5)

    if (numberstring[0] == numberstring[4]&&numberstring[1] == numberstring[3])
    {
        Console.WriteLine("Число: " + numberstring + " является полиндромом");
    }

    else
    {
        Console.WriteLine("Число не является полиндромом");
    }

else
{
    Console.WriteLine("Вы ввели неверное число, введите пятизначное число!");
}
