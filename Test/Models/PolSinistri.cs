using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistri
    {
        public decimal KeyPolSinistro { get; set; }
        public decimal? IdPolSinistro { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdPolizza { get; set; }
        public string NSinistro { get; set; }
        public string ChiaveEsternaSinistro { get; set; }
        public decimal IdUtente { get; set; }
        public decimal? TotRiservaPersone { get; set; }
        public decimal? TotRiservaCose { get; set; }
        public decimal? TotRiservaSpese { get; set; }
        public DateTime? DtConsideratoAttestato { get; set; }
        public DateTime? DtConsideratoCompagnia { get; set; }
        public DateTime? DtAccadimento { get; set; }
        public DateTime? DtRegistrazione { get; set; }
        public decimal? AnnoSinistro { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoDenuncia { get; set; }
        public string FlgTipoCard { get; set; }
        public string FlgStatoSinistro { get; set; }
        public string FlgMotivoStatoSinistro { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public string FlgLineaProdotto { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
