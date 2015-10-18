using System;


class Program
{
    static void Main()
    {
        int i, Pages, DaysNoRead, PgsPDay;
        Pages = int.Parse(Console.ReadLine());
        DaysNoRead = int.Parse(Console.ReadLine());
        PgsPDay = int.Parse(Console.ReadLine());
        if (DaysNoRead == 30)
        {
            Console.WriteLine("never");
            return;
        }
        int ReadyingDays = (30 - DaysNoRead);
        int PgsPMonth = (PgsPDay * ReadyingDays);
        double total = Math.Ceiling((Convert.ToDouble(Pages) / Convert.ToDouble(PgsPMonth)));
        int years = (Convert.ToInt32(total) / 12);
        int monts = (Convert.ToInt32(total) % 12);
        Console.WriteLine("{3} years {4} months", ReadyingDays, PgsPMonth, total, years, monts);


    }
}