using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai60
{
    class Program
    {
        static void Main(string[] args)
        {
            // các bước 
            // Nhập số N
            // tạo mảng 1 chiều N phần tử
            // Nhập dữ liệu random cho mảng 
            // Random rd = new Random();
            // array[i] = rd.Next(-100, 100);
            //a)
            Console.Write("Nhap mot so chan n : ");
            int n = int.Parse(Console.ReadLine());

            while (n % 2 != 0)
            {
                Console.Write("n phai la so chan  ");
                n = int.Parse(Console.ReadLine());
            }

            int[] arrayA = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arrayA[i] = rd.Next(-100, 100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayA[i] + " ");
            }

            arrayA = perfectShuffle(arrayA);

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(arrayA[i] + " ");
            }
            Console.ReadKey();
        }

        public static int[] perfectShuffle (int[] arr)
        {
            int len = arr.Length;
            // lấy số chính giữ mảng
            int mid = len / 2 ;
            int dem = 0;
            for (int i = 0; i <= len / 2; i += 2)
            {
                int j = mid;
                // lưu giá trị cần chèn vào biến tam ( -3)
                int temp = arr[j];
                // mai chỉ tiếp cho. bỏ ra vài buổi để nắm                
                while (j > i)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j + 1] = temp;
                mid++;
                dem++;
            }
            Console.WriteLine("so lan tron la : " + dem);
            return arr;
        }
        
    }
}
