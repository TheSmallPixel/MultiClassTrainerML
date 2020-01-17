using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QuiLogQuietanze
    {
        public QuiLogQuietanze()
        {
            QuiLinee = new HashSet<QuiLinee>();
            QuiProdotti = new HashSet<QuiProdotti>();
            QuiRami = new HashSet<QuiRami>();
            QuiReteVendita = new HashSet<QuiReteVendita>();
        }

        public decimal IdQuiLogQuietanza { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime? DtSysElaborazione { get; set; }
        public string FlgTipoElaborazione { get; set; }
        public DateTime? DtQuietanzamento { get; set; }
        public string FlgTipoQuietanzamento { get; set; }
        public string FlgRinnovoSino { get; set; }
        public string FlgInfrannualiSino { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgStatoElaborazione { get; set; }
        public string FlgStampatoBatchSino { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
        public virtual ICollection<QuiLinee> QuiLinee { get; set; }
        public virtual ICollection<QuiProdotti> QuiProdotti { get; set; }
        public virtual ICollection<QuiRami> QuiRami { get; set; }
        public virtual ICollection<QuiReteVendita> QuiReteVendita { get; set; }
    }
}
