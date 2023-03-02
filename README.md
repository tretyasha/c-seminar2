# c-seminar2
// Дано число. Проверить кратно ли оно 7 и 23

int number = Convert.ToInt32(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
    Console.WriteLine("Введенное число кратно 23 и 7");
else
    Console.WriteLine("Введенное число не кратно 23 и 7");

// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите число X");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка в первой четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка во второй четверти");

}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка в третьей четверти");

}
else
{
    Console.WriteLine("Точка в четвертой четверти");
}

//Программа проверяет пятизначное число на палиндромом.
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
