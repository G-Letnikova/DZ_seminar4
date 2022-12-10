// задача 29____вводим кол-во элементов, вводим сами элементы, записываем в массив, выводим на экран
 
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for (int i = 0; i < array.Length; i++)
{
   Console.Write($"Введите элемент {i+1} массива: "); 
   array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");

