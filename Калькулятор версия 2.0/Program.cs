using System;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace Калькулятор_версия_2._0
{
    class Program
    {
        static void Main()
        {
            CheckCorrect();
        }
        static string OpenFile()
        {
            FileStream file = File.OpenRead(@"..\..\..\..\Input.txt"); //открытие файла

            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length);
            string exampleFromFile = System.Text.Encoding.Default.GetString(array); //перевод в строку
            return exampleFromFile;
        }
        static string[] SplitExample()
        {
            string op = OpenFile();
            string[] str = op.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //удаление пробелов
            return str;
        }
            
        static void CheckCorrect()
        {
            string[] str = SplitExample();

            int firstNum = Convert.ToInt32(str[0]);
            char operation = Convert.ToChar(str[1]);
            int secondNum = Convert.ToInt32(str[2]);

            if (firstNum > 0 && (operation == '+' || operation == '-' || 
                operation == '*' || operation == '/') && secondNum > 0)
            {
                CorrectOutput();
            }
            else
            {
                UncorrectOutput();
            }
            
        }
        static string Calculate()
        {
            string[] str = SplitExample();

            int firstNum = Convert.ToInt32(str[0]);
            char operation = Convert.ToChar(str[1]);
            int secondNum = Convert.ToInt32(str[2]); //конверт чисел и операции

            if (operation == '+')
            {
                return Convert.ToString(firstNum + secondNum);
            }
            else if (operation == '-')
            {
                return Convert.ToString(firstNum - secondNum);
            }
            else if (operation == '*')
            {
                return Convert.ToString(firstNum * secondNum);
            }
            else
            {
                if (secondNum == 0)
                {
                    return "На ноль делить нельзя";
                }
                else
                {               
                    return Convert.ToString((double)firstNum / secondNum);
                } 
            }

        }
        static void CorrectOutput()
        {
            using (StreamWriter output = new StreamWriter(@"..\..\..\..\Output.txt", false, System.Text.Encoding.Default))
            {
                output.WriteLine(Calculate());
            }
        }
        static void UncorrectOutput()
        {
            using (StreamWriter output = new StreamWriter(@"..\..\..\..\Output.txt", false, System.Text.Encoding.Default))
            {
                output.WriteLine("Некорректный ввод");
            }
        }
    }
}
