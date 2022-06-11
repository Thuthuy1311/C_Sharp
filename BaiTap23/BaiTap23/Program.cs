using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n117;

            Console.Write("Nhap mot so nguyen duong: ");
            n117 = int.Parse(Console.ReadLine());

            if (n117 < 6)
                Console.WriteLine("Khong co so hoan hao nho hon " + n117);
            else
            {
                Console.Write("Cac so hoan hao nho hon {0}: ", n117);
                for (int i = 6; i< n117; i++)
                {
                    int sum117 = 0;
                    for(int j=1; j<i; j++)
                    {
                        if (i % j == 0)
                            sum117 += j;
                    }
                    if(sum117 == i)
                        Console.Write(" "+ i);
                }
            }
            Console.ReadLine();
        }
    }
}
