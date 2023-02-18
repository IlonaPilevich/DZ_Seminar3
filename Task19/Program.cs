// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int test = number.Length;

if (test == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine(number + " - это пятизначное число Полиндром");
    }
    else
    {
        Console.WriteLine(number + " - это пятизначное число НЕ Полиндром");
    }
}