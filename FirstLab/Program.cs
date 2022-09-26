using System;

namespace FirstLab
//обчислення об'єм конуса
{
    class Program

    {
        static void Main()
        {
            int hight, radius;
            while (true)
            {
                try
                {
                    Console.Write("Enter hight : ");
                    hight = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter radius : ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter correct type");
                }
            }
            Console.WriteLine("Cylinder volume is : " + (2 * Math.PI * hight * radius));


        }

    }

}


