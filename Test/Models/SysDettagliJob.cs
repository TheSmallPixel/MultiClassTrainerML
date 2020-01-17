using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysDettagliJob
    {
        public SysDettagliJob()
        {
            SysLogJob = new HashSet<SysLogJob>();
        }

        public decimal IdDettaglioJob { get; set; }
        public decimal IdJob { get; set; }
        public DateTime DtInizioElaborazione { get; set; }
        public DateTime? DtFineElaborazione { get; set; }
        public string Parametri { get; set; }
        public decimal? PidSistemaOperativo { get; set; }
        public string NomeSistemaOperativo { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public string FlgVerificatoSino { get; set; }
        public string FlgSchedulatoSino { get; set; }
        public string Note { get; set; }
        public int? IdUtente { get; set; }

        public virtual SysJob IdJobNavigation { get; set; }
        public virtual ICollection<SysLogJob> SysLogJob { get; set; }
    }
}
