using System;
using System.Collections.Generic;
using System.Text;
using DTO.Structs;
using DataLayer.TableDataGateways;
using System.Text.Json;

namespace BusinessLayer.Řadiče
{
    public class RadicSpravce_Oblasti
    {
        public List<Spravce_Oblasti> Spravci = new List<Spravce_Oblasti>();

        public void SaveAllSpravce_Oblasti()
        {
            List<Spravce_OblastiDTO> SODTO = new List<Spravce_OblastiDTO>();

            CastToSCPIS cast = new CastToSCPIS();
            foreach (var s in Spravci)
            {
                SODTO.Add(cast.castSOToSODTO(s));     
            }

            SpravceOblastiGW.Instance.SaveAll(SODTO);

        }
        public List<Spravce_Oblasti> LoadAllSpravce_Oblasti()
        {
            List<Spravce_OblastiDTO> SODTO = new List<Spravce_OblastiDTO>();

            SODTO = SpravceOblastiGW.Instance.load(SODTO);
            
            CastToSCPIS cast = new CastToSCPIS();
            List<Spravce_Oblasti> so = new List<Spravce_Oblasti>();

            foreach(var s in SODTO)
            {
                so.Add(cast.castSODTOToSO(s));
            }

            return so;

        }

    }
}
