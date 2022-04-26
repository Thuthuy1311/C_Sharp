using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2ngay26_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat_266 cat = new Cat_266();
            cat.makeSound_266();
            cat.eat_266();
            cat.run_266();
            Bird_266 bird = new Bird_266();
            bird.makeSound_266();
            bird.eat_266();
            bird.fly_266();
            Console.ReadKey();
        }
    }

    public abstract class Animal_266
    {
        public abstract void eat_266();

        public abstract void makeSound_266();
    }

    public class Cat_266 : Animal_266
    {
        public override void makeSound_266()
        {
            Console.WriteLine("Cat say: meo meo ");
        }

        public override void eat_266()
        {
            Console.WriteLine("Cat eat: fish ");
        }

        public void run_266()
        {
            Console.WriteLine("Cat is running");
        }
    }

    public class Bird_266 : Animal_266
    {
        public override void makeSound_266()
        {
            Console.WriteLine("Bird say: bip bip ");
        }

        public override void eat_266()
        {
            Console.WriteLine("Bird eat: Sau ");
        }

        public void fly_266()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
