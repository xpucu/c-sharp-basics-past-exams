using System;




class Program
{
    static void Main()
    {
        decimal priceOfTV = decimal.Parse(Console.ReadLine());
        double term = double.Parse(Console.ReadLine());
        decimal bankInterest = decimal.Parse(Console.ReadLine());
        decimal friendInterest = decimal.Parse(Console.ReadLine());
        decimal owedBank = 0m;
        decimal owedFriend = 0m;

        owedBank = priceOfTV * (decimal)Math.Pow((1.00d + (double)bankInterest), term);
        owedFriend = priceOfTV * (1 + Convert.ToDecimal(friendInterest));
        if (owedBank < owedFriend)
        {
            Console.WriteLine(String.Format("{0:0.00} Bank", owedBank));
        }
        else
        {
            Console.WriteLine(String.Format("{0:0.00} Friend", owedFriend));
        }
        //'FV = PV * (1 + i)n

    }
}


//1. смятаме дължимата сума на банката
//2. изчислявамесумата за връщане на приятля
//3. ако сумата на банката е по-малка от сумата на приятля , избираме банкатъ
//4. ако сумата на е приятеля е по-малка или равна от сумата на банкатъ , избираме приятля