using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCompagnie
    {
        public TabCompagnie()
        {
            ArcEstrazAlboAgenti = new HashSet<ArcEstrazAlboAgenti>();
            QuiLogQuietanze = new HashSet<QuiLogQuietanze>();
            SysJob = new HashSet<SysJob>();
            SysParametri = new HashSet<SysParametri>();
            SysProcessiCompagnie = new HashSet<SysProcessiCompagnie>();
            TabConvenzioni = new HashSet<TabConvenzioni>();
        }

        public decimal IdCompagnia { get; set; }
        public decimal? IdCompagniegruppo { get; set; }
        public string CodCompagniaAnia { get; set; }
        public string CodCompagniaIsvap { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string FlgTipoCompagnia { get; set; }
        public DateTime? DtInizioAttivita { get; set; }
        public DateTime? DtFineAttivita { get; set; }
        public DateTime? DtLiquidazioneCoatta { get; set; }
        public string FlgAdesioneCard { get; set; }
        public decimal? IdCompAcquirente { get; set; }
        public DateTime? DtInizioAdesioneCard { get; set; }
        public DateTime? DtFineAdesioneCard { get; set; }
        public string RamiBilancioAmmessi { get; set; }

        public virtual ICollection<ArcEstrazAlboAgenti> ArcEstrazAlboAgenti { get; set; }
        public virtual ICollection<QuiLogQuietanze> QuiLogQuietanze { get; set; }
        public virtual ICollection<SysJob> SysJob { get; set; }
        public virtual ICollection<SysParametri> SysParametri { get; set; }
        public virtual ICollection<SysProcessiCompagnie> SysProcessiCompagnie { get; set; }
        public virtual ICollection<TabConvenzioni> TabConvenzioni { get; set; }
    }
}
