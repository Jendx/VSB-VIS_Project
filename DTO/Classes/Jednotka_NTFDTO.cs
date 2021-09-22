using System;
using System.Collections.Generic;
using System.Text;


namespace DTO.Structs
{
    public class Jednotka_NTFDTO
    {
        public string nazev { get; set; }
        public int pocetClenu { get; set; }

        public List<UctyDTO> clenove = new List<UctyDTO>();

        public string vybaveni { get; set; }

        public string popis { get; set; }

        public int ID_jednotky { get; set; }

        public bool dostupnost { get; set; }

        public string typMise { get; set; }
    }
}
