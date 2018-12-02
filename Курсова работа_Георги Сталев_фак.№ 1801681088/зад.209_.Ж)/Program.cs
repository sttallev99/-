using System;

namespace зад._209_.Ж_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rank = new Random();
            for (int i = 0; i <= 100; i++)
            {
                int number = rank.Next(1, 133);
                if (number<26 || number>=100)
                {
                    Console.Write(number +" ");
                }
            }
        }
    }
}
