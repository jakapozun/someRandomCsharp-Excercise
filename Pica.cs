using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_test
{
    public enum TipPice { vegi, mesna };
    class Pica
    {
        public string sestavine;      
        public TipPice tipPice;
        public double cena;

        public Pica()
        {

        }

        public Pica(string sestavine, TipPice tipPice, double cena)
        {
            this.sestavine = sestavine;
            this.tipPice = tipPice;
            this.cena = cena;
        }
    }
}
