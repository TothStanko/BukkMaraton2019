using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    class Versenytav
    {
        public string Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public string Ido { get; set; }
        public string Tav
        {
            get
            {
                switch (Rajtszam[0])
                {
                    case 'M': return "Mini";
                    case 'R': return "Rövid";
                    case 'K': return "Közép";
                    case 'H': return "Hosszú";
                    case 'E': return "Pedelec";
                }
                return "Hibás rajtszám";
            }
        }
        public Versenytav(string rajtszam)
        {
            Rajtszam = rajtszam;
            List<string> read = rajtszam.Split(";").ToList();

            Rajtszam = read[0];
            Kategoria = read[1];
            Nev = read[2];
            Egyesulet = read[3];  
            Ido = read[4];


        }

        public override string ToString()
        {
            return $"Rajtszám: {Rajtszam} \nKategória: {Kategoria} \nNév: {Nev} \nEgyesület: {Egyesulet} \nIdő: {Ido}";
        }

    }

}


