using System;

namespace зад._415_стр._224
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("въведи брой елементи в масива="); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("масив А");
            int[] A = new int[n];
            Console.WriteLine("Въвеждане елементите на масив А");
            Masiv(A);
            Console.WriteLine("произведението на всички елемети в масива които се делят на 3 без остатък и са в границите (0,50]="+ProductArrInMasiv(A)); 

            Console.WriteLine("масив B");
            int[] B = new int[n];
            Console.WriteLine("Въвеждане елементите на масив B");
            Masiv(B);
            Console.WriteLine("произведението на всички елемети в масива които се делят на 3 без остатък и са в границите (0,50]=" + ProductArrInMasiv(B));

            Console.WriteLine("масив C");
            int[] C = new int[n];
            Console.WriteLine("Въвеждане елементите на масив C");
            Masiv(C);
            Console.WriteLine("произведението на всички елемети в масива които се делят на 3 без остатък и са в границите (0,50]=" + ProductArrInMasiv(C));
            Console.WriteLine("намиране на най-голямото произведение:");
            if (ProductArrInMasiv(A)>ProductArrInMasiv(B)&& ProductArrInMasiv(A)>ProductArrInMasiv(C))
            {
                Console.WriteLine("най-голямото произведение е:"+ProductArrInMasiv(A));
            }
            else if (ProductArrInMasiv(B) > ProductArrInMasiv(A) && ProductArrInMasiv(B) > ProductArrInMasiv(C))
            {
                Console.WriteLine("най-голямото произведение е:" + ProductArrInMasiv(B));
            }
            else if (ProductArrInMasiv(C) > ProductArrInMasiv(A) && ProductArrInMasiv(C) > ProductArrInMasiv(B))
            {
                Console.WriteLine("най-голямото произведение е:" + ProductArrInMasiv(C));
            }
            else
            {
                Console.WriteLine("Няма намерено най-голямо произведение");
            }

        }
        static void Masiv(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("input element[{0}]=", i); a[i] = int.Parse(Console.ReadLine());
            }            
        }



        static int ProductArrInMasiv(int[] b)
        {
            int prod = 1;
            for (int i = 0; i < b.Length; i++)
            {
                if ((b[i] % 3 == 0) && b[i] > 0 && b[i] <= 50)
                {
                    continue;

                }
                prod *= b[i];
            }            
            return prod;
        }
    }
}
