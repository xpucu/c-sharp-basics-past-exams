using System;


    class Program
    {
        static void Main()
        {

        string yearType = Console.ReadLine();
        int monthsContracts = int.Parse(Console.ReadLine());
        int monthsFamily = int.Parse(Console.ReadLine());
        int monthNormal = 12 - (monthsContracts + monthsFamily);
        //double travel = 0d;

        int monthsContractsCnt = 4 * 3 *  monthsContracts;
        int monthsFamilyCnt = 2 * 2 * monthsFamily;
        double monthsNormalCnt = 4 * 3 * monthNormal  * 3 / 5.0;

        double total = monthsContractsCnt + monthsFamilyCnt + monthsNormalCnt;
        if (yearType == "leap")
        {
            total = total * 1.05;
            //total = Convert.ToInt32(total);

        }

        Console.WriteLine((int)total);


    }


    }
