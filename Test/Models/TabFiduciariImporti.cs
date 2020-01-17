using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFiduciariImporti
    {
        public int KeyFiduciariImporti { get; set; }
        public int IdFiduciariImporti { get; set; }
        public int IdTipoincaricofiduciario { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public decimal? FasciaImportoDal { get; set; }
        public decimal? FasciaImportoAl { get; set; }
        public decimal? Percentuale { get; set; }
        public decimal? Importo { get; set; }
        public decimal? ImportoMinimo { get; set; }
        public string FlgRamoTecnico { get; set; }
    }
}
