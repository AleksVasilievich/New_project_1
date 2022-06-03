

// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


// Console.WriteLine("Введите колличесвто строк: ");
// int userRow = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов: ");
// int userColumn = int.Parse(Console.ReadLine());








// int [,] array = GetArray(userRow, userColumn);
// PrintArray(array);
//___________________________________________________________________________________________

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] arr = GetArray(5, 7);
PrintArray(arr);


int MinMax(int[,] array)
{
    int min = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = array[0, 0];
            if (min < array[i, j])
            {
                min = array[i, j];
                Console.Write(array[i, j]);
            }
        }
    }
}
MinMax[i,j];


//int[,] arr = GetArray(5,7);
//PrintArray(arr);


