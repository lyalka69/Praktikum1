using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Найти периметр и площадь прямоугольника со сторонами stor и side2
            //(рассмотреть целый тип исходных данных, вещественный тип исходных данных).
            //Console.Write("Введите сторону прямоугольника sidе1:");
            //float stor= float.Parse(Console.ReadLine());
            //Console.Write("Введите сторону прямоугольника sidе2:");
            //float side2 = float.Parse(Console.ReadLine());
            //float P, S;
            //S = stor * side2;
            //P = 2 * (side2 + stor) ;
            //Console.WriteLine($"Периметр прямоугольника равен:{P} \nПлощадь прямоугольника равна:{S}");


            //Задача 2. Даны катеты прямоугольного треугольника. Найти его гипотенузу.

            //Console.Write("Введите катет1: ");
            //float K1 = float.Parse(Console.ReadLine());
            //Console.Write("Введите катет2: ");
            //float K2 = float.Parse(Console.ReadLine());
            //double G;
            //G = Math.Sqrt(Math.Pow(K1, 2) + Math.Pow(K2, 2));
            //Console.WriteLine($"Гипотенуза треугольника равна корню квадратной суммы катетов:{G}");


            //Задача 3.Дана сторона квадрата. Вычислить его периметр и площадь(рассмотреть целый тип исходных данных, вещественный тип исходных данных).

            //Console.Write("Введите сторону квадрата:");
            //double stor = float.Parse(Console.ReadLine());
            //double P, S;
            //S = Math.Pow(stor, 2);
            //P = stor * 4;
            //Console.WriteLine($"Периметр квадрата равен:{P} \nПлощадь квадрата равна:{S}");


            //Задача 4. Дано двузначное число.Вывести число единиц и десятков в числе.
            Console.Write("Введите двузначное число: ");
            int num = int.Parse(Console.ReadLine());
            int d, e;
            d = num / 10;
            e = num % 10;
            Console.WriteLine($"десятки = {d} \nеденицы = {e}");
            Console.ReadKey();
        }
    }
}
