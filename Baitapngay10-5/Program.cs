using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapngay10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[100];
            //Nhap gia tri cho mang
            for (int i = 1; i <= 10; i++)//Phan tu dau tien bat dau =0
            {
                Console.Write("Nhap so thu {0}:", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            //Xuat gia tri da nhap
            Console.WriteLine("Gia tri phan tu la:");
            for (int i = 1; i <= 10; i++)//Phan tu dau tien bat dau =0
            {
                Console.Write(" {1} " + " ", i, mang[i]);
            }
            Console.ReadLine();
        }
    }
}
