using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaAtrdNotifTardivi
    {
        public int KeyAniaAtrdNotifTardivi { get; set; }
        public int IdAniaAtrdNotifTardivi { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string Testata { get; set; }
        public string TipoRecord { get; set; }
        public string CodImpresa { get; set; }
        public string CodIur { get; set; }
        public string NSinistro { get; set; }
        public string TipologiaSinistroPrecedente { get; set; }
        public int? PctResponsabilitaPrecedente { get; set; }
        public string TipologiaSinistro { get; set; }
        public int? PctResponsabilita { get; set; }
        public DateTime? DtAvvenimentoSinistro { get; set; }
        public DateTime? DtDenunciaSinistro { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public DateTime? DtPagamentoSinistro { get; set; }
        public DateTime? DtAggiornamentoSinistro { get; set; }
        public string FormatoIdentVeicolo { get; set; }
        public string IdentVeicolo { get; set; }
        public string TipoVeicolo { get; set; }
        public string NPolizza { get; set; }
        public DateTime? DtScadenzaContratto { get; set; }
        public string FormaTariffaria { get; set; }
        public string IdentFiscaleContr { get; set; }
        public string IdentFiscaleAventeDiritto { get; set; }
        public string TipologiaAventeDiritto { get; set; }
        public string IdentSinistroAnia { get; set; }
        public string CodImpresaDestinataria { get; set; }
        public string ProtocolloSita { get; set; }
        public DateTime? DtVerificaCoperturaWise { get; set; }
        public string FlgCopertoWiseSino { get; set; }
    }
}
