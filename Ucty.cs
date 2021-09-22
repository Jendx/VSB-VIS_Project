using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Ucty
    {
        public string login { get; set; }
        public string heslo { get; set; }

        public int ID_pracovnika { get; set; }
        public int proverka { get; set; }
        public string pozice { get; set; }
        public string jmeno { get; set; }

        public string tym { get; set; }

        public int nadrizenyPracovnik_id { get; set; }

        public string nazevJednotky { get; set; }

        public int prirazeneSCP { get; set; }

        public int cisloOblasti { get; set; }
    }
}
