using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmieren_nach_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f1 = new Firma();
            Produkt p1 = new Produkt("4 TiB Festplatte", 195.5f, 7000);
            Produkt p2 = new Produkt("250 GiB SSD", 149.9f, 6000);
            Werk w1 = new Werk(p1);
            Werk w2 = new Werk(p2);

            f1.addWerk(w1);
            f1.addWerk(w2);
            Console.WriteLine("Anahl Werke in Firma: " + f1.blub());
            Console.WriteLine("Gesamter Umsatz: " + f1.berechneGesamtumsatz());
            Console.ReadKey();

        }
        class Firma
        {
            private int AnzahlWerke;
            List<Werk> Werke = new List<Werk>();

            public void addWerk(Werk w)
            {
                Werke.Add(w);
            }

            public float berechneGesamtumsatz()
            {
                float umsatz = 0;
                foreach (Werk w in Werke)
                    umsatz += w.berechneUmsatz();

                return umsatz;
            }
            public int blub()
            {
                foreach (Werk w in Werke)
                {
                    AnzahlWerke++;
                }
                return AnzahlWerke;
            }
        }
        class Werk
        {
            private Produkt produkt;

            public Werk(Produkt produkt)
            {
                this.produkt = produkt;
            }

            public float berechneUmsatz()
            {
                return produkt.getPreis() * produkt.getAnzahl();
            }
        }
        class Produkt
        {
            private string name;
            private float preis;
            private int anzahl;

            public Produkt(string name, float preis, int anzahl)
            {
                this.name = name;
                this.preis = preis;
                this.anzahl = anzahl;
            }

            public string getName()
            {
                return name;
            }

            public float getPreis()
            {
                return preis;
            }
            
            public int getAnzahl()
            {
                return anzahl;
            }
        }
    }
}
