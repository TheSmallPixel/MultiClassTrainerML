using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSurrogheInps
    {
        public int KeyAniaSurrogaInps { get; set; }
        public int IdAniaSurrogaInps { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public DateTime DtStato { get; set; }
        public string CodImpresaMittente { get; set; }
        public DateTime? DtFlusso { get; set; }
        public string OraFlusso { get; set; }
        public string Progressivo { get; set; }
        public string CodImpresaDestinataria { get; set; }
        public string TipoRecord { get; set; }
        public string Edizione { get; set; }
        public string CodImpresa { get; set; }
        public string NomeDanneggiato { get; set; }
        public string CognomeDanneggiato { get; set; }
        public string CodFiscaleDanneggiato { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public string ResponseCode { get; set; }
        public string ProtocolloPratica { get; set; }
        public DateTime? DtAperturaPratica { get; set; }
        public string ProtocolloEsitoPratica { get; set; }
        public DateTime? DtEsitoPratica { get; set; }
        public DateTime? DtScadenzaRisposta { get; set; }
        public DateTime? DtScadenzaPagImpresa { get; set; }
        public decimal? ImpTotaleSurroga { get; set; }
        public decimal? ImpIndennitaMalattia { get; set; }
        public decimal? ImpInteressiLegali { get; set; }
        public decimal? ImpRivalutazione { get; set; }
        public decimal? ImpSpeseAmministrative { get; set; }
        public string Iban { get; set; }
        public string Causale { get; set; }
        public int? GiorniIndennizzati { get; set; }
        public decimal? ImpTotaleSurrogaPrec { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string Identificativo { get; set; }
        public int? IdUtenteBonifico { get; set; }
        public int? IdIndennizzo { get; set; }
        public string FlgCausaleStato { get; set; }
        public string Note { get; set; }
    }
}
