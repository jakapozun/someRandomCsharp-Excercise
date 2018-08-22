using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            Picerija picerija1 = new Picerija("Test", "Ulica 3");

            Pica klasika = new Pica("testo,paradiznik,sir,gobe,sunka", TipPice.mesna, 7);
            Pica margerita = new Pica();
            margerita.cena = 6;
            margerita.sestavine = "testo,paradiznik,sir";
            margerita.tipPice = TipPice.vegi;

            Pica morska = new Pica("testo,paradiznik,sir,gobe,skoljko", TipPice.vegi, 7);
            Pica siri4 = new Pica("testo,paradiznik,sir,sir2,sir3,sir4", TipPice.vegi, 7);
            Pica gorska = new Pica("testo,paradiznik,sir,gobe,sunka,kozorog", TipPice.mesna, 15);

            picerija1.stalna_ponudba.Add(klasika);
            picerija1.stalna_ponudba.Add(margerita);
            picerija1.stalna_ponudba.Add(morska);
            picerija1.stalna_ponudba.Add(siri4);
            picerija1.stalna_ponudba.Add(gorska);
            //konc 2

            //4.a
            List<Pica> test_pica = picerija1.IsciPice(6);
            foreach(Pica pica in test_pica)
            {
                Console.WriteLine(pica.sestavine + " " + pica.tipPice + " " + pica.cena);
                System.IO.File.AppendAllText("text.txt", "naloga 4.a" + Environment.NewLine + pica.sestavine + " " + pica.tipPice + " " + pica.cena + Environment.NewLine);
            }

            
            //4.d
            Narocilo novo_narocilo = new Narocilo();
            novo_narocilo.datum_narocila = new DateTime();
            novo_narocilo.narocene_pice.Add(morska);
            novo_narocilo.naslov_dostave = "Reka";
            novo_narocilo.Id = 1;

            Console.WriteLine("novo narocilo" + picerija1.OddajNarocilo(novo_narocilo));

            System.IO.File.AppendAllText("text.txt", "naloga 4.d" + Environment.NewLine + "novo narocilo" + picerija1.OddajNarocilo(novo_narocilo) + Environment.NewLine);

            //4.b
            List<Pica> mesne = picerija1.IsciPice(TipPice.mesna);
            foreach(Pica pica in mesne)
            {
                Console.WriteLine(pica.sestavine + " " + pica.tipPice + " " + pica.cena);
                System.IO.File.AppendAllText("text.txt", "naloga 4.b" + Environment.NewLine + pica.sestavine + " " + pica.tipPice + " " + pica.cena + Environment.NewLine);
            }

            //4.c
            Pica pica_dneva = picerija1.PicaDneva();
            Console.WriteLine(pica_dneva.cena + pica_dneva.sestavine + pica_dneva.tipPice);
            System.IO.File.AppendAllText("text.txt", "naloga 4.c" + Environment.NewLine + pica_dneva.cena + pica_dneva.sestavine + pica_dneva.tipPice + Environment.NewLine);

            //6
            picerija1.IzpisiPonudbo("ponudba.txt");
            Console.WriteLine("konc");
            Console.ReadKey();
        }
    }
}
