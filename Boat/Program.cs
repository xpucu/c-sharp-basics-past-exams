using System;
using System.Linq;



    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int sizeBody = (size - 1) / 2;
            string lineUp = "";
            string lineUpTwo = "";
            string lineDown = "";
            //String.Concat(Enumerable.Repeat(filler, fillerSize)) 
            int cnt = 0;

            for (int i = 0; i < size; i+=2)
            {
                lineUp = String.Concat(Enumerable.Repeat(".", (((size - 1) - i)))) +String.Concat(Enumerable.Repeat("*", (size - ((size - 1) -i) ))) + String.Concat(Enumerable.Repeat(".", size));
                Console.WriteLine(lineUp);
                cnt = cnt + 2;
            }
            for (int j = 1 ; j <= (size -1) /2; j++)
            {
               lineUpTwo = String.Concat(Enumerable.Repeat(".", (2 * j))) + String.Concat(Enumerable.Repeat("*", (size - (2 * j)))) + String.Concat(Enumerable.Repeat(".", size));
            Console.WriteLine(lineUpTwo);
            }

        for (int k = 0; k < sizeBody; k++)
        {
            lineDown = String.Concat(Enumerable.Repeat(".", k)) + String.Concat(Enumerable.Repeat("*", ((size * 2) - (2 * k)))) + String.Concat(Enumerable.Repeat(".", k));
            Console.WriteLine(lineDown);
        }
           // lineDown = String.Concat(Enumerable.Repeat("*", size * 2));
           // Console.WriteLine(lineDown);
         }
    }

