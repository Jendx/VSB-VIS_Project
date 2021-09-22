using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer.TableDataGateways;
using DTO.Structs;


namespace BusinessLayer.Řadiče
{
    public class RadicUctu // řadič na čtení a nahrávání z Data Layeru
    {
        CastToSCPIS cast = new CastToSCPIS();

        #region Ucty
        public void Update(List<Ucty> ucty)
        {
            List<UctyDTO> UDTO = new List<UctyDTO>();
            foreach(var u in ucty)
            {
                UDTO.Add(cast.castUctyToUDTO(u));
            }

            UctyGW.Instance.Update(UDTO);
        }

        public List<Ucty> LoadAll()
        {
            string command = "SELECT login, heslo, ID_pracovnika , proverka, pozice, jmeno, ISNULL(tym, 'N/A') AS tym, ISNULL(nadrizenyPracovnik_id, -10) AS nadrizenyPracovnik_id," +
                            " ISNULL(nazevJednotky, 'N/A') AS nazevJednotky, ISNULL(scp_id, -10) AS scp_id, cisloOblasti  FROM ucty WHERE pozice = 'vyzkumnik'";
            List<Ucty> ucty = new List<Ucty>();
            List<UctyDTO> UDTO = UctyGW.Instance.getUctyFromDB(command);

            
            foreach(var u in UDTO)
            {
                ucty.Add(cast.castUDTOToUcty(u));
            }
            
            return ucty;
        }
        #endregion

    }
}
