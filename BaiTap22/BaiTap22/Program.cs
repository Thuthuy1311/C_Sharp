using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n117;

            Console.Write("Nhap mot so nguyen duong: ");
            n117 = int.Parse(Console.ReadLine());

            if (n117 == 0)
                Console.WriteLine("Co 0 uoc so, tong la: 0");
            else
            {
                int sum117 = 0, dem117 = 0;
                Console.Write("Cac uoc so la: ");
                for (int i = 1; i <= n117; i++)
                {
                    if (n117 % i == 0)
                    {
                        Console.Write(" " + i);
                        dem117++;
                        sum117 += i;
                    }
                }
                Console.WriteLine("\nCo {0} uoc so, tong la: {1}", dem117, sum117);
            }

            Console.ReadLine();
        }
    }
}
