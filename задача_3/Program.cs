// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] EvenNumber(int[] massive)
{ 
    int max = massive[0];
    int min = massive[0];
    int difference = 0;
    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] > max)
        {
            max = massive[i];
        }

        if (massive[i] < min)
        {
            min = massive[i];
        }
        difference = max - min;
        Console.WriteLine(" Разницу между максимальным и минимальным элементом массива: {0}", difference);
    }
    return massive;
}

int[] MakeRandomArray(int size, int min, int max)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(1,100);
    }
    return massive;
}

int[] array = MakeRandomArray(5, 1, 100);
Console.Write($"{String.Join(", ",array)}");
int[] massive = EvenNumber(array);

