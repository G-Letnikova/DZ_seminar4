// задача 25____вводим два числа А и В, возводим А в степень В

Console.Clear();
Console.Write("Введите 1-ое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
double degree = a;

if (b>0)
{
    for (int i = 1; i<b; i++)
    degree = degree * a;
}
else
{
    degree = 1/a;
    for (int i = 1; i<(-1*b); i++)
    degree = degree/a;
}
if (a<0 && degree>0) degree = -1 * degree;

Console.WriteLine($"{a} в степени {b} = {Math.Round(degree,3)}");
