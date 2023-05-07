// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] EvenNumber(int[] massive)
{
    int sum = 0;
    for (int i = 1; i < massive.Length; i = i + 2)
            sum = sum + massive[i];
            Console.WriteLine(" Сумма элементов на нечетных позициях: {0}", sum);
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

int[] array = MakeRandomArray(4, 1, 1000);
Console.Write($"{String.Join(", ",array)}");
int[] massive = EvenNumber(array);

