using System;



class Program
{
    static void Main()
    {
        //char penka = 'o';
        //Console.WriteLine( ((int)penka));
        int n;
        string InputSting;
        n = int.Parse(Console.ReadLine());
        InputSting = Console.ReadLine();
        //Console.WriteLine((InputSting));
        int iteration = 0;
        int black = 0;
        int white = 0;
        int square = n * n;
        //foreach (var InputSting[item] in InputSting)
        for (int item = 0; item < InputSting.Length; item++)
        // (InputSting[item] >= 65 && InputSting[item] <= 90) || 
        {
            if (item >= square)
            {
                break;
            }
            else if ((InputSting[item] >= 48 && InputSting[item] <= 57) || (InputSting[item] >= 97 && InputSting[item] <= 122))
            {
                //Console.WriteLine((int)InputSting[item]);
                if ((iteration % 2) == 0 || iteration == 0)
                {
                    black = black + ((int)InputSting[item]);
                    iteration++;
                }


                else
                {
                    white = white + ((int)InputSting[item]);
                    iteration++;
                }
                //Console.WriteLine((int)InputSting[item]);
            }
            else if ((InputSting[item] >= 65 && InputSting[item] <= 90) && ((iteration % 2) == 0 || iteration == 0))
            {
                white = white + ((int)InputSting[item]);
                iteration++;
            }
            else if ((InputSting[item] >= 65 && InputSting[item] <= 90) && ((iteration % 2) != 0 || iteration != 0))
            {
                black = black + ((int)InputSting[item]);
                iteration++;
            }
            else
            {
                iteration++;
                //Console.WriteLine(0);
            }


            //Console.WriteLine(InputSting[0]);



        }
        //Console.WriteLine(black);
        //Console.WriteLine(white);
        if (black > white)
        //Console.WriteLine(Math.Abs(black-white));
        {
            Console.WriteLine("The winner is: black team");
            Console.WriteLine(black - white);
        }

        else if (white > black)
        {
            Console.WriteLine("The winner is: white team");
            Console.WriteLine(white - black);
        }
        else
        {
            Console.WriteLine("Equal result: {0}", white);
        }

    }
}
