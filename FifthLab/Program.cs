using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вивести сумму головної та побічної діагоналі
namespace FourthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Enter size of array : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N,N];
            int sumMain=0,
                sumSub=0;
            for (int i = 0; i < N; i++)
            {
                for (int l = 0; l < N; l++)
                {
                    arr[i, l] = r.Next(20);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int l = 0; l < N; l++)
                {
                    Console.Write(arr[i,l] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                sumMain += arr[i, i];
            }

            for (int i = 0; i < N; i++)
            {
                sumSub += arr[i, N-1-i];
            }
            Console.WriteLine("Sum main diagonal : " + sumMain);
            Console.WriteLine("Sum sub diagonal : " + sumSub);
        }
    }
}
