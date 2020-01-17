using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysProfili
    {
        public SysProfili()
        {
            SysAbilitazioniFunz = new HashSet<SysAbilitazioniFunz>();
            SysAbilitazioniProcessi = new HashSet<SysAbilitazioniProcessi>();
            SysAbilitazioniProd = new HashSet<SysAbilitazioniProd>();
            SysUtentiProfili = new HashSet<SysUtentiProfili>();
        }

        public decimal IdProfilo { get; set; }
        public string CodProfilo { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Note { get; set; }
        public decimal? IdProfiloSuperiore { get; set; }
        public string FlgTipoRuoloUtenteVis { get; set; }
        public decimal? IdAppartenenzaVis { get; set; }
        public string FlgTrattaDatiSensibiliSino { get; set; }
        public string Descrizione { get; set; }
        public string FlgAbilScadPolCrusSino { get; set; }

        public virtual ICollection<SysAbilitazioniFunz> SysAbilitazioniFunz { get; set; }
        public virtual ICollection<SysAbilitazioniProcessi> SysAbilitazioniProcessi { get; set; }
        public virtual ICollection<SysAbilitazioniProd> SysAbilitazioniProd { get; set; }
        public virtual ICollection<SysUtentiProfili> SysUtentiProfili { get; set; }
    }
}
