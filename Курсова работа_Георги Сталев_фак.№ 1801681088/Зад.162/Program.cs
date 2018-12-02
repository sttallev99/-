using System;

namespace Зад._162
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("въведи число за Х="); int x = int.Parse(Console.ReadLine());
            Console.Write("въведи число за Y="); int y = int.Parse(Console.ReadLine());
            Cor(x, y);
            Console.WriteLine();
            Console.Write("въведи число за p="); int p = int.Parse(Console.ReadLine());
            cor2(p);
        }
       static void Cor(int x,int y)
        {
          int b = Math.Abs(x) * Math.Abs(y) / x + y;
            if (x!=(-y) && b==0)
            {
                Console.WriteLine(b);
            } 
            else
            {
                Console.Write("въведи число за p="); int p=int.Parse(Console.ReadLine());
                Console.Write("въведи число за q="); int q = int.Parse(Console.ReadLine());
                bool IsvalidatePQ = ValidateP(p) && ValidateQ(q);
                Console.WriteLine("="+Cor1(p,q));
                Console.WriteLine("извежда и отпечатва тези стойности на редицата които са цели четни цисла:");
                cor2(p);
            }
        }
       static bool ValidateP (int p)
        {
            bool result = (p >= -30) || (p <= 30);
            if (result)
            {

            }
            else
            {
                Console.WriteLine("Въведи число в границите [-30;30]");
            }
            return result;
        }
        static bool ValidateQ(int q)
        {
            bool result = (q >= -30) || (q <= 30);
            if (result)
            {

            }
            else
            {
                Console.WriteLine("Въведи число в границите [-30;30]");
            }
            return result;
        }
        static int Cor1(int p,int q)
        {
            int c = ((Math.Abs(p) * 3 * Math.Abs(q) / p + 3 * q) - (3 * Math.Abs(p) * Math.Abs(q) / 3 * p + q)) / Math.Abs(p) * Math.Abs(q) / p + q;
            return c;
        }
        static void cor2(int p,int q=10)
        {
            int c = ((Math.Abs(p) * 3 * Math.Abs(q) / p + 3 * q) - (3 * Math.Abs(p) * Math.Abs(q) / 3 * p + q)) / Math.Abs(p) * Math.Abs(q) / p + q;
            for (int i = q; i <= 50; i+=4)
            {
               
                if (c%2==0)
                {
                    Console.Write(c+" ");
                }
            }
       
        }

    }
}
