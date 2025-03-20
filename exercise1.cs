using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        Console.Write("Введите сумму вклада: ");
        double summ = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите количество месяцев: ");
        double month = Convert.ToDouble(Console.ReadLine());
        double result = summ * month * 0.07;
        Console.WriteLine(result);
    }
}