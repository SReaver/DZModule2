using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZModule2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4+"  "+78+"  "+3);
            string tire = new string('-', 20);
            Console.WriteLine(tire);
            Console.WriteLine(5+"\n"+10+"\n"+21);
            Console.WriteLine(tire);
            Console.Write("Введите количество сантиметров: ");
            string metr = Console.ReadLine();
            Console.WriteLine("В введённом числе {0} полных метра(ов)", Int32.Parse(metr)/100);
            Console.WriteLine(tire);
            Console.WriteLine("В 234 днях {0} полных недель", 234/7);
            Console.WriteLine(tire);
            Console.Write("Введите двузначное число: ");
            int dvuchislo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("В нём {0} - десятков, {1} - единиц (либо {2}, если имеется ввиду последняя цифра), {3} - сумма его цифр, {4} - произведение его цифр", 
                dvuchislo/10,
                dvuchislo,
                dvuchislo - ((dvuchislo / 10) * 10),
                (dvuchislo / 10) + (dvuchislo - ((dvuchislo / 10) * 10)),
                (dvuchislo / 10) * (dvuchislo - ((dvuchislo / 10) * 10)));
            Console.WriteLine(tire);
            bool A = true, B = false, C = false;
            Console.WriteLine((A||B).ToString() +" "+ (A && B).ToString()+ " " + (B || C).ToString());
            Console.WriteLine(tire);
            Console.Write("Введите размер стороны квадрата: ");
            double kvstor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер радиуса круга: ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            if (kvstor*kvstor>3.14*r1*r1)
            {
                Console.WriteLine("Площадь квадрата ({0}) больше площади круга({1})", kvstor * kvstor, 3.14 * r1 * r1);
            }
            else
            {
                Console.WriteLine("Площадь круга ({1}) больше площади квадрата({0})", kvstor * kvstor, 3.14 * r1 * r1);
            }
            Console.WriteLine(tire);
            Console.Write("Введите массу первого тела: ");
            double mas1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите объём первого тела: ");
            double ob1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите массу второго тела: ");
            double mas2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите объём второго тела: ");
            double ob2 = Convert.ToDouble(Console.ReadLine());
            if (mas1/ob1>mas2/ob2)
            {
                Console.WriteLine("Плотность первого тела ({0}) выше плотности второго тела ({1})", mas1 / ob1 , mas2 / ob2);
            }
            else
            {
                Console.WriteLine("Плотность второго тела ({1}) выше плотности первого тела ({0})", mas1 / ob1, mas2 / ob2);
            }
        }
    }
}
