//________решение СУПЕРСДВИГа через функции_____________
 
void StepLeft(int[] arr)                      // сдвиг массива на шаг влево
{
    int temp = arr[0];
    for (int i = 1; i < arr.Length; i++)
        arr[i - 1] = arr[i];
    arr[arr.Length - 1] = temp;
}
void StepRight(int[] arr)                    // сдвиг массива на шаг вправо
{
    int temp = arr[arr.Length - 1];
    for (int i = arr.Length - 2; i >= 0; i--)
        arr[i + 1] = arr[i];
    arr[0] = temp;
}
void FillArray(int[] col, int lenghArr)     // заполнение массива с консоли
{
    int index = 0;
    for (index=0; index<lenghArr; index++)
    {
        Console.Write($"Введите {index + 1}-й элемент массива: ");
        col[index] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[] arrayIn = new int[lengthArray];

FillArray(arrayIn,lengthArray);

Console.Write("Введите число-сдвиг массива: ");
int k = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(k) > lengthArray) k %= lengthArray;

Console.WriteLine($"Было: [{string.Join(", ", arrayIn)}]");
Console.WriteLine($"Сдвиг: {k}");

int j = 0;
if (k > 0)
{
    for (j = 0; j < k; j++)
        StepRight(arrayIn);
}
else
{
    for (j = 0; j < Math.Abs(k); j++)
        StepLeft(arrayIn);
}

Console.WriteLine($"Стало: [{string.Join(", ", arrayIn)}]");
