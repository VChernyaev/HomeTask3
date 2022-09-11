// программа которая принимает на вход число и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 1;
void GetDashboard (int num1)
{
   
    while(count<=num1)
    {
        Console.WriteLine($"Квадрат числа {count} = {count*count*count}");
        count++;
    }


}
GetDashboard(num1);