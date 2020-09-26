using System;
using System.Runtime.CompilerServices;

namespace chess
{
    class Program
    {
        static int Charconver(string x)
        {
            int startpositioncode = 0;
            string y = "0"; 
            string z = "0";
            try
            {
                y = Convert.ToString((int)Convert.ToChar(x[0]));
                z = Convert.ToString((int)Convert.ToChar(x[1]));
            }
            catch
            {
                Console.WriteLine("Ошибка ввода");
            }
            string promez = y + z;
            startpositioncode = Convert.ToInt32(promez);
            return startpositioncode;
        }

        static int count()
        {
            Console.WriteLine("Введите стартовую позицию на поле");
            int x = Read();
            Console.WriteLine("Введите финишную позицию на поле");
            int y = Read();
            int z = Math.Abs(x - y);
            return z;
        }

        static bool horse(int x) // Конь
        {
            return ((x - 102 == 0) || (x - 98 == 0));
        }

        static bool queen(int x) // Королева
        {
            return (elephant(x) || rook(x));
        }

        static bool pawn(int x) // Пешка
        {
            return (x - 1 == 0);
        }

        static bool king(int x)
        {
            return ((x - 100 == 0) || (x - 101 == 0) || (x - 1 == 0));
        } 

        static bool rook(int x)
        {
            return (x % 100 == 0 || (x < 8 && x > 0));
        }

        static bool elephant(int x)
        {
            return (x % 101 == 0 || x % 99 == 0);
        }

        static int Read()
        {
            int x;
            string y;
            do
            {
                y = Console.ReadLine();
                x = Charconver(y.ToUpper());
                if ((x > 6548) && (x < 7257) && (x % 100 < 57) && (x % 100 > 48))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Такой позиции не существует");
                }
            } while (true);
            return x;
        }

        static int Converta()
        {
            int c;
            do
            {
                try
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c < 7 && c > 0)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Некоректный ввод");
                }
            } while (true);
            return c;
        }

        static bool function(int chesspieces, int z)
        {
            bool b = false;
            switch (chesspieces)
            {
                case 1:
                    b = pawn(z);
                    break;
                case 2:
                    b = horse(z);
                    break;
                case 3:
                    b = elephant(z);
                    break;
                case 4:
                    b = queen(z);
                    break;
                case 5:
                    b = king(z);
                    break;
                case 6:
                    b = rook(z);
                    break;
                default:
                    Console.WriteLine("Такой фигуры не существует");
                    break;
            }
            return b;
        }
        static void Main()
        {
            string[] a = new string[6] {"пешка", "конь", "слон", "королева", "король", "ладья"};
            int chesspiece;
            Console.WriteLine("Выберите фигуру");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("[{0}] - {1}", i, a[i]);
            }
            chesspiece = Converta();
            int z = count();
            if (function(chesspiece, z) == true)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }
    }
}