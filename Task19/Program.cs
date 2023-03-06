// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (IsFiveDigit(num))
{
    string output = IsPalindrome(num) ? $"Число {num} является палиндромом" : $"Число {num} не является палиндромом";
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}


bool IsFiveDigit(int number)
{
    if (number < 0) number = -number;
    if (number >= 10000 && number < 100000) return true;
    else return false;
}

bool IsPalindrome(int fiveDigitNumber)
{
    if (fiveDigitNumber / 10000 == fiveDigitNumber % 10 && fiveDigitNumber / 1000 % 10 == fiveDigitNumber % 100 / 10) return true;
    else return false;
}