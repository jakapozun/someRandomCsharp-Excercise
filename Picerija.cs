using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_test
{
    class Picerija
    {
        public List<Narocilo> seznam;
        public List<Pica> stalna_ponudba;
        public string naziv;
        public string naslov;

        public Picerija()
        {
            this.seznam = new List<Narocilo>();
            this.stalna_ponudba = new List<Pica>();
        }

        public Picerija(string naziv, string naslov)
        {
            this.seznam = new List<Narocilo>();
            this.stalna_ponudba = new List<Pica>();
            this.naslov = naslov;
            this.naziv = naziv;
        }

        public double OddajNarocilo(Narocilo narocilo)
        {
            if(narocilo.datum_narocila != null && narocilo.naslov_dostave != null && narocilo.Id > 0)
            {
                seznam.Add(narocilo);
            }
            else
            {
                throw new IzjemaNarocilo("Pomanjaknje podatkov!");
            }


            return narocilo.IzracunajCeno();
        }

        public List<Pica> IsciPice(double cena)
        {
            List<Pica> temp = new List<Pica>();

            foreach(Pica pica in stalna_ponudba)
            {
                if(pica.cena <= cena)
                {
                    temp.Add(pica);
                }
            }

            return temp;
        }

        public List<Pica> IsciPice(TipPice tipPice)
        {
            List<Pica> temp = new List<Pica>();

            foreach (Pica pica in stalna_ponudba)
            {
                if (pica.tipPice == tipPice)
                {
                    temp.Add(pica);
                }
            }

            return temp;
        }

        public Pica PicaDneva()
        {
            Random random = new Random();
            int stevilo = random.Next(0, stalna_ponudba.Count - 1);
            return stalna_ponudba[stevilo];
        }

        public void IzpisiPonudbo(string fileName)
        {
            foreach (Pica pica in stalna_ponudba)
            {
                System.IO.File.AppendAllText(fileName, "(" + pica.sestavine + ") " + pica.cena + " " + pica.tipPice + Environment.NewLine);
            }
        }
    }
}
