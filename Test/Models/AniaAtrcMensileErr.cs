using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrcMensileErr
    {
        public int KeyAniaAtrcMensileErr { get; set; }
        public int IdAniaAtrcMensileErr { get; set; }
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
        public string CodErrore { get; set; }
        public string DescrizioneErrore { get; set; }
        public string TipoErrore { get; set; }
    }
}
