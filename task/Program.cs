// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string ReadString(string text)
{
    Console.Write(text);
    return Console.ReadLine()!;
}
void result(string text1)
{
    if (text1.Length == 5 && text1[0] + text1[1] == text1[3] + text1[4])
    {
        Console.Write($"пятизначное число является палеандромом");
    }
    else if (text1.Length == 5 && text1[0] + text1[1] != text1[3] + text1[4])
    {
        Console.Write($"пятизначное число не является палеандромом");
    }
    else
    {
        Console.Write($"введено не верное число");
    }
}
string palleandrom = ReadString("введите число - > ");
result(palleandrom);