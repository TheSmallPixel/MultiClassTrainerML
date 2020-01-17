using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SiniQzV3
    {
        public decimal? Esercizio { get; set; }
        public string AgeSini { get; set; }
        public string NumSini { get; set; }
        public string Esito { get; set; }
        public decimal? ImpLiqu { get; set; }
        public decimal? CodCoass { get; set; }
        public DateTime? DtAvv { get; set; }
        public DateTime? DtPervDen { get; set; }
        public string NumPol { get; set; }
        public decimal? TipoDanno { get; set; }
        public string TpRespQz { get; set; }
        public decimal? RespPerc { get; set; }
        public DateTime? DtPrimoPag { get; set; }
        public string FlPen { get; set; }
        public decimal? Repertorio { get; set; }
        public string FlCd { get; set; }
        public string RamoSin { get; set; }
        public decimal? Franchigia { get; set; }
        public DateTime? DtFranchigia { get; set; }
        public string Targa { get; set; }
        public int? IdSinistro { get; set; }
    }
}
