//Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.Readline());
int firstDigit = number / 10000;

int secondDigit = (number / 1000) - 10 * firstDigit;

int fifthDigit = number % 10;

int fourthDigit = ((number % 100) - fifthDigit) / 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    Console.WriteLine("Введенное число является палиндромом");
else
    Console.WriteLine("Введенное число не является палиндромом");
