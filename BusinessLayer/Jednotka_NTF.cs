using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Jednotka_NTF
    {
        public string nazev { get; set; }
        public int pocetClenu { get; set; }

        public List<Ucty> clenove = new List<Ucty>();

        public string vybaveni { get; set; }

        public string popis { get; set; }

        public int ID_jednotky { get; set; }

        public bool dostupnost { get; set; }

        public string typMise { get; set; }

        public void vyslat(Spravce_Oblasti spravce, string typMise)
        {
            this.typMise = typMise;
            Console.WriteLine($"Jednotka {this.nazev}. Byla vyslána na misi: {this.typMise}");
            dostupnost = false;
        }

        public void navrat()
        {
            Console.WriteLine($"Jednotka {this.nazev}. se vrátila z mise: {this.typMise}");
            dostupnost = true;
        }
    }
}
