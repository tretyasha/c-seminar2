// Дано число. Проверить кратно ли оно 7 и 23

int number = Convert.ToInt32(Console.ReadLine());

if (number % 23 == 0 && number % 7 == 0)
    Console.WriteLine("Введенное число кратно 23 и 7");
else
    Console.WriteLine("Введенное число не кратно 23 и 7");
