using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DTO.Structs;
using DataLayer.TableDataGateways;

namespace BusinessLayer.Řadiče
{
    public class RadicSCP_Objekt
    {
        List<SCP_Objekt> SCPO = new List<SCP_Objekt>();
        List<SCP_ObjektDTO> SCPODTO = new List<SCP_ObjektDTO>();
        public int pocetSCP_Objektu { get; set; }

        public List<int> SCPObjekty = new List<int>();

        #region SCP Objekt
        public void Add(int zSCPO)
        {
            SCPObjekty.Add(zSCPO);
        }

        public void Remove(SCP_Objekt zSCPO)
        {

        }

        public List<SCP_Objekt> LoadAll()
        {
            SCPO.Clear();
            SCPODTO.Clear();

            SCPODTO = SCP_ObjektGW.Instance.getSCPOFromDB(
                "SELECT scp_id, prezdivka, ISNULL(zaznam_id, -10) AS zaznam_id, proverka, ISNULL(dodatek_id, -10) AS dodatek_id, (SELECT trida FROM tridy_SCP_Objektu WHERE SCP_Objekt.trida_id = tridy_SCP_Objektu.trida_id)"+  
                "FROM SCP_Objekt"
                    );
            CastToSCPIS cast = new CastToSCPIS();
            foreach(var scpodto in SCPODTO)
            {
                SCPO.Add(cast.castSCPODTOToSCPO(scpodto));
            }
            

            return SCPO;
        }

        #endregion

    }
}
