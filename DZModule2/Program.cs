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
            //string me = Console.ReadLine();
            //decimal.Parse(me, System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(me);
            Console.WriteLine(1);
            Console.WriteLine(4+"  "+78+"  "+3);
            string tire = new string('-', 20);
            Console.WriteLine(tire);
            Console.WriteLine(2);
            Console.WriteLine(5+"\n"+10+"\n"+21);
            Console.WriteLine(tire);
            Console.WriteLine(3);
            Console.Write("Введите количество сантиметров: ");
            string metr = Console.ReadLine();
            Console.WriteLine("В введённом числе {0} полных метра(ов)", Int32.Parse(metr)/100);
            Console.WriteLine(tire);
            Console.WriteLine(4);
            Console.WriteLine("В 234 днях {0} полных недель", 234/7);
            Console.WriteLine(tire);
            Console.WriteLine(5);
            Console.Write("Введите двузначное число: ");
            int dvuchislo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("В нём {0} - десятков, {1} - единиц (либо {2}, если имеется ввиду последняя цифра), {3} - сумма его цифр, {4} - произведение его цифр", 
                dvuchislo/10,
                dvuchislo,
                dvuchislo - ((dvuchislo / 10) * 10),
                (dvuchislo / 10) + (dvuchislo - ((dvuchislo / 10) * 10)),
                (dvuchislo / 10) * (dvuchislo - ((dvuchislo / 10) * 10)));
            Console.WriteLine(tire);
            Console.WriteLine(6);
            bool A = true, B = false, C = false;
            Console.WriteLine((A||B).ToString() +" "+ (A && B).ToString()+ " " + (B || C).ToString());
            Console.WriteLine(tire);
            Console.WriteLine(7);
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
            Console.WriteLine(8);
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
            else if (mas1 / ob1 == mas2 / ob2)
            {
                Console.WriteLine("Плотности равны.");
            }
            else
            {
                Console.WriteLine("Плотность второго тела ({1}) выше плотности первого тела ({0})", mas1 / ob1, mas2 / ob2);
            }
            Console.WriteLine(tire);
            Console.WriteLine(9);
            Console.Write("Введите напряжение первой цепи: ");
            double u1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сопротивление первой цепи: ");
            double res1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите напряжение второй цепи: ");
            double u2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сопротивление второй цепи: ");
            double res2 = Convert.ToDouble(Console.ReadLine());
            if (u1/res1<u2/res2)
            {
                Console.WriteLine("Сила тока первой цепи ({0}) меньше чем сила тока второй цепи ({1})", u1 / res1 , u2 / res2);
            }
            else if (u1 / res1 == u2 / res2)
            {
                Console.WriteLine("Сила тока одинакоава.");
            }
            else
            {
                Console.WriteLine("Сила тока второй цепи ({1}) меньше чем сила тока первой цепи ({0})", u1 / res1, u2 / res2);
            }
            Console.WriteLine(tire);
            Console.WriteLine(10);
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("Введите целое число, до которого необходимо возвести в квадрат все чила от 10: ");
            int kvadrat = Int32.Parse(Console.ReadLine());
            if (kvadrat>10)
            {
                for (int i = 10; i <= kvadrat; i++)
                {
                    int result = i * i;
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Число должно быть больше 10");
            }
            Console.Write("Введите целое число, от которого необходимо возвести в третью степень все чила до 50: ");
            int tre = Int32.Parse(Console.ReadLine());
            if (tre < 50)
            {
                for (int i = tre; i <= 50; i++)
                {
                    int result = i * i * i;
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Число должно быть меньше 50");
            }
            Console.Write("Введите целое число, от которого необходимо начать распечатку чисел: ");
            int nach = Int32.Parse(Console.ReadLine());
            Console.Write("Введите целое число (больше первого), до которого необходимо завершить распечатку чисел: ");
            int kon = Int32.Parse(Console.ReadLine());
            if (kon > nach)
            {
                for (int i = nach; i <= kon; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Второе число должно быть меньше первого!");
            }
            Console.WriteLine(tire);

            Console.WriteLine(11);
            Console.Write("Введите число X для решения уравнения: ");
            double urav = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y = "+ (7 * (urav * urav) - (3 * urav) + 4));
            Console.WriteLine(tire);
            Console.WriteLine(12);
            Console.Write("Введите радиус окружности: ");
            double r3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна {0}, площадь круга равна {1}", 2*3.14*r3,3.14*r3*r3);
            Console.WriteLine(tire);
            Console.WriteLine(16);
            Console.Write("Введите многозначное целое число: ");
            string mnogo = Console.ReadLine();
            int sumMnogo = 0;
            int multMnogo = 1;
            for (int i = 0; i < mnogo.Length; i++)
            {
                sumMnogo = sumMnogo + (int)char.GetNumericValue(mnogo[i]);
                multMnogo = multMnogo * (int)char.GetNumericValue(mnogo[i]);
            }
            Console.WriteLine("Сумма всех числе равна {0}, произведение всех числе равно {1}.", sumMnogo, multMnogo);
            Console.WriteLine(tire);
            Console.WriteLine(17);
            Console.WriteLine("Задача найти исходное число, в результате манипуляций с которым получилось число 456.");
            int trichislo = 456;
            int perv = trichislo / 100;
            //Console.WriteLine(perv);
            int vtor = (trichislo - perv * 100) / 10;
            //Console.WriteLine(vtor);
            int tret = (trichislo % 10);
            //Console.WriteLine(tret);
            Console.WriteLine(perv + "" + tret + "" + vtor);
            Console.WriteLine(tire);
            Console.WriteLine(18);
            bool x=true, y=true;
            Console.WriteLine((!x && !y).ToString() + " " + (x || (!x && y)).ToString() + " " + ((!x && y) || y).ToString());
            x = true; y = false;
            Console.WriteLine((!x && !y).ToString() + " " + (x || (!x && y)).ToString() + " " + ((!x && y) || y).ToString());
            x = false; y = true;
            Console.WriteLine((!x && !y).ToString() + " " + (x || (!x && y)).ToString() + " " + ((!x && y) || y).ToString());
            x = false; y = false;
            Console.WriteLine((!x && !y).ToString() + " " + (x || (!x && y)).ToString() + " " + ((!x && y) || y).ToString());
        }
    }
}
