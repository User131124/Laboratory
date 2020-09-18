using System;
using System.Runtime.CompilerServices;

namespace AgeCalculater
{
    class Program
    {
        public static void Main()
        {
            DateTime thisDay = DateTime.Today;
            int dayofbearth;
            int monthofbearth;
            int yearofbearth;
            int years;
            int[] months = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day = Convert.ToInt32(thisDay.ToString("dd"));
            int month = Convert.ToInt32(thisDay.ToString("MM"));
            int year = Convert.ToInt32(thisDay.ToString("yyyy"));
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Введите день своего рождения");
                        dayofbearth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите месяц своего рождения");
                        monthofbearth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите год своего рождения");
                        yearofbearth = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                } while (true);

                if (yearofbearth % 4 == 0 && monthofbearth == 2)
                {
                    ++months[1];
                }
                if (monthofbearth < 13 && monthofbearth > 0 && dayofbearth > 0 && dayofbearth < months[monthofbearth - 1] + 1 && yearofbearth < year && ((yearofbearth > 1850) || (yearofbearth * (-1) > 1850)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введена неверная дата");
                }
            } while (true);
            years = year - yearofbearth;
            if (month < monthofbearth)
            {
                Console.WriteLine("Привет, {0}. Ваш возраст равен {1} лет. Приятно познакомиться.", name, --years);
            }
            if (month >= monthofbearth)
            {
                if((month == monthofbearth && dayofbearth >= day) || month > monthofbearth)
                {
                    Console.WriteLine("Привет, {0}. Ваш возраст равен {1} лет. Приятно познакомиться.", name, years);
                }
                else
                {
                    Console.WriteLine("Привет, {0}. Ваш возраст равен {1} лет. Приятно познакомиться.", name, --years);
                }
            }
            
        }
    }
}
