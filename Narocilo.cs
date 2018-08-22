using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_test
{
    class Narocilo
    {
        public List<Pica> narocene_pice;
        public DateTime datum_narocila;
        public string naslov_dostave;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Narocilo()
        {
            this.narocene_pice = new List<Pica>();
        }

        public Narocilo(DateTime datum_narocila, string naslov_dostave, int id)
        {
            this.narocene_pice = new List<Pica>();
            this.datum_narocila = datum_narocila;
            this.naslov_dostave = naslov_dostave;
            Id = id;
        }

        public double IzracunajCeno()
        {
            double vrednost = 0;
            foreach (Pica pica in narocene_pice)
            {
                vrednost += pica.cena;
            }
            return vrednost;
        }
    }
}
