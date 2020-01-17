using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinTrasferimenti
    {
        public int IdTrasferimento { get; set; }
        public int IdSinistro { get; set; }
        public int IdIspettoratoOrigine { get; set; }
        public int? IdLiquidatoreOrigine { get; set; }
        public DateTime? DtTrasferimento { get; set; }
        public DateTime? DtLimite { get; set; }
        public int IdIspettoratoDestinazione { get; set; }
        public int? IdLiquidatoreDestinazione { get; set; }
        public DateTime? DtRestituzione { get; set; }
        public int IdUtenteTrasferimento { get; set; }
        public int? IdUtenteRestituzione { get; set; }
    }
}
