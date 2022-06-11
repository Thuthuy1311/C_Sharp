using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int soAm = 0;
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    int temp = arr[i] * (-1);
                    if (temp % 2 != 0 )
                    {
                        tong += arr[i];
                        soAm += 1;
                    }
                }
            }
            Console.WriteLine("trung binh so am le la : " + (tong / Convert.ToDouble(soAm)));

            for (int i = 0; i < n; i++)
            {
                int temp = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == temp)
                    {
                        int f = j;
                        while (f < n - 1)
                        {
                            arr[f] = arr[f + 1];
                            f++;
                        }
                        if (j == i + 1) j--;
                        
                        n --;
                    }
                }
            }
            Console.WriteLine("mang sau khi xoa la : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
