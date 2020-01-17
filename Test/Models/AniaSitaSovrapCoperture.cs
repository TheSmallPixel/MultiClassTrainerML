using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSitaSovrapCoperture
    {
        public int KeyAniaSitaSovrapCop { get; set; }
        public int IdAniaSitaSovrapCop { get; set; }
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
        public string FormatoIdentVeic { get; set; }
        public string IdentificativoVeic { get; set; }
        public string TipoVeicolo { get; set; }
        public string RuoloImpDestFlusso { get; set; }
        public string CasisticaRilevata { get; set; }
        public string InsCodImpresa { get; set; }
        public string InsIdentFiscaleContr { get; set; }
        public string InsIdentFiscaleProp { get; set; }
        public string InsTipoMovimento { get; set; }
        public string InsCausaleMovimento { get; set; }
        public DateTime? InsDtEffettoCopertura { get; set; }
        public string InsOraEffettoCop { get; set; }
        public DateTime? InsDtScadenzaCopertura { get; set; }
        public DateTime? InsDtScadenzaMora { get; set; }
        public string InsNPolizza { get; set; }
        public DateTime? InsDtUltimoAgg { get; set; }
        public string InsOrarioScadenzaCop { get; set; }
        public string SovCodImpresa { get; set; }
        public string SovIdentFiscaleContr { get; set; }
        public string SovIdentFiscaleProp { get; set; }
        public string SovTipoMovimento { get; set; }
        public string SovCausaleMovimento { get; set; }
        public DateTime? SovDtEffettoCopertura { get; set; }
        public string SovOraEffettoCop { get; set; }
        public DateTime? SovDtScadenzaCopertura { get; set; }
        public DateTime? SovDtScadenzaMora { get; set; }
        public string SovNPolizza { get; set; }
        public DateTime? SovDtUltimoAgg { get; set; }
        public string SovOrarioScadenzaCop { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public string CodIurNuovoInserimento { get; set; }
        public string CodIurSovrapposto { get; set; }
        public string TipoRecord { get; set; }
        public string InsProtocollo { get; set; }
        public string InsTipoVeicoloMctc { get; set; }
        public string InsOraScadenzaMora { get; set; }
        public string SovProtocollo { get; set; }
        public string SovFormatoIdentVeic { get; set; }
        public string SovIdentificativoVeic { get; set; }
        public string SovTipoVeicolo { get; set; }
        public string SovTipoVeicoloMctc { get; set; }
        public string SovOraScadenzaMora { get; set; }
    }
}
