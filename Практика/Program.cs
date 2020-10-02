using System;
using System.Threading;

namespace Практика
{
    class Program
    {
        const int arraysize = 10000;
        const int timesleep = 300;
        public static int ReadDelay()
        {
            int x;
            Console.WriteLine("Введите период задержки");
            do
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введено неверное значениею.");
                }
            } while (true);
            return x;
        }

        private static void Method(string x)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(x);
            Thread.Sleep(timesleep);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(x);
            Thread.Sleep(timesleep);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(x);
            Thread.Sleep(timesleep);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(x);
            Thread.Sleep(timesleep);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static string[] TextReading()
        {
            Console.WriteLine("Введите текст. Для прекращения ввода, введите 0.");
            string[] x = new string[arraysize];
            for (int i = 1; i < arraysize; i++)
            {
               x[i] = Console.ReadLine();
                if (x[i] == "0")
                {
                    x[0] = Convert.ToString(i);
                    break;
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            string[] ar = Program.TextReading();
            int delay = ReadDelay();
            int laststr = Convert.ToInt32(ar[0]);

            Console.Clear();

            for(int i = 1; i < laststr; i++)
            {
                string str = ar[i];

                for (int z = 0; z < str.Length; z++)
                {
                    Console.Write(str[z]);
                    Thread.Sleep(delay);
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter");
                do
                {
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Enter)
                    {
                        Method(ar[i]);
                        break;
                    }
                } while (true);
                
            }
        }
    }
}
