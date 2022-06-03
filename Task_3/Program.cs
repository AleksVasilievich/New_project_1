// Напишите программу которая на вход принимает число и выдаёт ,
// является ли число чётным.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0 )
{
  Console.WriteLine("Введённое число - чётное"); 
  Console.ReadKey();
}
else
{
    Console.WriteLine("Введённое число - не чётное");
    Console.ReadKey();
}

