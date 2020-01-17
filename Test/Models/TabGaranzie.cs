using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabGaranzie
    {
        public decimal KeyGaranzia { get; set; }
        public decimal? IdGaranzia { get; set; }
        public decimal? IdProdotto { get; set; }
        public string CodGaranzia { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgBeneficiarioMorteSino { get; set; }
        public string FlgTipoSinistro { get; set; }
        public string FlgRichiestaCoinvolto { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgRichiestaFurtoSino { get; set; }
        public string Descrizione { get; set; }
        public string FlgSelAperturaSxSino { get; set; }
        public string FlgRischioRiass { get; set; }
        public string FlgPrestazioniInfTipo { get; set; }
        public string FlgTipoSchedaDanno { get; set; }
        public string FlgSezione { get; set; }
        public string FlgLdaSino { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgTipoMassimalizzazione { get; set; }
        public int? NPrestErogabiliAnnuali { get; set; }
        public string FlgCreaIncaricoSino { get; set; }
        public string FlgRichiediDatiCciSino { get; set; }
        public string FlgRamoSolvency { get; set; }
    }
}
