using System;
using System.Collections.Generic;
using System.Text;


namespace DTO.Structs
{
    public class Spravce_OblastiDTO : Vrchni_výzkumnikDTO
    {
        public List<int> seznamVV { get; set; }
        public List<int> seznamSCPO { get; set; }
        public List<int> pracovnici { get; set; }


    }
}
