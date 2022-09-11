//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число ");

string number = Console.ReadLine();
char num1 = number.ToString()[0];
char num2 = number.ToString()[1];
char num4 = number.ToString()[3];
char num5 = number.ToString()[4];
if (num1 == num5 & num2 == num4)
    {
        Console.WriteLine($"{number} является палиндромом");
    }
else
    {
        Console.WriteLine($"ERROR: не является палиндромом или введены некорректные данные: {number}");
    }