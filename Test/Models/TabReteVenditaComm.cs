using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaComm
    {
        public decimal KeyRetevenditaComm { get; set; }
        public decimal IdRetevenditaComm { get; set; }
        public decimal? IdRetevenditaAltri { get; set; }
        public decimal? IdDipartimento { get; set; }
        public decimal? IdAreaCommerciale { get; set; }
        public decimal? IdResponsabileGest { get; set; }
        public decimal? IdPromoterVf { get; set; }
        public decimal? IdIspettoreAmm { get; set; }
        public decimal? IdResponsabileTerr { get; set; }
        public decimal? IdIspettorato { get; set; }
        public decimal? IdLiquidatore { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
