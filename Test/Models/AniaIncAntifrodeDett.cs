using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaIncAntifrodeDett
    {
        public int IdAniaIncAntifrodeDett { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdRecupero { get; set; }
        public int? IdAniaSinistroCard { get; set; }
        public int? IdAniaPartitaCard { get; set; }
        public int? IdFlussoCard { get; set; }
        public int? IdSospesoCard { get; set; }
        public DateTime? DtTestata { get; set; }
        public string TipoRecord { get; set; }
        public string TipoMovimento { get; set; }
        public string CausaleMovimento { get; set; }
        public string RuoloImpresa { get; set; }
        public string TipologiaFunzione { get; set; }
        public string StatoPratica { get; set; }
        public string Classificazione { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public string CodImpresaRicorrente { get; set; }
        public string FormatoIdentVeicRicorrente { get; set; }
        public string IdentVeicRicorrente { get; set; }
        public string TipoVeicRicorrente { get; set; }
        public string CodImpresaControint { get; set; }
        public string FormatoIdentVeicControint { get; set; }
        public string IdentVeicControint { get; set; }
        public string TipoVeicControint { get; set; }
        public string ProtocolloPratica { get; set; }
        public string RiferimentoAnia { get; set; }
        public DateTime? DtCreazionePratica { get; set; }
        public DateTime? DtChiusuraPratica { get; set; }
        public decimal? ImpIncentivo { get; set; }
        public string CodImpresaRicorrenteAss { get; set; }
        public string CodImpresaControintAss { get; set; }
        public string IdentificativoStanza { get; set; }
        public string IdentPartitaGestionaria { get; set; }
        public string CodFiscalePartitaGest { get; set; }
        public string NominativoPartitaGest { get; set; }
        public int? IdIndennizzo { get; set; }
    }
}
