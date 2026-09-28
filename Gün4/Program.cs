using System;

namespace Gun4
{
    internal class Program
    {
        static decimal CalculateBonus(int workHours)
        {
            if (workHours < 160) return 0;
            if (workHours <= 180) return 1500;
            if (workHours <= 200) return 3000;
            return 5000;
        }

        static void Main()
        {
            Console.Write("Çalışan adı: ");
            string name = Console.ReadLine();
            Console.Write("Temel maaş: ");
            decimal baseSalary;
            if (!decimal.TryParse(Console.ReadLine(), out baseSalary) || baseSalary < 0) return;
            Console.Write("Çalışma saati: ");
            int hours;
            if (!int.TryParse(Console.ReadLine(), out hours) || hours < 0) return;

            decimal bonus = CalculateBonus(hours);
            Console.WriteLine($"{name}: temel maaş {baseSalary:C}, prim {bonus:C}, toplam {baseSalary + bonus:C}");
        }
    }
}
