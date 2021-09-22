using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Structs
{
    public class SCP_ObjektDTO
    {
        public int cislo { get; set; }
        public string prezdivka { get; set; }
        public int proverka { get; set; }

        public tridy_SCP_objektuDTO trida;

        public int zaznam_id { get; set; }
    }
}
