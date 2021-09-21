using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DTO.Structs;

namespace BusinessLayer
{
    public class CastToSCPIS
    {
        #region Spravce Oblasti
        public Spravce_OblastiDTO castSOToSODTO(Spravce_Oblasti so)
        {

            UctyDTO UDTO = castUctyToUDTO(so.vedec);


            Zaznam_SCP_ObjektuDTO ZSCPDTO = castZSCPO_To_ZSCPODTO(so.SCPZaznam);

            Spravce_OblastiDTO SODTO = new Spravce_OblastiDTO
            {
                vedec = UDTO,
                pracovnici = so.pracovnici,
                SCPZaznam = ZSCPDTO,
                seznamSCPO = so.seznamSCPO,
                seznamVV = so.seznamVV,
                vybraniVyzkumnici = so.vybraniVyzkumnici,
            };

            return SODTO;
        }

        public Spravce_Oblasti castSODTOToSO(Spravce_OblastiDTO so)
        {

            Ucty U = castUDTOToUcty(so.vedec);

            Zaznam_SCP_Objektu ZSCP = castZSCPODTO_To_ZSCPO(so.SCPZaznam);

            Spravce_Oblasti SO = new Spravce_Oblasti(U)
            {
                vedec = U,
                pracovnici = so.pracovnici,
                SCPZaznam = ZSCP,
                seznamSCPO = so.seznamSCPO,
                seznamVV = so.seznamVV,
                vybraniVyzkumnici = so.vybraniVyzkumnici,
            };

            return SO;
        }
        #endregion

        #region Ucty
        public UctyDTO castUctyToUDTO(Ucty u)
        {

            UctyDTO UDTO = new UctyDTO
            {

                login = u.login,
                heslo = u.heslo,

                ID_pracovnika = u.ID_pracovnika,
                proverka = u.proverka,
                pozice = u.pozice,
                jmeno = u.jmeno,

                tym = u.tym,
                nadrizenyPracovnik_id = u.nadrizenyPracovnik_id,
                nazevJednotky = u.nazevJednotky,
                prirazeneSCP = u.prirazeneSCP,

                cisloOblasti = u.cisloOblasti

            };
            return UDTO;

        }

        public Ucty castUDTOToUcty(UctyDTO u)
        {

            Ucty Ucty = new Ucty
            {

                login = u.login,
                heslo = u.heslo,

                ID_pracovnika = u.ID_pracovnika,
                proverka = u.proverka,
                pozice = u.pozice,
                jmeno = u.jmeno,

                tym = u.tym,
                nadrizenyPracovnik_id = u.nadrizenyPracovnik_id,
                nazevJednotky = u.nazevJednotky,
                prirazeneSCP = u.prirazeneSCP,

                cisloOblasti = u.cisloOblasti

            };
            return Ucty;

        }
        #endregion

        #region Zaznam SCP objektu
        public Zaznam_SCP_ObjektuDTO castZSCPO_To_ZSCPODTO(Zaznam_SCP_Objektu z)
        {

            Zaznam_SCP_ObjektuDTO ZSCPDTO = new Zaznam_SCP_ObjektuDTO
            {
                cisloZaznamu = z.cisloZaznamu,
                dodatek_id = z.dodatek_id,
                textZaznamu = z.textZaznamu,

            };

            return ZSCPDTO;

        }

        public Zaznam_SCP_Objektu castZSCPODTO_To_ZSCPO(Zaznam_SCP_ObjektuDTO z)
        {

            Zaznam_SCP_Objektu ZSCP = new Zaznam_SCP_Objektu
            {
                cisloZaznamu = z.cisloZaznamu,
                dodatek_id = z.dodatek_id,
                textZaznamu = z.textZaznamu,

            };

            return ZSCP;

        }
        #endregion

        #region Vrchní výzkumník
        public Vrchni_výzkumnikDTO castVVToVVDTO(Vrchni_výzkumnik so)
        {

            UctyDTO UDTO = castUctyToUDTO(so.vedec);

            Vrchni_výzkumnikDTO VVDTO = new Vrchni_výzkumnikDTO
            {
                vedec = UDTO
            };

            return VVDTO;
        }

        public Vrchni_výzkumnik castVVDTOToVV(Vrchni_výzkumnikDTO so)
        {
            Ucty Ucet = castUDTOToUcty(so.vedec);

            Vrchni_výzkumnik VV = new Vrchni_výzkumnik(Ucet)
            {
                vedec = Ucet
            };

            return VV;
        }
        #endregion

        #region SCP Objekt
        public SCP_ObjektDTO castSCPOToSCPODTO(SCP_Objekt so)
        {
            SCP_ObjektDTO SCPODTO = new SCP_ObjektDTO
            {
                cislo = so.cislo,
                prezdivka = so.prezdivka,
                proverka = so.proverka,
                trida = new tridy_SCP_objektuDTO { trida = so.trida.trida },
                zaznam_id = so.zaznam_id
            };

            return SCPODTO;
        }

        public SCP_Objekt castSCPODTOToSCPO(SCP_ObjektDTO so)
        {
            SCP_Objekt SCPO = new SCP_Objekt
            {
                cislo = so.cislo,
                prezdivka = so.prezdivka,
                proverka = so.proverka,
                trida = new tridy_SCP_objektu { trida = so.trida.trida },
                zaznam_id = so.zaznam_id
            };

            return SCPO;
        }
        #endregion

        #region SCP zaznam
        public Zaznam_SCP_ObjektuDTO castZSCPOToZSCPODTO(Zaznam_SCP_Objektu u)
        {

            Zaznam_SCP_ObjektuDTO ZSCPODTO = new Zaznam_SCP_ObjektuDTO
            {
                cisloZaznamu = u.cisloZaznamu,
                dodatek_id = u.dodatek_id,
                proverka = u.proverka,
                textZaznamu = u.textZaznamu,
                trida = u.trida

            };
            return ZSCPODTO;

        }

        public Zaznam_SCP_Objektu castZSCPODTOToZSCPO(Zaznam_SCP_ObjektuDTO u)
        {

            Zaznam_SCP_Objektu ZSCPODTO = new Zaznam_SCP_Objektu
            {
                cisloZaznamu = u.cisloZaznamu,
                dodatek_id = u.dodatek_id,
                proverka = u.proverka,
                textZaznamu = u.textZaznamu,
                trida = u.trida

            };
            return ZSCPODTO;

        }
        #endregion
    }

}

