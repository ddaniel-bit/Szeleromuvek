using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szeleromuvek
{
    internal class Szeleromu
    {
        String helyszin;
        int mennyiseg;
        int teljesitmeny;
        String ev;

        public Szeleromu(string helyszin, int mennyiseg, int teljesitmeny, string ev)
        {
            this.helyszin = helyszin;
            this.mennyiseg = mennyiseg;
            this.teljesitmeny = teljesitmeny;
            this.ev = ev;
        }
        public String Helyszín { get => helyszin; }
        public int Mennyiség { get => mennyiseg; }
        public int Teljesítmény { get => teljesitmeny; }
        public String Év { get => ev; }
        public char Kategoria()
        {
            if (teljesitmeny>999)
            {
                return 'A';
            }
            else if (teljesitmeny > 500 && teljesitmeny < 1000)
            {
                return 'B';
            }
            else
            {
                return 'C';
            }
            
        }
    }
}
