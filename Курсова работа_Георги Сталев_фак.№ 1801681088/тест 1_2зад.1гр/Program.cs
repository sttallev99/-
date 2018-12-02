using System;

namespace тест_1_2зад._1гр
{
    class Program
    {
        static void Main(string[] args)
        {
            //да се запише според правилата на C# изразът:
            int x = 0;
            int y = 0;
            int z = 0;
            Console.Write("Math.Pow(x, 7) * y * z - 3 * 3 * Math.Abs(x + Math.Pow(Math.Sqrt(y),4)) / Math.Pow(10, 7) + Math.Log(4)");
            Console.WriteLine(Math.Pow(x, 7) * y * z - 3 * 3 * Math.Abs(x + Math.Pow(Math.Sqrt(y), 4)) / Math.Pow(10, 7) + Math.Log(4));
        } 
    }
}

