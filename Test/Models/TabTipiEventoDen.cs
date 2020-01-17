using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiEventoDen
    {
        public TabTipiEventoDen()
        {
            SinEventi = new HashSet<SinEventi>();
            StoEventi = new HashSet<StoEventi>();
        }

        public decimal IdTipoEventoDen { get; set; }
        public string CodTipoEventoDen { get; set; }
        public decimal IdCompagnia { get; set; }
        public decimal IdDescrizione { get; set; }
        public string FlgRichiediAutoritaSino { get; set; }
        public string FlgRichiediEntiSino { get; set; }
        public string FlgRichiediTestimoniSino { get; set; }
        public string FlgRichiediPatrocinSino { get; set; }
        public string FlgRichiediCaiSino { get; set; }
        public string FlgRecuperiRatealiSino { get; set; }
        public string RamiBilancioAmmessi { get; set; }
        public string Descrizione { get; set; }
        public string FlgRichiediMediatoreSino { get; set; }
        public string FlgLettSurrSino { get; set; }
        public string FlgIncRecAutSino { get; set; }
        public string FlgRichiediTanRateSino { get; set; }
        public string FlgRichiediNDataPrestSino { get; set; }
        public string FlgLettErediSino { get; set; }
        public string FlgBloccoStessiDatiSino { get; set; }
        public string FlgRichiediLuogoSino { get; set; }
        public string FlgRichiediOraSino { get; set; }
        public string FlgRichiediPrevReManSino { get; set; }
        public string FlgSistemaProvenienza { get; set; }

        public virtual ICollection<SinEventi> SinEventi { get; set; }
        public virtual ICollection<StoEventi> StoEventi { get; set; }
    }
}
