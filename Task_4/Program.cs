// Напишите программу , которая на вход принимает число (N) ,а на выходе
// показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
for (int Y = 1; Y <= N; Y++)
{
    if (Y % 2 == 0)
    {
        Console.Write(Y + " ");
    }
}