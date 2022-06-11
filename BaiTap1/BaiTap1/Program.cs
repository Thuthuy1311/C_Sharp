using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            String st117;
            double s117, r117, v117;

            Console.Write("Nhap dien tich mat cau: ");
            st117 = Console.ReadLine();

            if (double.TryParse(st117, out s117) == false)
            {
                Console.WriteLine("Du lieu sai!");
            }
            else
            {
                r117 = Math.Sqrt((double)s117 / 4 / 3.141593);
                Console.WriteLine("Ban kinh: " + r117);
                v117 = (4  * 3.141593 * Math.Pow(r117, 3))/3;
                Console.WriteLine("The tich mat cau: " + v117);
            }

            Console.ReadLine(); 
        }
    }
}
