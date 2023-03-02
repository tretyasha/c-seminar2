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