using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class DocDocumentoVenditori
    {
        public decimal IdDocDocumentovenditore { get; set; }
        public string FlgTipoVenditore { get; set; }
        public decimal? IdDocDocumento { get; set; }
        public DateTime? DtInizioVal { get; set; }
        public DateTime? DtFineVal { get; set; }
    }
}
