// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int  PrintArray{}

{
Console.WriteLine("Введите количество строк - ");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов - ");
int colimns = int.Parse(Console.ReadLine());

int[,] array = new int[lines,colimns];

Console.Write(array);
//PrintArray(array);

}




// Console.WriteLine("Введите колличесвто строк: ");
// int userRow = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов: ");
// int userColumn = int.Parse(Console.ReadLine());

// int[,] array = GetArray(userRow,userColumn);
// PrintArray(array);

// int[,] ChangeArrayString(int[,] array)
// {
//     int[,] flipArray = new int[userRow, userColumn];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             flipArray[i, j] = array[j, i];
//         }
//     }
//     return flipArray;
// }

// int[,] flipArray = ChangeArrayString(array);
// Console.WriteLine();
// PrintArray(flipArray);
