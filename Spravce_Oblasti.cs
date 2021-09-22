using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Spravce_Oblasti : Vrchni_výzkumnik
    {
        public List<int> seznamVV = new List<int>();
        public List<int> seznamSCPO = new List<int>();
        public List<int> pracovnici = new List<int>();

        public Spravce_Oblasti(Ucty vyz) : base(vyz)
        {
            vyz.pozice = "Spravce oblasti";
        }
        public Vrchni_výzkumnik jmenovat(Vyzkumnik vyz, int proverka)
        {
            Vrchni_výzkumnik povysenyV = new Vrchni_výzkumnik(vyz.vedec);
            povysenyV.vedec.pozice = "Vrchni výzkumník";
            povysenyV.vedec.proverka = proverka;
            return povysenyV;
        }

        public void priradKSCP(Vyzkumnik vyz, int SCP)
        {
            vyz.vedec.prirazeneSCP = SCP;
        }

        public void povoleni(Vyzkumnik vyzk)
        {
            // Chcete udělit povolení? jaké...
        }

        public void spravaUctu(Ucty ucty, int ucetID)
        {
            //Ucty ucet = ucty.getUcet(ucetID);

            //Co chete udělat s učtem? WFA
        }

        public void OtevreniZaznamuSCP(Zaznam_SCP_Objektu zaznam)
        {
            Console.WriteLine(zaznam.textZaznamu);
        }
    }
}
