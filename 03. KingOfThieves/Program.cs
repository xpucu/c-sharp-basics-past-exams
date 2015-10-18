using System;
using System.Linq;

class Diamond
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string symbol = Console.ReadLine();
        string filler = "-";
        //nt symbolSize = 0;
        int fillerSize = 0;
        string myLine = "";

        for (int i = 1; i <= size; i = i + 2)
        {
            fillerSize = (size - i) / 2;
            myLine = String.Concat(Enumerable.Repeat(filler, fillerSize)) + String.Concat(Enumerable.Repeat(symbol, i)) + String.Concat(Enumerable.Repeat(filler, fillerSize));
            Console.WriteLine(myLine);

        }
        for (int j = (size - 2); j >= 1; j = j - 2)
        {
            fillerSize = (size - j) / 2;
            myLine = String.Concat(Enumerable.Repeat(filler, fillerSize)) + String.Concat(Enumerable.Repeat(symbol, j)) + String.Concat(Enumerable.Repeat(filler, fillerSize));
            Console.WriteLine(myLine);

        }
        //frames = String.Concat(Enumerable.Repeat("*", 10))



        //        1.wzimame purvonachalnata broika simboli
        //2.izvajdame 1 i go risuwame simvola
        //3.ostanaloto delim na 2
        //4.rezultata se slaga otliavo i otdiasno na simvola

        //1.ot purvonachalnata broika simvoli izvajdame 1 + 2
        //2.printirame tova ot purva stupka sys simbola
        //3.ostanaloto delim na 2
        //4.rezultata se slaga otliavo i otdiasno na simvola

        //1. 1 + 2 + 2
        //2,3 ,4 stupka gi povtariame

        //1.se povtaria dokato broikata chars stane ravna na max size


        //1.ot max vadim 2 i go printirame.ostatuka go delim na dve i go slagame otliavo i otdiasno

        //povtariame deistvieto , kato vadim 2 ot rezultata . pstatuka delim na 2 i go slagame otliavo i otdiasno

        //kogato ostane 1 simvol , prikliuchvame
    }
}