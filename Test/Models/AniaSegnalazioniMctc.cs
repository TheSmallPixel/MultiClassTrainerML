using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSegnalazioniMctc
    {
        public int KeySegnalazMctc { get; set; }
        public int IdSegnalazMctc { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string CodImpresa { get; set; }
        public string FormatoIdentVeic { get; set; }
        public string IdentificativoVeic { get; set; }
        public string TipoVeic { get; set; }
        public string TipoVeicMctc { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public DateTime? DtEffettoCopertura { get; set; }
        public string OrarioDecorrenzaCop { get; set; }
        public DateTime? DtScadenzaCopertura { get; set; }
        public string OrarioScadenzaCop { get; set; }
        public string IdentFiscaleContr { get; set; }
        public string IdentFiscaleProp { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtEffettoPolizza { get; set; }
        public DateTime? DtScadenzaPolizza { get; set; }
        public string CognomeRagSocialeContr { get; set; }
        public string NomeContr { get; set; }
        public string CognomeRagSocialeProp { get; set; }
        public string NomeProp { get; set; }
        public string EsitoElaborazione { get; set; }
        public string FlgControlloMovimenti { get; set; }
        public string StringaAnomalie { get; set; }
        public string ProtocolloAniaNuovaCop { get; set; }
        public string TipoAggiornamento { get; set; }
        public string TipoVeicErrMctc { get; set; }
        public DateTime? DtRicezioneFlusso { get; set; }
        public string OraRicezioneFlusso { get; set; }
        public string TimestampValidazione { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
    }
}
