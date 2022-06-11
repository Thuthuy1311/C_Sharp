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
            int[] giatri_266 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap so thu " + i + " : ");
                giatri_266[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("gia tri lon nhat la : " + getMax_266(giatri_266));
            Console.WriteLine("gia tri nho nhat la : " + getMix_266(giatri_266));
            Console.WriteLine("tang so la : " + getTanSo(giatri_266) + "\n");
            Console.WriteLine("Sap xep mang tang : ");
            sapxeptang(giatri_266);
            Console.WriteLine("Sap xep mang giam : ");
            sapxepgiam(giatri_266);

            Console.ReadKey();
        }

        public static int getMax_266(int[] giatri)
        {
            int max = int.MinValue;
            for (int i = 0; i < 10; i++)
            {
                if (giatri[i] > max)
                {
                    max = giatri[i];
                }
            }
            return max;
        }

        public static int getMix_266(int[] giatri)
        {
            int mix = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                if (giatri[i] < mix)
                {
                    mix = giatri[i];
                }
            }
            return mix;
        }

        public static int getTanSo(int[] a)
        {
            int n = a.Length - 1;
            sapxeptang(a);
            int max = 0;
            int dem = 1;
            int result = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] == a[i + 1])
                {
                    dem++;
                    if (dem > max)
                    {
                        result = a[i];
                        max = dem;
                    }

                }
                else
                {

                    dem = 1;
                }
            }
            return result;

        }

        public static void sapxeptang(int[] giatri_266)
        {
            int n = giatri_266.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (giatri_266[i] > giatri_266[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = giatri_266[i];
                        giatri_266[i] = giatri_266[j];
                        giatri_266[j] = temp;
                    }
                }
            }
            xuatmang(giatri_266);
        }

        public static void sapxepgiam(int[] giatri_266)
        {
            int n = giatri_266.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (giatri_266[i] < giatri_266[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = giatri_266[i];
                        giatri_266[i] = giatri_266[j];
                        giatri_266[j] = temp;
                    }
                }
            }
            xuatmang(giatri_266);
        }

        public static void xuatmang(int[] giatri)
        {
            for (int i = 0; i < giatri.Length; i++)
            {
                Console.Write(" " + giatri[i]);

            }
            Console.WriteLine();

        }
    }
}
