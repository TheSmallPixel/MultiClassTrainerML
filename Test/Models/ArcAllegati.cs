using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcAllegati
    {
        public decimal IdAllegato { get; set; }
        public long PrgAllegato { get; set; }
        public string NomeAllegato { get; set; }
        public string Note { get; set; }
        public int? PrgFascicolo { get; set; }
        public string FlgTipoOggetto { get; set; }
        public int? IdOggetto { get; set; }
        public int? IdModello { get; set; }
        public int? IdUtente { get; set; }
        public int? LivelloVisibilita { get; set; }
        public string MetadatiXml { get; set; }
        public int? PrgArchiviazione { get; set; }
        public string PrgArchiviazioneEsterno { get; set; }
        public string FlgMacroTipologiaAllegato { get; set; }
        public string FlgTipologiaAllegato { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int KeyAllegato { get; set; }
        public string MetadatoReport { get; set; }
        public string FlgFirmaGrafoSino { get; set; }
        public string NumRepertorioFirmaGrafo { get; set; }
        public string FlgStatoFirmaGrafo { get; set; }
        public string FlgSistemaPostalizzazione { get; set; }
        public string FlgTipoPostalizzazione { get; set; }
        public string DtGenFlussoPostalizzazione { get; set; }
        public string FlgStatoPostalizzazione { get; set; }
        public DateTime? DtStatoPostalizzazione { get; set; }
        public DateTime? DtAccettaPostalizzazione { get; set; }
        public string FilePostalizzazione { get; set; }
        public int? PrgStampa { get; set; }
        public int? IdUtenteInserimento { get; set; }
        public int? IdCompagnia { get; set; }
        public string NRaccomandata { get; set; }
        public int? KeyIndirizzoSpedizione { get; set; }
        public string FlgInviatoDocumentaleSino { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public DateTime? DtComunicazionePortale { get; set; }
        public string FlgStatoComunicazione { get; set; }
        public DateTime? DtInvioDocumentale { get; set; }
        public string FlgProvenienza { get; set; }
    }
}
