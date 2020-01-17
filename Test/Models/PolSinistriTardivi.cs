using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolSinistriTardivi
    {
        public int KeyPolSinTardivo { get; set; }
        public int? IdPolSinTardivo { get; set; }
        public int? IdAniaAtrdNotifTardivi { get; set; }
        public string CodiceIur { get; set; }
        public string TargaAnia { get; set; }
        public string CodCompagniaGestione { get; set; }
        public string NSinistroGestione { get; set; }
        public DateTime? DtPagamentoSin { get; set; }
        public int? PercResponsabilita { get; set; }
        public int? IdPolizza { get; set; }
        public int? IdPolTestata { get; set; }
        public DateTime? DtInizioOsservazione { get; set; }
        public DateTime? DtFineOsservazione { get; set; }
        public string FlgMalusSino { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
    }
}
