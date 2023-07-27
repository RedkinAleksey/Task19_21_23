// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное целое число.");
int number = Convert.ToInt32(Console.ReadLine());

int numberPozitiv = Pozitiv(number);
if (numberPozitiv < 10000 || numberPozitiv > 99999)
{
    Console.WriteLine("Данные некорректны.");
}
else
{
    Console.WriteLine(Palindrome(numberPozitiv) ? $"Число {number} является палиндромом." :
                                                 $"Число {number} не является палиндромом.");
}

bool Palindrome(int num)
{ 
    int firstDigit = num / 10000;
    int secondDigit = num/ 1000 % 10;
    int fourthDigit = num / 10 % 10;
    int fifthDigit = num % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}

int Pozitiv(int numb)
{
    if (numb < 0) 
    {
        return numb * -1;
    }
    else
    {
        return numb;
    }
}
