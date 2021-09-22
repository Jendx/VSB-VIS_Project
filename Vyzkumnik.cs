using System;
using System.Collections.Generic;
using System.Text;
//using VIS_PROJEKT;


namespace BusinessLayer
{
    public class Vyzkumnik
    {
        public Ucty vedec = new Ucty();

        public Zaznam_SCP_Objektu SCPZaznam = new Zaznam_SCP_Objektu();
        public Vyzkumnik()
        {
        }
        public Vyzkumnik(Ucty ucet)
        {
            vedec = ucet;
        }


        public Zaznam_SCP_Objektu vytvorSCPZaznam()
        {
            Zaznam_SCP_Objektu zaznam = new Zaznam_SCP_Objektu();

            //if (vedec.pozice == "Vrchni vyzkumnik" | vedec.pozice == "Spravce oblasti") 
            //    return zaznam;
            //else
            //{

            //    if (odeslatKSchvaleni(vedec.nadrizenyPracovnik) == true)
            //        return zaznam;
            //}
            return null;
        }

        public Zaznam_SCP_Objektu upravSCPZaznam(Zaznam_SCP_Objektu zaznam, string text)
        {
            zaznam.textZaznamu = text;

            return zaznam;
        }

        public Zaznam_SCP_Objektu upravSCPZaznam(Zaznam_SCP_Objektu zaznam, Dodatek dodatek, int cisloDodatku)
        {
            //zaznam.dodatek[cisloDodatku] = dodatek;

            return zaznam;
        }

        public Zaznam_SCP_Objektu upravSCPZaznam(Zaznam_SCP_Objektu zaznam, tridy_SCP_objektu trida)
        {
            //zaznam.trida = trida;

            return zaznam;
        }


        public void setTrida(Zaznam_SCP_Objektu SCPObject, tridy_SCP_objektu trida)
        {
            //SCPObject.trida = trida;
        }

        public void pridatDodatky(Zaznam_SCP_Objektu SCPObject, Dodatek d)
        {
            // SCPObject.dodatek.Add(d);
        }

        public bool odeslatKSchvaleni(Ucty nadr)
        {
            Vrchni_výzkumnik vrchni = new Vrchni_výzkumnik(nadr);
            bool schvalen = vrchni.schvalit(SCPZaznam);
            return schvalen;
        }


    }
}
