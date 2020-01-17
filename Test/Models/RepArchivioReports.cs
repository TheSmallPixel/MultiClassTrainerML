using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepArchivioReports
    {
        public RepArchivioReports()
        {
            RepDistribuzioneReports = new HashSet<RepDistribuzioneReports>();
        }

        public decimal IdArchivioReport { get; set; }
        public decimal? IdUtenteCreatore { get; set; }
        public DateTime? DtProduzione { get; set; }
        public decimal? IdModello { get; set; }
        public string UrlDocumento { get; set; }
        public string EtichettaDocumento { get; set; }
        public string Note { get; set; }
        public decimal? IdFormatoReport { get; set; }
        public decimal? DimensioneReport { get; set; }
        public decimal? IdAllegato { get; set; }

        public virtual ICollection<RepDistribuzioneReports> RepDistribuzioneReports { get; set; }
    }
}
