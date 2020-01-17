using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MsaEstrazAllegatiSin
    {
        public int IdMsaEstrazAllegatiSin { get; set; }
        public int IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int IdAllegato { get; set; }
        public string PathImmagine { get; set; }
        public string NumeroSinistro { get; set; }
        public string Idpartitadanno { get; set; }
        public string Scanondemand { get; set; }
        public string Datatimbroricezione { get; set; }
        public string DataCaricamento { get; set; }
        public string NominativoPartita { get; set; }
        public string RuoloPartita { get; set; }
        public string CodFiscPIva { get; set; }
        public string Targa { get; set; }
        public string TipoVeicolo { get; set; }
        public string CslSinistro { get; set; }
        public string CodCompagnia { get; set; }
        public string RamoBilancio { get; set; }
        public string NumeroPolizza { get; set; }
        public string DataAvvenimento { get; set; }
        public string StatoSinistro { get; set; }
        public string DataStato { get; set; }
        public string CslPartita { get; set; }
        public string LuogoSinistro { get; set; }
        public string RifUci { get; set; }
        public string RifMandante { get; set; }
        public string Idmacrotipologia { get; set; }
        public string Idorigine { get; set; }
        public string UfficioDestinatario { get; set; }
        public string Keydoc { get; set; }
        public string OriginaleCopia { get; set; }
        public string Keyjob { get; set; }
        public string PvProv { get; set; }
        public string CodLiq { get; set; }
        public string NominativoLiq { get; set; }
        public string NumFirme { get; set; }
        public string Notifica { get; set; }
        public string Iddocumentale { get; set; }
        public string Idwise { get; set; }
        public string Operazione { get; set; }
        public DateTime DtElaborazione { get; set; }
        public string DtScadenza { get; set; }
        public int PrgElaborazioneGiorno { get; set; }
        public int IdCompagnia { get; set; }
    }
}
