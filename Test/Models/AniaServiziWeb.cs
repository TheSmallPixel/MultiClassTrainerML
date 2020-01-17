using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaServiziWeb
    {
        public int IdAniaServiziWeb { get; set; }
        public int? IdSinistro { get; set; }
        public string RiferimentoAnia { get; set; }
        public string ProtocolloPratica { get; set; }
        public string TipologiaFunzione { get; set; }
        public string StatoPratica { get; set; }
        public string Classificazione { get; set; }
        public string RuoloImpresa { get; set; }
        public string CodImpresaRicorrente { get; set; }
        public string FormIdentVeicRicorrente { get; set; }
        public string IdentVeicRicorrente { get; set; }
        public string TipoVeicRicorrente { get; set; }
        public string CodImpresaControint { get; set; }
        public string FormIdentVeicControint { get; set; }
        public string IdentVeicControint { get; set; }
        public string TipoVeicControint { get; set; }
        public DateTime? DtAccadimentoSinistro { get; set; }
        public DateTime? DtCreazione { get; set; }
        public DateTime? DtUltimoCambioStato { get; set; }
        public string IdentRicorrente { get; set; }
        public string IdentControint { get; set; }
        public int? IdEntitacoinvolta { get; set; }
        public int? IdFlussoCard { get; set; }
        public string CodFiscaleDanneggiato { get; set; }
        public int? IdCardServizioWeb { get; set; }
    }
}
