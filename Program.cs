using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Урок 5.1

            //Задание 1 - Создайте кортеж User, содержащий имя пользователя Name и массив с текстовой информацией
            //о его пяти любимых блюдах Dishes. Заполните имя пользователя через ввод в консоль,
            //а информацию о блюдах — в цикле через консоль.
            (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо номер {0}:", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
            //Конец задания 1.
        }
    }
}
