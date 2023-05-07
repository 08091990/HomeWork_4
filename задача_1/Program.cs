// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] EvenNumber(int[] massive)
{
    int num = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            num = num + 1;
        }
        Console.WriteLine(" Количество четных чисел в массиве: {0}", num);
    }
return massive;
}

int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue);
    }
    return massive;
}

int[] array = MakeRandomArray(4, 100, 1000);
Console.Write($"{String.Join(", ",array)}");
int[] massive = EvenNumber(array);





