using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class SCP_Objekt
    {
        public int cislo { get; set; }
        public string prezdivka { get; set; }
        public int proverka { get; set; }
        public tridy_SCP_objektu trida { get; set; }

        public int zaznam_id { get; set; }
    }
}
