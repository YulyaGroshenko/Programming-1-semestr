using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");

            var factorial = Convert.ToUInt32(Console.ReadLine());
       
            IsOutput(CountFactorial(factorial));
           
        }
        static ulong CountFactorial(uint factorial)
        {
            if (factorial == 0)
            {
                return 1;
            }
            else
            {
                return factorial * CountFactorial(factorial - 1);
            }
        }
        static void IsOutput(ulong factorial)
        {
            while (true)
            {
                string str = $"║ {factorial} ║";
                Print('╔', '═', '╗', str);
                Console.WriteLine(str);
                Print('╚', '═', '╝', str);
                ChangeColor(Console.ForegroundColor, Console.BackgroundColor);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        static void Print(char left, char middle, char right, string str)
        {
            Console.Write(left);
            Console.Write(new string(middle, str.Length - 2));
            Console.WriteLine(right);
        }
        static void ChangeColor(ConsoleColor fore, ConsoleColor back)
        {
            ConsoleColor change = fore;
            fore = back;
            back = change;
            Console.ForegroundColor = fore;
            Console.BackgroundColor = back;
        }
        
    }
}