using System;

namespace Variant_1
{
    class Program
    {
        static void Main()
        {
            int rows = 5;
            int cols = 5;

            int[,] array = new int[rows, cols];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(10, 100);
                }
}

Console.WriteLine("Исходный массив:");
PrintArray(array);

for (int i = 0; i < rows; i++)
{
    int maxIndex = 0;

    for (int j = 1; j < cols; j++)
    {
    if (array[i, j] > array[i, maxIndex])
    {
    maxIndex = j;
    }
}

    int temp = array[i, 0];
    array[i, 0] = array[i, maxIndex];
    array[i, maxIndex] = temp;


Console.WriteLine("Измененный массив:");
PrintArray(array);

}
