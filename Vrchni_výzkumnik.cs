using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer
{
    public class Vrchni_výzkumnik : Vyzkumnik
    {
        public List<int> vybraniVyzkumnici = new List<int>();
        public Vrchni_výzkumnik(Ucty vyz) : base(vyz)
        {
            vedec = vyz;
            //vedec.nadrizenyPracovnik_id = vyz.nadrizenyPracovnik_id;
        }

        public bool schvalit(Zaznam_SCP_Objektu zaznam)
        {

            bool schvaleni = false;
            //potvrdit potvrd = new potvrdit($"schválit záznam? {SCPZaznam.cisloZaznamu} \n");

            // schvaleni = potvrd.YN;

            if (schvaleni == true)
                return true;
            else
                return false;
        }

        public void vybratClenyTymu(Ucty vyzkumnik)
        {
            ////AssignMainScientist AMS = new AssignMainScientist();
            //int proverka = vedec.proverka;
            // List<Ucty> vsechnyUcty = new List<Ucty>(vyzkumnik.getVsechnyUcty());
            //// Vypsani všech vyzkumniku 
            //foreach (var v in vsechnyUcty)
            //{
            //    if (v.proverka >= proverka & v.pozice == "Vyzkumnik")
            //    {
            //        //AMS.addItem(v.jmeno, v.proverka);
            //    }
            //}
            //Potvrzeni vybraných výzkumníků
            //vybraniVyzkumnici.Add(5);
        }

        //public void pridatDoDB(Zaznam_SCP_Objektu zaznam, RadicUctu DB)
        //{
        //    //DB.Add(zaznam);
        //}
    }
}
