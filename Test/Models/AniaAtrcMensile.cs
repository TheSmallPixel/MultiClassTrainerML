using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcMensile
    {
        public int KeyAniaAtrcMensile { get; set; }
        public int IdAniaAtrcMensile { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string CodImpresaMittente { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public string OraInizioElaborazione { get; set; }
        public int? PrgRecord { get; set; }
        public string TipoRecordTestata { get; set; }
        public string CodFlusso { get; set; }
        public string CodImpresaDestinataria { get; set; }
        public string TipoRecord { get; set; }
        public string CodImpresa { get; set; }
        public string MeseRilevazione { get; set; }
        public string TipoVeicolo { get; set; }
        public int? NAttestatiRischio { get; set; }
        public string FlgControlloMovimenti { get; set; }
        public string StringaAnomalie { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
    }
}
