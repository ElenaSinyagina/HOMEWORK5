// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createArray(int length)
{
    var random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-10, 10);

    return array;
}
int sum(int[] array)
{
    var result = 0;
    for (long i = 1; i < array.Length; i = i + 2)
        result += array[i];
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
var array = createArray(length);
printArray(array);
Console.WriteLine();
Console.WriteLine("Cумма элементов на нечётных позициях:");
Console.WriteLine(sum(array));