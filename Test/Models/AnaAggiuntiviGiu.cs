using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaAggiuntiviGiu
    {
        public decimal KeyDatiaggpersgiuri { get; set; }
        public decimal IdDatiaggpersgiuri { get; set; }
        public string FlgTipoSocieta { get; set; }
        public string FlgFormaSocieta { get; set; }
        public string FlgAttivita { get; set; }
        public decimal? NumeroDipendenti { get; set; }
        public decimal? NumeroIscrizioneCciaa { get; set; }
        public DateTime? DtIscrizioneCciaa { get; set; }
        public decimal? IdProvincia { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? CapitaleSociale { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string OggettoSociale { get; set; }
        public string CodStrutturaOspedaliera { get; set; }
        public string SubcodStrutturaOspedaliera { get; set; }
        public string CodStrutturaIntOspedaliera { get; set; }
        public int? IdNazione { get; set; }
    }
}
