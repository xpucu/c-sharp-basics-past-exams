using System;



    class PeterGame
    {
        static void Main()
        {
            long numberStart = long.Parse(Console.ReadLine());
            long numberEnd = long.Parse(Console.ReadLine());
            string stringReplace = Console.ReadLine();
            long sum = 0L;
            string  sumString = "";
            string matchedDigit = "";
            string result ="";

            for (long i = numberStart; i < numberEnd; i++)
            {
                if ((i % 5) == 0)
                {
                    sum = sum + i;
                }
                else
                {
                    sum = sum + (i % 5);
                }
            }

            if (sum % 2 == 1)
            {
                sumString = sum.ToString();
                int indexDigit = (sumString.Length - 1);
                matchedDigit = (sumString[indexDigit]).ToString();

            }
            else
            {
                sumString = sum.ToString();
                matchedDigit = (sumString[0]).ToString();

            }
            foreach (var item in sumString)
            {
                if (item.ToString() == matchedDigit)
                { 
                    result = result + String.Concat(stringReplace);
                }
                else
                {
                    result = result  + String.Concat(item.ToString());
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(sumString);
            Console.WriteLine(matchedDigit);
        }
    }

