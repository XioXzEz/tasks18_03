using System;

class Program
{
    static void Main()
    {
        decimal procent = 0.07m;
        int i = 0;
        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        Console.Write("Введите сумму вклада: ");
        decimal summ = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите количество месяцев: ");
        int month = Convert.ToInt32(Console.ReadLine());
        decimal res = summ;
        while (i < month) 
        {
            res += res * procent;
            i++;
        }
        Console.WriteLine($"Итоговая сумма равна: {res:F2}");
    }
}