using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KartenspielStolz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kartenspiel neu = new Kartenspiel(1);
            neu.KartenAusgeben();
            Kartenset pik = new Kartenset("Pik");
            Kartenset herz = new Kartenset("Herz");
            Kartenspiel abgehoben = Kartenspiel.AbhebenNachxProStackFuerZwei(pik.GetKartenset(), herz.GetKartenset(), 6);
            Console.WriteLine("==========================");
            abgehoben.KartenAusgeben();
            Karte a = new Karte(12, 2);
            Karte b = new Karte(12, 1);
            Stack<Karte> verglichen = Karte.WertigkeitVergleichen(a, b);
            foreach(Karte x in verglichen)
                Console.WriteLine(x.GetWertigkeit());
        }
    }
}
