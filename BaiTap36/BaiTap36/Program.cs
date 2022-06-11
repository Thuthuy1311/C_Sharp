using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap36
{
    class Program
    {
        static void Main(string[] args)
        {
            int n117, dem117 = 0, so117 = 2, kt117 = 0;

            Console.Write("Nhap mot so nguyen duong: ");
            n117 = int.Parse(Console.ReadLine());

            while (dem117 < n117)
            {
                //kiểm tra so nguyen to
                for (int i = 2; i < so117; i++)
                {
                    if (so117 % i == 0)
                        kt117 = 1;
                }
                if (kt117 == 0)
                {
                    dem117++;
                    Console.Write(so117 + " ");
                }
                kt117 = 0;
                so117++;
                
            }
            Console.ReadLine();
        }
    }
}
