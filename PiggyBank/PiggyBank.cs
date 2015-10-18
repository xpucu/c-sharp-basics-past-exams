using System;



    class PiggyBank
    {
        static void Main()
        {
            double priceOfTank = double.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            int normalDays = 30 - partyDays;
            double sumPerMonth = (2 * normalDays) - (5 * partyDays);
            double total = Math.Ceiling(priceOfTank / sumPerMonth);
           // Console.WriteLine(total);
            int years = Convert.ToInt32(total) / 12;
            int months = Convert.ToInt32(total) % 12;
          //  Console.WriteLine(months);
            if ((5 * partyDays) >= (2 * normalDays))
            {
                Console.WriteLine("never");
            }

            else
            {
                Console.WriteLine("{0} years, {1} months", years, months);
            }
            
           

            //Console.WriteLine(sumPerMonth);





        }
    }

