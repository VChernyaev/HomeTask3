// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
CheckNumber(number);

void CheckNumber (string num)
{
    if (num[0]==num[4] && num[1]==num[3])
    {
        Console.WriteLine($"число {num} - палиндром");
    }
    else
    {
        Console.WriteLine($"число {num} - не палиндром");
    }

    
}
