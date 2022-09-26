using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//вивести максимальне значення одномірного масиву
namespace FourthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Enter size of array : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                arr[i] = r.Next(20);
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < N; i++)
            {
                if (i == 0) max = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine();
            Console.WriteLine("Max value : " + max);
        }
    }
}
