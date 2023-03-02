Console.WriteLine("Введите пятизначное число:");

int number = int.Parse(Console.ReadLine());

int firstDigit = number / 10000;
int secondDigit = (number - firstDigit * 10000) / 1000;
int thirdDigit = (number - firstDigit * 10000 - secondDigit * 1000) / 100;
int fourthDigit = (number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100) / 10;
int fifthDigit = number - firstDigit * 10000 - secondDigit * 1000 - thirdDigit * 100 - fourthDigit * 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    Console.WriteLine("Вы ввели палиндром!");
else
    Console.WriteLine("Число не палиндром"!);
