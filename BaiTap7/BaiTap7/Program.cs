using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            String strA117, strB117;
            int A117, B117;

            Console.Write(" Moi nhap so A: ");
            strA117 = Console.ReadLine();
            Console.Write(" Moi nhap so B: ");
            strB117 = Console.ReadLine();

            if (int.TryParse(strA117, out A117) == false || int.TryParse(strB117, out B117) == false)
            {
                Console.WriteLine("Du lieu sai!");
            }
            else
            {
                Console.WriteLine("Phuong trinh: {0}x + {1} = 0", A117, B117);

                if (A117 == 0)
                    if (B117 != 0)
                        Console.WriteLine("\nPhuong trinh vo nghiem.");
                    else
                        Console.WriteLine("\nPhuong trinh co vo so nghiem.");
                else
                {
                    double nghiem117 = (double)-B117 / A117;
                    Console.WriteLine("\nPhuong trinh co nghiem x = {0}.", nghiem117);
                }

            }

            Console.ReadLine();
        }
    }
}
