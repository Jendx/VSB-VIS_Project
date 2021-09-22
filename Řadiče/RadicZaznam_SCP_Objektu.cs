using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.TableDataGateways;
using DTO.Structs;

namespace BusinessLayer.Řadiče
{
    public class RadicZaznam_SCP_Objektu
    {
        CastToSCPIS cast = new CastToSCPIS();
        public void save(Zaznam_SCP_Objektu ZSCPO)
        {
            Zaznam_SCP_ObjektuDTO ZSCPODTO = cast.castZSCPOToZSCPODTO(ZSCPO);

            Zaznam_SCP_ObjektuGW.Instance.Update(ZSCPODTO);

        }
    }
}
