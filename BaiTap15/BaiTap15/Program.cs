using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap15
{
    class Program
    {
        static void Main(string[] args)
        {
            int stday117, stmonth117, styear117;

            Console.Write("Nhap ngay: ");
            stday117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            stmonth117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            styear117 = int.Parse(Console.ReadLine());

            int sum117 = (int)(30.42 * (stmonth117 - 1)) + stday117;
            if (stmonth117 == 2)
                sum117 = sum117 + 1;
            else if (stmonth117 < 8)
                sum117 = sum117 - 1;

            Console.WriteLine("Ngay vua nhap la ngay thu {0} trong nam", sum117);

            Console.ReadLine();
        }
    }
}
