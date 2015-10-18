using System;


    class Program
    {
        static void Main()
        {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        string result = "";
        int sum = 0;

        foreach (var item in message)
        {
            if (((int)item >= 'A' && (int)item <= 'Z')) //|| ((int)item >= 'A' && (int)item <= 'Z'))
            {
                sum = sum + ((int)item - 64);
            }
            else if ((int)item >= 'a' && (int)item <= 'z')
            {
                sum = sum + ((int)item - 96);
            }
            else
            {
                sum = sum + (int)item;
            }
        }
        string converted = Convert.ToString(sum, key);
        result = String.Concat(result, key.ToString());
        result = String.Concat(result, message.Length.ToString());
        result = String.Concat(result, converted);
        Console.WriteLine(result);
        }
    }
