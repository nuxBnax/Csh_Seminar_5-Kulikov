// Задача 38: 

// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3.21 7.68 22.11 2 78] -> 76

void Main()
{
    double[] arr = FillArray(10, 100, 999);
    PrintArray(arr);
    System.Console.WriteLine($"Difference between MAX and MIN element of array: {FindDifferenceMaxMin(arr)}");
}

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1) + Math.Round(rand.NextDouble(), 2);
    }

    return tempArray;
}

double FindDifferenceMaxMin(double[] array)
{
    int i = 1;
    int max = 0;
    int min = 0;

    while (i < array.Length)
    {
        if (array[i] >= array[max])
        {
            max = i;
        }
        else
        {
            if (array[i] <= array[min])
            {
                min = i;
            }
        }
        i++;
    }
    return Math.Round(array[max] - array[min], 3);
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

Main();
