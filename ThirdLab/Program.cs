using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вивести чи елементи тризначного числа збільшуються, зменшуються чи не змінюються
namespace ThirdLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int first,
                second,
                third;
            first = num / 100;
            second = num / 10 % 10;
            third = num % 10;
            if (first < second && second < third)
            {
                Console.WriteLine("Your number is increase");
            }
            else if (first > second && second > third)
            {
                Console.WriteLine("Your number is decrease");
            }
            else
            {
                Console.WriteLine("You enter incorrect number!!!!");
            }

        }
    }
}
