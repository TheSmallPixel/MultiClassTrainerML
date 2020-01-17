using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaRivalseCtt
    {
        public int KeyAniaRivalsaCtt { get; set; }
        public int IdAniaRivalsaCtt { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public DateTime? DtAbbinamento { get; set; }
        public string CodErrore { get; set; }
        public string CodImpresaMittente { get; set; }
        public string CodImpresaDestinataria { get; set; }
        public DateTime? DtInizioElaborazione { get; set; }
        public int? OraInizioElaborazione { get; set; }
        public string ProgressivoRecord { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public string CodImpresaRicorrente { get; set; }
        public string FormIdentVeicRicorrente { get; set; }
        public string IdentVeicRicorrente { get; set; }
        public string TipoVeicRicorrente { get; set; }
        public string CodImpresaControint { get; set; }
        public string FormIdentVeicControint { get; set; }
        public string IdentVeicControint { get; set; }
        public string TipoVeicControint { get; set; }
        public string ProvAccadimentoSinistro { get; set; }
        public string IdentSinistroRicorrente { get; set; }
        public string IdentPartitaRicorrente { get; set; }
        public string IdentSinistroControint { get; set; }
        public string IdentPartitaControint { get; set; }
        public string CodFiscaleDanneggiato { get; set; }
        public int? NumVeicoliCoinvolti { get; set; }
        public string AssenzaCollisioni { get; set; }
        public string AssenzaCoperturaSic { get; set; }
        public string SuperamentoPlafond { get; set; }
        public decimal? RespRicorrente { get; set; }
        public decimal? RespControint { get; set; }
        public string TipologiaFunzione { get; set; }
        public string StatoPratica { get; set; }
        public string Classificazione { get; set; }
        public string Convenzione { get; set; }
        public int? ProtocolloPratica { get; set; }
        public string RiferimentoAnia { get; set; }
        public DateTime? DtCreazionePratica { get; set; }
        public DateTime? DtChiusuraPratica { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public string RuoloImpresa { get; set; }
        public decimal? ImpRivalsa { get; set; }
        public decimal? ImpDirittiGestione { get; set; }
        public decimal? ImpRivalsaContabilizzato { get; set; }
        public decimal? ImpRiservaResidua { get; set; }
        public string TipoPagamento { get; set; }
        public string TipoImporto { get; set; }
        public string CodImpRicorrenteAss { get; set; }
        public string CodImpControintAss { get; set; }
        public string IdentStanzaRivalse { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public string FlgStatoRivalsa { get; set; }
        public DateTime? DtStanza { get; set; }
    }
}
