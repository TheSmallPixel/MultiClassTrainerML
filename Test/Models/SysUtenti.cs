using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtenti
    {
        public SysUtenti()
        {
            SysMenuPreferiti = new HashSet<SysMenuPreferiti>();
            SysUtentiPassword = new HashSet<SysUtentiPassword>();
        }

        public decimal IdUtente { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime? DtInizioValidita { get; set; }
        public DateTime? DtFineValidita { get; set; }
        public decimal IdLingua { get; set; }
        public DateTime? DtUltimaLogin { get; set; }
        public decimal? NumeroTentativiLogin { get; set; }
        public decimal? NumeroMinutiScaAccErr { get; set; }
        public string FlgAccountDisabilitatoSino { get; set; }
        public DateTime DtUltimaImpostazionePwd { get; set; }
        public string FlgTipoRuoloUtente { get; set; }
        public decimal IdAppartenenza { get; set; }
        public decimal? NumeroTentativiErrati { get; set; }
        public DateTime? DtLoginErrata { get; set; }
        public string FlgLetturaFacDgSino { get; set; }
        public string FlgCanaleEmissione { get; set; }
        public string FlgInibisciCambioPwdSino { get; set; }
        public string RiferimentoSso { get; set; }

        public virtual SysLingue IdLinguaNavigation { get; set; }
        public virtual ICollection<SysMenuPreferiti> SysMenuPreferiti { get; set; }
        public virtual ICollection<SysUtentiPassword> SysUtentiPassword { get; set; }
    }
}
