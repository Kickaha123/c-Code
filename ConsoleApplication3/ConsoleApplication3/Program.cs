using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrNumber = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //foreach (int number in arrNumber)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadKey();


            //char i;
            //    do
            //    {
             //       i = Console.ReadKey().KeyChar;
             //       Console.Clear();
                    
             //   }
             //   while (!Char.IsNumber(i));

            //
            //
            //string[] blackListPIN = new string[] { "0000", "1234", "9999" };
            //string i;
            //bool xd = true;
            //do
            //{
            //    xd = true;
            //    i = Console.ReadLine();
            //    foreach (string help in blackListPIN)
            //    {
            //        if (i == help)
            //        {
            //            Console.WriteLine("in Blacklist");
            //            xd = false;
            //            break;
            //        }
            //    }
            //} while (xd == false);
            //Console.ReadKey();

            Konto kt1 = new Konto(100);
            Konto kt2 = new Konto(1000000);
            Konto kt3 = new Konto();

            Console.WriteLine(kt1.getKtoNr());
            Console.WriteLine(kt1.getKtoStand());
            Console.WriteLine(kt2.getKtoNr());
            Console.WriteLine("Cedric Money = " + kt2.getKtoStand());
            Console.WriteLine(kt3.getKtoNr());
            Console.ReadKey();

            


        }

        class Konto
        {
            private uint ktoNr;
            private static uint ktoNrplus = 400000;

            private double ktoStand;

            public Konto()
            {
                ktoNr = ktoNrplus++;
                ktoStand = 0;
            }
            public Konto(double ulul)
                : this()
            {
                ktoStand = ulul;
            }
            public uint getKtoNr()
            {
                return ktoNr;
            }
            public double getKtoStand()
            {
                return ktoStand;
            }

        }
    }
}
