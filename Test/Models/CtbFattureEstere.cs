using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CtbFattureEstere
    {
        public int KeyFatturaEstera { get; set; }
        public int IdFatturaEstera { get; set; }
        public int IdSinistro { get; set; }
        public DateTime DataFattura { get; set; }
        public string FlgTipoFattura { get; set; }
        public decimal? ImportoDanniPersone { get; set; }
        public decimal? SpeseResistenza { get; set; }
        public decimal? SpeseLiquidazione { get; set; }
        public decimal? ImportoDannoMateriale { get; set; }
        public decimal? ImportoRicarico { get; set; }
        public string Note { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? IdUtente { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScaricoContabilita { get; set; }
        public string NumFattura { get; set; }
        public string FlgStatoContabile { get; set; }
        public decimal? DiCuiOnorari { get; set; }
        public decimal? ImpContabilizzato { get; set; }
    }
}
