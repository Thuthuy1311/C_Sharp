using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            String sta117, stb117, stc117;
            int a117, b117, c117;

            Console.Write("Nhap a: ");
            sta117 = Console.ReadLine();
            Console.Write("Nhap b: ");
            stb117 = Console.ReadLine();
            Console.Write("Nhap c: ");
            stc117 = Console.ReadLine();

            if (int.TryParse(sta117, out a117) == false || int.TryParse(stc117, out c117) == false || int.TryParse(stb117, out b117) == false)
                Console.WriteLine("Du lieu sai!");
            else
            {
                int tg117;
                // so sánh a với b và c => số đầu tiên đứng đúng vị trí
                // sau đó so sánh b và c => 2 số sau đúng vị trí => xong
                if (a117 > b117)
                {
                    tg117 = a117;
                    a117 = b117;
                    b117 = tg117;
                }
                if (a117 > c117)
                {
                    tg117 = a117;
                    a117 = c117;
                    c117 = tg117;
                }
                if (b117 > c117)
                {
                    tg117 = b117;
                    b117 = c117;
                    c117 = tg117;
                }
                Console.WriteLine("a b c : {0} {1} {2}", a117, b117, c117);
            }

            Console.ReadLine();
        }
    }
}
