using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap19
{
    class Program
    {
        static void Main(string[] args)
        {
            int ha117, ma117, sa117, hb117, mb117, sb117, suma117, sumb117, sumc117, hc117, mc117, sc117;
            Console.Write(" Nhap thoi diem 1\nNhap gio: ");
            ha117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            ma117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            sa117 = int.Parse(Console.ReadLine());
            Console.Write("\n Nhap thoi diem 2\nNhap gio: ");
            hb117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: ");
            mb117 = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: ");
            sb117 = int.Parse(Console.ReadLine());

            suma117 = ha117 * 3600 + ma117 * 60 + sa117;
            sumb117 = hb117 * 3600 + mb117 * 60 + sb117;
            sumc117 = sumb117 - suma117;

            hc117 = sumc117 / 3600;
            sumc117 = sumc117 % 3600;
            mc117 = sumc117 / 60;
            sc117 = sumc117 % 60;

            Console.WriteLine("\n\nHieu thoi gian: {0} gio {1} phut {2} giay.", hc117, mc117, sc117);

            Console.ReadLine();
        }

        
    }
}
