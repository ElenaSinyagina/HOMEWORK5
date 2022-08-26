// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine()!);

double[] createArray()
{
    Random random = new Random();

    double[] result = new double[length];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-10, 10);
    }
    return result;
}
void printArray(double[] array)
{
    Console.Write("[");

    for (long i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}
double[] array = createArray();
printArray(array);
Sort(array);
void Sort(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine("Максимальный элемент: " + max);
    Console.WriteLine("Минимальный элемент: " + min);
    double result = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + result);
}

