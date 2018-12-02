using System;

namespace Зад._360_стр._206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("въведи нещо произволно:"); string a = Console.ReadLine();
            FoundInteger(a);
        }
        static void FoundInteger(string str)
        {
            int intValue;
            bool parseSuccess = Int32.TryParse(str, out intValue);
            Console.WriteLine(parseSuccess ? "числото е: " + intValue + "." : "въведеният низ е идентификатор");
        }
    }
}
