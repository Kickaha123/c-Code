using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10000;

            while (x >= 2000)
            {
                Console.WriteLine("Betrag auswählen");
                x -= Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Out of Money");
            Console.ReadKey();
            //
        }
    }
}
