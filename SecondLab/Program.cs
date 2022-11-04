using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вивести добуток ряда 
namespace SecondLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0,
                max = 0,
                min = 0;
            double result = 1;

            while (true)
            {
                try
                {

                    Console.Write("Enter k value : ");
                    k = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter min : ");
                    min = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter k max : ");
                    max = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter correct value");
                }
            }
            if (min > 0 && min < max)
            {
                for (int i = min; i < max; i++)
                {
                    result *= ((Math.Pow(-1, k) + 8) / (Math.Pow(2 * k, 2) + k + 7));
                }
            }
            Console.WriteLine("Result : " + result);

        }
    }
}
