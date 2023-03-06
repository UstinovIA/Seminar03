// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsNatural(number))
{
    TableCube(number);
}
else
{
    Console.WriteLine("Введено не натуральное число");
}


bool IsNatural(int N)
{
    if (N > 0) return true;
    else return false;
}

void TableCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i,5}    {i * i * i,5}");
    }
}