using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Time              
            DateTime currentDateTime = DateTime.Now;
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeGmt = DateTime.Now;
            Console.WriteLine(currentDateTime.ToString());
            #endregion
            #region HW(1)
            Console.WriteLine("\nЗадание №1 ");
            Console.WriteLine("Введите число от 1 до  100 : ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FIZZ BUZZ");
                }
                if (num % 3 != 0 && num % 5 != 0)
                {
                    Console.WriteLine(num);
                }
            }
            if (num < 1)
            {
                Console.WriteLine("errror!");
            }
            if (num > 100)
            {
                Console.WriteLine("errror!");
            }
            #endregion
            #region HW(2)
            Console.WriteLine("\nЗадание №2 ");
            Console.WriteLine("Введите число : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число(процент) : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a / 100 * b);
            #endregion
            #region HW(3)
            Console.WriteLine("\nЗадание №3 ");
            Console.Write("Введите 1 цифру: ");
            int vier = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 цифру: ");
            int drei = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 цифру: ");
            int zwei = int.Parse(Console.ReadLine());
            Console.Write("Введите 4 цифру: ");
            int ein = int.Parse(Console.ReadLine());
            int all = vier * 1000 + drei * 100 + zwei * 10 + ein;
            Console.WriteLine(all);
            #endregion
            #region HW(4)
            Console.WriteLine("\nЗадание №4 ");
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
                     
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(i + " - введите значение: ");
                arr[i] = int.Parse(Console.ReadLine());
            }                                            
               
            #endregion
            #region HW(5)
            Console.WriteLine("\n Задание №5 ");
            Console.WriteLine("Введите день: ");
            double day = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            double month = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            double year = double.Parse(Console.ReadLine());
            if (day < 10)
            {
                Console.WriteLine($"Ваша дата - 0{day}.{month}.{year}");
            }
            if (month < 10)
            {
                Console.WriteLine($"Ваша дата - {day}.0{month}.{year}");
            }
            else
            {
                Console.WriteLine($"Ваша дата - {day}.{month}.{year}");
            }
            if (month == 12|| month==1||month==2)
            {
                Console.WriteLine("Зима");
            }
            else if(month==3||month==4||month==5)
            {
                Console.WriteLine("Весна");
            }
            else if(month==6||month==7||month==8)
            {
                Console.WriteLine("Лето");
            }
            else if(month==9||month==10||month==11)
            {
                Console.WriteLine("Осень");
            }
            #endregion
            #region HW(6)
            Console.WriteLine("\nЗадание №6 ");
            Console.WriteLine("Введите градус в Фаренгейт: ");
            double fahrenheit=double.Parse(Console.ReadLine());
            Console.WriteLine("Введите градус в Цельсии: ");
            double celsius=double.Parse(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Фаренгейт в Цельсий: " + celsius);
            fahrenheit = (celsius*9/5)+32;
            Console.WriteLine("Цельсий в Фаренгейт: " + fahrenheit);
            Console.ReadLine();
            #endregion
            #region HW(7)



            #endregion
        }
    }
}

 