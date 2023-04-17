using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("2");
        }
    }
}
