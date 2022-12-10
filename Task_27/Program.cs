// задача 27____вводим число n, выводим сумму чисел из которых состоит n

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 

while(n<0)
{
   Console.Write("Ошибка!\nВведите положительное число: ");
    n = Convert.ToInt32(Console.ReadLine()); 
}
int result = 0, k = n;
while (k>10)
{
    result = result + k%10;
    k=k/10;
}
result = result + k;
Console.WriteLine($"Сумма цифр числа {n} = {result}");
