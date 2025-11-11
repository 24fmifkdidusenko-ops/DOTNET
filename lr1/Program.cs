using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Лабораторна робота №1");
            Console.WriteLine("Виконав: Дідусенко Кирило, група КН-42\n");

            Console.WriteLine("Оберіть варіант обчислення:");
            Console.WriteLine("1 - Площа паралелограма");
            Console.WriteLine("2 - Площа трикутника за формулою Герона");
            Console.WriteLine("3 - Площа бічної поверхні піраміди");
            Console.WriteLine("4 - Об’єм піраміди");
            Console.WriteLine("5 - Об’єм сфери");
            Console.Write("\nВаш вибір: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    // Площа паралелограма (S = a * h)
                    Console.Write("Введіть сторону a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть висоту h: ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    double sParallelogram = a * h;
                    Console.WriteLine($"\nПлоща паралелограма = {sParallelogram:F3}");
                    break;

                case 2:
                    // Площа трикутника за формулою Герона
                    Console.Write("Введіть сторону a: ");
                    double a2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть сторону b: ");
                    double b2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть сторону c: ");
                    double c2 = Convert.ToDouble(Console.ReadLine());
                    double p = (a2 + b2 + c2) / 2.0;
                    double sTriangle = Math.Sqrt(p * (p - a2) * (p - b2) * (p - c2));
                    Console.WriteLine($"\nПлоща трикутника = {sTriangle:F3}");
                    break;

                case 3:
                    // Площа бічної поверхні піраміди (S = 1/2 * Pосн * l)
                    Console.Write("Введіть периметр основи P: ");
                    double P = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть апофему l: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    double sLateral = 0.5 * P * l;
                    Console.WriteLine($"\nПлоща бічної поверхні піраміди = {sLateral:F3}");
                    break;

                case 4:
                    // Об’єм піраміди (V = 1/3 * Sосн * h)
                    Console.Write("Введіть площу основи S: ");
                    double Sbase = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введіть висоту h: ");
                    double h4 = Convert.ToDouble(Console.ReadLine());
                    double vPyramid = (1.0 / 3.0) * Sbase * h4;
                    Console.WriteLine($"\nОб’єм піраміди = {vPyramid:F3}");
                    break;

                case 5:
                    // Об’єм сфери (V = 4/3 * π * r^3)
                    Console.Write("Введіть радіус сфери r: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    double vSphere = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                    Console.WriteLine($"\nОб’єм сфери = {vSphere:F3}");
                    break;

                default:
                    Console.WriteLine("Невірний вибір! Оберіть число від 1 до 5.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
