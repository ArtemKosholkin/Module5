using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        //Урок 5.1
        //Создание метода и вызов из разных частей программы
        static void ShowColor()
        {
            Console.WriteLine("Введите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет красный!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет зелёный!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Ваш любимый цвет голубой!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Ваш любимый цвет тот, который вы ввели.");
                    break;
            }
        }


        static void Main(string[] args)
        {
            //Урок 5.1
            var (name, age) = ("Jarvis", 27);

            Console.WriteLine("Моё имя {0}, мой возраст {1}", name, age);

            //ShowColor();

            Console.Write("Введите своё имя: ");
            name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            age = int.Parse(Console.ReadLine());

            //ShowColor();

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            Console.WriteLine();

            //ShowColor();

            Console.ReadKey();

            //Урок 5.0

            //Задание 1 - Создайте кортеж User, содержащий имя пользователя Name и массив с текстовой информацией
            //о его пяти любимых блюдах Dishes. Заполните имя пользователя через ввод в консоль,
            //а информацию о блюдах — в цикле через консоль.
            //(string Name, string[] Dishes) User;

            //Console.WriteLine("Введите имя: ");
            //User.Name = Console.ReadLine();

            //User.Dishes = new string[5];
            
            //for (int i = 0; i < User.Dishes.Length; i++)
            //{
            //    Console.WriteLine("Введите любимое блюдо номер {0}:", i + 1);
            //    User.Dishes[i] = Console.ReadLine();
            //}

            //Console.ReadKey();
            //Конец задания 1.
        }
    }
}
