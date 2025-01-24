using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Сума двох чисел: {sum}");
    }
}