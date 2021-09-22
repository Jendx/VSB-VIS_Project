using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Řadiče
{
    public class RadicJednotka_NTF
    {
        public int pocetJednotek { get; set; }
        public List<Jednotka_NTF> NTF = new List<Jednotka_NTF>();
        #region NTF
        public void Add(Jednotka_NTF jednotka)
        {
            NTF.Add(jednotka);
            pocetJednotek++;
        }

        public void Remove(Jednotka_NTF jednotka)
        {
            NTF.Remove(jednotka);
            pocetJednotek--;
        }

        public Jednotka_NTF getJednotku(int ID)
        {
            for (int i = 0; i < NTF.Count; i++)
            {
                if (NTF[i].ID_jednotky == ID)
                {
                    return this.NTF[i];
                }
            }
            return null;
        }
        #endregion
    }
}
