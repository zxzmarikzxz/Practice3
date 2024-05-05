using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
///Пратика 3
namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            WriteLine("Для проверки на чётность введите число:");
            int number = int.Parse(ReadLine());
            if (number%2 == 0)
            {
                Write("Число чётное");
            }
            else
            {
                Write("Число нечётное");
            }
            WriteLine("\nДля перехода ко второму заданию нажмите Enter");
            ReadLine();
            Clear();
            //Задание 2
            WriteLine("Здравствуйте, введите количество карт у вас на руках");
            int number21 = int.Parse(ReadLine());
            int sum = 0;
            for (int i = 1; i <= number21; i++) 
            {
                WriteLine("Введите значения ваших карт");
                switch (ReadLine())
                {
                case "2": sum += 2; break;
                case "3": sum += 3; break;
                case "4": sum += 4; break;
                case "5": sum += 5; break;
                case "6": sum += 6; break;
                case "7": sum += 7; break;
                case "8": sum += 8; break;
                case "9": sum += 9; break;
                case "q": sum += 10; break;
                case "k": sum += 10; break;
                case "t": sum += 10; break;
                default: Write("Такого числа не существует в игре\n"); i--; break;       
                }
            }
            if (sum <= 21)
            {
                Write($"\n Сумма = {sum} Поздравляю, вы победили!");
            }
            else
            {
                Write($"\n Сумма = {sum} Сумма больше 21 вы проиграли");
            }

            WriteLine("\nДля перехода к третьему заданию нажмите Enter");
            ReadLine();
            Clear();
            //Задание 3
            WriteLine("Введите целое число\n");
            int fullNumber = int.Parse(ReadLine());
            int d = 2;
            int c;
            bool test;
            while (d <= fullNumber - 1)
            {
                c = fullNumber % d;
                
                if (c == 0)
                {
                    test = true;
                    WriteLine("Число не является простым");
                    break;
                    
                }
                else 
                {
                    test = false;
                    WriteLine("Число является простым");
                    break;
                }
                
            }
            WriteLine("\nДля перехода к четвёртому заданию нажмите Enter");
            ReadLine();
            Clear();
            //Задание 4
            WriteLine("Введите длину последовательности\n");
            int n = int.Parse(ReadLine()), min = int.MaxValue, valume;
            for (; n > 0; n--)
            {
                valume = int.Parse(ReadLine());
                min = min > valume ? valume : min;
            }
            WriteLine("Минимальное число = " + min);
            WriteLine("\nДля перехода к пятому заданию нажмите Enter");
            ReadLine();
            Clear();
            //Задание 5
            Random rand = new Random();
            WriteLine($"Введите максимальное число(Если устали играть просто нажмите Enter)");
            int count = 0;
            int maxNumber = int.Parse(ReadLine());
            int randomNumber = rand.Next(0, maxNumber);
            do
            {
                string str = ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    WriteLine($"Загаданное число = {randomNumber}");
                    ReadKey();
                    break;
                }
                else
                {
                    int userNumber = Convert.ToInt32(str);
                    count++;
                    if (userNumber > randomNumber)
                    {
                        WriteLine("Введёное число больше загаданного");
                    }
                    else if (userNumber < randomNumber)
                    {
                        WriteLine("Введёное число меньше загаданного");
                    }
                    else
                    {
                        WriteLine($"Поздравляю вы выиграли, загаданное число = {randomNumber}, количество попыток {count}");
                        ReadKey();
                        break;
                    }
                }
            }
            while (true);
        }
    }
}
