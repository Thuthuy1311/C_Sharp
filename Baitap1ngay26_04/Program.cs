using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1ngay26_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so c : ");
            double c = double.Parse(Console.ReadLine());
            PhuongTrinhBac2 phuongTrinhBac2 = new PhuongTrinhBac2(a, b, c);
            phuongTrinhBac2.getNghiem();
            Console.ReadKey();
        }
    }

    class PhuongTrinhBac2
    {
        private double a;
        private double b;
        private double c;

        public PhuongTrinhBac2()
        {

        }

        public PhuongTrinhBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double countDelta()
        {
            double delta = this.b * this.b - 4 * this.a * this.c;
            return delta;
        }

        public void getNghiem()
        {
            double delta = this.countDelta();
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }

        public double GetA()
        {
            return this.a;
        }

        public double GetB()
        {
            return this.b;
        }

        public double GetC()
        {
            return this.c;
        }

        public void SetA(double a)
        {
            this.a = a;
        }

        public void SetB(double b)
        {
            this.b = b;
        }

        public void SetC(double c)
        {
            this.c = c;
        }
    }
}
