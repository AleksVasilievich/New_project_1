// Напишите программу,которая на вход принимает два числа 
// и выдаёт какое число большее , а какое меньшее.
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
  Console.WriteLine("первое число - большее , второе число - меньшее");
}
else
{
   Console.WriteLine("второе число - большее , первое чтсло - меньшее"); 
}
Console.ReadKey();
