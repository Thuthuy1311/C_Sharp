using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            String stAx117, stAy117, stBx117, stBy117;
            double Ax117, Ay117, Bx117, By117;

            Console.Write("Nhap toa do diem A\nToa do x: ");
            stAx117 = Console.ReadLine();
            Console.Write("Toa do y: ");
            stAy117 = Console.ReadLine();
            Console.Write("\nNhap toa do diem B\nToa do x: ");
            stBx117 = Console.ReadLine();
            Console.Write("Toa do y: ");
            stBy117 = Console.ReadLine();

            if (double.TryParse(stAx117, out Ax117) == false || double.TryParse(stBx117, out Bx117) == false || double.TryParse(stAy117, out Ay117) == false || double.TryParse(stBy117, out By117) == false)
            {
                Console.WriteLine("Du lieu sai!");
            }
            else
            {
                double d117 = Math.Sqrt(Math.Pow(Ax117 - Bx117, 2) + Math.Pow(Ay117 - By117, 2));
                Console.WriteLine("|AB| = " + d117);
            }
            Console.ReadLine();
        }
    }
}
