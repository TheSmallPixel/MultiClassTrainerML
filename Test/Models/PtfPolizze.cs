using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PtfPolizze
    {
        public decimal KeyPolizza { get; set; }
        public decimal IdPolizza { get; set; }
        public DateTime DtEffettoPolizza { get; set; }
        public DateTime DtScaPolizza { get; set; }
        public DateTime? DtScaRata { get; set; }
        public DateTime? DtAnnullamentoPolizza { get; set; }
        public string NPolizzaCoass { get; set; }
        public DateTime? DtEffettoRataCopertura { get; set; }
        public DateTime? DtScaRataCopertura { get; set; }
        public DateTime? DtPagRataCopertura { get; set; }
        public DateTime? DtFcRataCopertura { get; set; }
        public string NFcRataCopertura { get; set; }
        public decimal IdProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgPtfPolizza { get; set; }
        public string FlgTipoCoass { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal IdCompagnia { get; set; }
        public string NPolizza { get; set; }
        public decimal IdRetevendita { get; set; }
        public string NFlotta { get; set; }
        public string IdEsternoPtf { get; set; }
        public string NProposta { get; set; }
        public decimal? IdPolizzaAltriDati { get; set; }
        public string CodProduttore { get; set; }
        public string NPolizzaSostituita { get; set; }
        public string NPolizzaSostituente { get; set; }
        public DateTime? DtFcRataCoperturaMan { get; set; }
        public string NFcRataCoperturaMan { get; set; }
        public string NoteForzaturaScoperto { get; set; }
        public DateTime? DtEffettoCopProvvisoria { get; set; }
        public DateTime? DtScaMora { get; set; }
        public DateTime? DtIniAnnualAss { get; set; }
        public DateTime? DtFinAnnualAss { get; set; }
        public DateTime? DtSospensionePolizza { get; set; }
        public DateTime? DtProdotto { get; set; }
        public string As400 { get; set; }
        public string Edizione { get; set; }
        public string FlgMotivoAnnullamento { get; set; }
        public string FlgFrazionamento { get; set; }
        public string FlgVisibilitaDipendentiSino { get; set; }
        public string NumPolEsteso { get; set; }
        public string FlgTipoPtf { get; set; }
    }
}
