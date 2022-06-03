// Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num %7 == 0 && num %23 == 0 ? "Да" : "Нет");

// if(num %7 == 0 && num %23 == 0) Console.Write("да");
// else
// {
//   Console.Write("Нет");  
// } 