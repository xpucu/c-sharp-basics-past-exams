using System;
using System.Linq;



    class Sunlight
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string firstLastLine = "";
            //string symbolSun = "*";
            //string symbolAir = ".";
            int lines = 0;
            int linesTotal = size * 3;

            firstLastLine = String.Concat(Enumerable.Repeat(".", ((linesTotal - 1) / 2))) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", ((linesTotal - 1) / 2)));
            Console.WriteLine(firstLastLine);
            lines++;
            for (int i = 1; i < size; i++)
            { 
                //console.writeline("{0}", new string("*", 3))
                string lineContents = String.Concat(Enumerable.Repeat(".", i)) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", ((linesTotal - (2 * i) - 3) / 2))) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", (linesTotal - (2 * i) - 3) / 2)) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", i));
                Console.WriteLine(lineContents);
            }

            for (int j = 0; j < ((size - 1) / 2); j++)
            {
                //Console.WriteLine(((size - 1) / 2));
                Console.WriteLine(String.Concat(Enumerable.Repeat(".", size)) + String.Concat(Enumerable.Repeat("*", size)) + String.Concat(Enumerable.Repeat(".", size)));
            }
                //Console.WriteLine(firstLastLine);
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", linesTotal)));

            for (int j = 0; j < ((size - 1) / 2); j++)
            {
                //Console.WriteLine(((size - 1) / 2));
                Console.WriteLine(String.Concat(Enumerable.Repeat(".", size)) + String.Concat(Enumerable.Repeat("*", size)) + String.Concat(Enumerable.Repeat(".", size)));
            }
            for (int i = 1; i < size; i++)
            {
                //console.writeline("{0}", new string("*", 3))
                string lineContents = String.Concat(Enumerable.Repeat(".", (size - i))) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", ((linesTotal - 3 - (2 * (size - i))) / 2))) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", ((linesTotal - 3 - (2 * (size - i))) / 2))) + String.Concat("*") + String.Concat(Enumerable.Repeat(".", (size - i)));
                Console.WriteLine(lineContents);
            }
            Console.WriteLine(firstLastLine);
        }
    }

