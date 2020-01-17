using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolTestataAttestati
    {
        public int KeyPolTestata { get; set; }
        public int IdPolTestata { get; set; }
        public int IdPolVeicolo { get; set; }
        public int IdPolizza { get; set; }
        public DateTime? DataElaborazione { get; set; }
        public string ClasseCu { get; set; }
        public string ClasseCompProvenienza { get; set; }
        public string ClasseCompAssegnazione { get; set; }
        public decimal? ImpFrancNonCorrisposte { get; set; }
        public int? NFrancNonCorrisposte { get; set; }
        public int? NumSinPenalizzanti { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgPejus { get; set; }
        public string FlgLegge40Sino { get; set; }
        public DateTime? DtInizioOsservazione { get; set; }
        public DateTime? DtFineOsservazione { get; set; }
        public int? NumSinOsservati { get; set; }
        public string ClasseCuProvenienza { get; set; }
        public DateTime? DtScadPolEvoluzione { get; set; }
        public DateTime? DtElaborazioneWise { get; set; }
        public string CodiceIur { get; set; }
    }
}
