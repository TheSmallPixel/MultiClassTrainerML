using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysMenu
    {
        public SysMenu()
        {
            SysAbilitazioniMenu = new HashSet<SysAbilitazioniMenu>();
            SysMenuPreferiti = new HashSet<SysMenuPreferiti>();
        }

        public decimal IdMenuprocedura { get; set; }
        public decimal Ordine { get; set; }
        public string NomeProdottoIsuite { get; set; }
        public string Url { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string FlgTipoMenu { get; set; }
        public string FlgTipoNodo { get; set; }
        public string FlgEspansoSino { get; set; }
        public string Icona { get; set; }
        public decimal? IdDescrizioneFunzionalita { get; set; }
        public string FlgMenuProtettoSino { get; set; }
        public string FlgSystemSino { get; set; }
        public string FlgCambioLinguaSino { get; set; }
        public string FlgCambioValutaSino { get; set; }
        public string Descrizione { get; set; }
        public string DescrizioneFunzionalita { get; set; }
        public string FlgDisabilitaCacheSino { get; set; }
        public int? CodOperazionePtf { get; set; }

        public virtual ICollection<SysAbilitazioniMenu> SysAbilitazioniMenu { get; set; }
        public virtual ICollection<SysMenuPreferiti> SysMenuPreferiti { get; set; }
    }
}
