using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenspielStolz
{
    internal class Karte
    {
        private string[] Farben = { "Herz", "Pik", "Karo", "Kreuz" };
        private int farbwahl = -1;
        private string farbe;
        private int Wertigkeit;
        public void SetWertigkeit(int wertigkeit)
        { this.Wertigkeit = wertigkeit; }
        public string GetWertigkeit()
        {
            string wert = "";
            if (this.Wertigkeit <= 10)
                wert = Wertigkeit.ToString();
            switch (Wertigkeit)
            {
                case 11:
                    wert = "Bube";
                    break;
                case 12:
                    wert = "Dame";
                    break;
                case 13:
                    wert = "Koenig";
                    break;
                case 14:
                    wert = "Ass";
                    break;
            }
            return wert;
        }
        public int GetWert()
        {
            return this.Wertigkeit;
        }
        public string GetFarbe()
        {
            return this.farbe;
        }
        public void SetFarbe(int farbe)
        {
            this.farbwahl = farbe;
            this.farbe = this.Farben[farbwahl]; 
        }
        public Karte(int Wert, int Farbe)
        {
            this.SetWertigkeit(Wert);
            this.SetFarbe(Farbe);
        }
        public Karte(int wert, string farbe)
        {
            this.SetWertigkeit(wert);
            this.farbe = farbe;
        }
        public static Stack<Karte> WertigkeitVergleichen(Karte karte1, Karte karte2)
        {
            Stack<Karte> ergebnis = new Stack<Karte>();
            if (karte1.GetWert() == karte2.GetWert())
            {
                ergebnis.Push(karte1);
                ergebnis.Push(karte2);
            }
            else if (karte1.GetWert() > karte2.GetWert())
                ergebnis.Push(karte1);
            else
                ergebnis.Push(karte2);
            return ergebnis;
        }
    }
}
