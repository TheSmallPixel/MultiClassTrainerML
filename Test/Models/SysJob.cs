using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysJob
    {
        public SysJob()
        {
            SysDettagliJob = new HashSet<SysDettagliJob>();
            SysJobAvvisi = new HashSet<SysJobAvvisi>();
        }

        public decimal IdJob { get; set; }
        public decimal IdProcesso { get; set; }
        public decimal IdCompagnia { get; set; }
        public DateTime? DtSchedulazione { get; set; }
        public decimal? IdJobFiglio { get; set; }
        public decimal IdUtente { get; set; }
        public string FlgPeriodicitaElaborazione { get; set; }
        public string Parametri { get; set; }
        public string FlgSospesoSino { get; set; }
        public DateTime? DtProssimaElaborazione { get; set; }
        public string Note { get; set; }
        public string FlgLunediSino { get; set; }
        public string FlgMartediSino { get; set; }
        public string FlgMercolediSino { get; set; }
        public string FlgGiovediSino { get; set; }
        public string FlgVenerdiSino { get; set; }
        public string FlgSabatoSino { get; set; }
        public string FlgDomenicaSino { get; set; }
        public string FlgGennaioSino { get; set; }
        public string FlgFebbraioSino { get; set; }
        public string FlgMarzoSino { get; set; }
        public string FlgAprileSino { get; set; }
        public string FlgMaggioSino { get; set; }
        public string FlgGiugnoSino { get; set; }
        public string FlgLuglioSino { get; set; }
        public string FlgAgostoSino { get; set; }
        public string FlgSettembreSino { get; set; }
        public string FlgOttobreSino { get; set; }
        public string FlgNovembreSino { get; set; }
        public string FlgDicembreSino { get; set; }
        public decimal? Intervallo { get; set; }
        public string FlgSchedAutomSino { get; set; }
        public string FlgEsecuzioneFiglio { get; set; }
        public string Codice { get; set; }

        public virtual TabCompagnie IdCompagniaNavigation { get; set; }
        public virtual SysProcessi IdProcessoNavigation { get; set; }
        public virtual ICollection<SysDettagliJob> SysDettagliJob { get; set; }
        public virtual ICollection<SysJobAvvisi> SysJobAvvisi { get; set; }
    }
}
