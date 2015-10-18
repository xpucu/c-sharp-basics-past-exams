using System;



    class Program
    {
        static void Main()
        {
            long numberRows = long.Parse(Console.ReadLine());
            long numberColumns = long.Parse(Console.ReadLine());
            int startVertical = int.Parse(Console.ReadLine());
            int startHorizontal = int.Parse(Console.ReadLine());
            long output = 0L;


            for (long i = 0; i < numberRows; i++)
            {
                for (long j = 0; j < numberColumns; j++)
                {
                    output = ((startVertical + i) * (startHorizontal + j));
                    Console.Write(output);
                    if ((j != numberColumns - 1) && (j <= 100))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("\n"); 
                        //return;
                    }
                }

                  
            }
        }
    }
