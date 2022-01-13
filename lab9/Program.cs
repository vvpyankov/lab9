using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex) when (a==0 && b==0)
            {

                Console.WriteLine("деление 0 на 0"); ;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            Console.ReadKey();
        }
    }
}
 