using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenspielStolz
{
    internal class Kartenset
    {
        private Stack<Karte> Ergebnis = new Stack<Karte>();
        public Kartenset(int farbe) 
        {
            for (int i = 2; i <= 14; i++)
            {
                Karte x = new Karte(i, farbe);
                Ergebnis.Push(x);
            }
        }
        public Kartenset(string farbe)
        {
            for (int i = 2;i <= 14;i++)
            {
                Karte x = new Karte(i, farbe);
                Ergebnis.Push(x);
            }
        }
        public Stack<Karte> GetKartenset()
        { return Ergebnis; }
    }
}
