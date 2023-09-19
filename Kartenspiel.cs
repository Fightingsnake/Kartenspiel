using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KartenspielStolz
{
    internal class Kartenspiel
    {
        public Stack<Karte> Kartenstapel { get; set; } = new Stack<Karte>();
        public Kartenspiel(int MengeFarben)
        {
            for (int i = 0; i < MengeFarben; i++)
            {
                Kartenset aktFarbe = new Kartenset(i);
                while (aktFarbe.GetKartenset().Count > 0)
                {
                    Kartenstapel.Push(aktFarbe.GetKartenset().Pop());
                }
            }
        }
        public Kartenspiel() { }
        public void KartenAusgeben()
        {
            foreach (Karte akt in Kartenstapel)
            {
                Thread.Sleep(10);
                Console.WriteLine($"{akt.GetFarbe()} {akt.GetWertigkeit()}");
            }
        }
        public static Kartenspiel AbhebenNachxProStackFuerZwei(Stack<Karte> Stapel1, Stack<Karte> Stapel2, int AbhebenNach)
        {
            Kartenspiel ergebnis = new Kartenspiel();
            for (int i = 0; i < AbhebenNach; i++)
                if (Stapel1.Peek() != null)
                    ergebnis.Kartenstapel.Push(Stapel1.Pop());
            for (int i = 0; i < AbhebenNach;i++)
                if (Stapel2.Peek() != null)
                    ergebnis.Kartenstapel.Push(Stapel2.Pop());
            while (Stapel1.Count > 0)
                ergebnis.Kartenstapel.Push(Stapel1.Pop());
            while (Stapel2.Count > 0)
                ergebnis.Kartenstapel.Push(Stapel2.Pop());
            return ergebnis;
        }
    }
}
