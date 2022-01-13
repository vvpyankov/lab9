using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int[] mathSymb = { 1, 2, 3, 4 };
            Console.WriteLine("Перед Вами простейший калькулятор!");
            try
            {
                Console.Write("Введите целое число: A = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: B = ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(@"Введите код операции:
    1 - сложение
    2 - вычитание
    3 - произведение
    4 - частное");
            Console.Write("Выш выбор: ");


            int numberSymbol = 0;

            try
            {
                numberSymbol = Convert.ToInt32(Console.ReadLine());
                int symbol = mathSymb[-1 + numberSymbol];
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Некорректный ввод.");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Нет операции с выбранным номером.");
                return;
            }

            double action = 0;
            try
            {
                if (numberSymbol == 1)
                {
                    action = a + b;
                }
                else if (numberSymbol == 2)
                {
                    action = a - b;
                }
                else if (numberSymbol == 3)
                {
                    action = a * b;
                }
                else if (numberSymbol == 4)
                {
                    action = a / b;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

                return;
            }

            Console.WriteLine("Результат = {0}", action);
            Console.ReadKey();
        }
    }
}
