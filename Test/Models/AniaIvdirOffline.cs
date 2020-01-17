using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaIvdirOffline
    {
        public int KeyAniaIvdirOffline { get; set; }
        public int IdAniaIvdirOffline { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string ProtocolloAnia { get; set; }
        public string CodImpresa { get; set; }
        public string FormatoIdentVeic { get; set; }
        public string IdentificativoVeicolo { get; set; }
        public string TipoVeicolo { get; set; }
        public DateTime? DataAvvenimento { get; set; }
        public DateTime? DataMaxRisposta { get; set; }
        public string FlgRispostaOffline { get; set; }
        public DateTime? DataUltimaRisposta { get; set; }
        public string FlussoRicevuto { get; set; }
        public string FlgStato { get; set; }
        public int IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgAssicuratoSino { get; set; }
    }
}
