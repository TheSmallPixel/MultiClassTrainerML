using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabRespTerr
    {
        public decimal KeyResponsabileTerr { get; set; }
        public decimal IdResponsabileTerr { get; set; }
        public string CodResponsabileTerr { get; set; }
        public decimal IdAreaCommerciale { get; set; }
        public decimal IdAnagrafica { get; set; }
        public decimal IdIndirizzo { get; set; }
        public DateTime DtResponsabileDal { get; set; }
        public string NumTelefono1 { get; set; }
        public string NumTelefono2 { get; set; }
        public string NumTelefono3 { get; set; }
        public string NumSelezioneDiretta { get; set; }
        public string NumFax { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public DateTime? DtResponsabileAl { get; set; }
    }
}
