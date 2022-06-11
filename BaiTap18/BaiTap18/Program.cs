using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap18
{
    class Program
    {
        static void Main(string[] args)
        {
            string sttg117;
            int tg117, tuan117, ngay117, gio117;

            Console.Write("Nhap so gio: ");
            sttg117 = Console.ReadLine();

            if (int.TryParse(sttg117, out tg117) == false)
                Console.WriteLine("Du lieu khong hop le!");
            else
            {
                tuan117 = tg117 / (24 * 7);
                tg117 = tg117 % (24 * 7);
                ngay117 = tg117 / (24);
                gio117 = tg117 % (24);

                Console.WriteLine("{0} tuan, {1} ngay, {2} gio", tuan117, ngay117, gio117);
            }

            Console.ReadLine();
        }
    }
}
