using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap37
{
    class Program
    {
        static void Main(string[] args)
        {
            int n117, sum117=1, m117=1;

            Console.Write("Nhap mot so nguyen duong: ");
            n117 = int.Parse(Console.ReadLine());

            if (n117 < 2)
                Console.WriteLine("Du lieu khong hop le!");
            else
            {
                Console.Write(1);
                while(sum117 < n117)
                {
                    Console.Write(" + " + m117);
                    m117++;
                    sum117 += m117;
                }
                sum117 -= m117;
                m117--;
                Console.Write(" = " + sum117);
                Console.WriteLine("\nm = " + m117);
            }

            Console.ReadLine();
        }
    }
}
