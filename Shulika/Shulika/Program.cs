using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Shulika
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            RedheadDuck duck2 = new RedheadDuck();

            Duck[] array = new Duck[] { duck1, duck2 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(array[i].Quack());
                Console.WriteLine(array[i].Swim());
                Console.WriteLine(array[i].Display());
            }
            Console.ReadKey();
        }
    }
}
