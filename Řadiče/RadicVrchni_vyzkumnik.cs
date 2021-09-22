using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.TableDataGateways;
using DTO.Structs;

namespace BusinessLayer.Řadiče
{
    public class RadicVrchni_vyzkumnik
    {
        CastToSCPIS cast = new CastToSCPIS();
        List<Vrchni_výzkumnikDTO> VVDTO = new List<Vrchni_výzkumnikDTO>();
        List<Vrchni_výzkumnik> VV = new List<Vrchni_výzkumnik>();

        public List<Vrchni_výzkumnik> LoadAll()
        {
            VV.Clear();

            VVDTO = Vrchni_výzkumnikGW.Instance.getVVfromDB("SELECT * FROM Vrchni_vyzkumnik");
            

            
            foreach(var vvdto in VVDTO)
            {
                VV.Add(cast.castVVDTOToVV(vvdto));
            }

            VVDTO.Clear();
            return VV;
        }

        public void UpdateDB(List<Vrchni_výzkumnik> VV)
        {
            
            foreach (var vv in VV)
            {
                VVDTO.Add(cast.castVVToVVDTO(vv));
            }

            Vrchni_výzkumnikGW.Instance.Update(VVDTO);
            
            VVDTO.Clear();



        }
    }
}
