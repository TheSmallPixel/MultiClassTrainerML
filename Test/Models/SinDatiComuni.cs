using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinDatiComuni
    {
        public int KeySinDatiComuni { get; set; }
        public int IdSinDatiComuni { get; set; }
        public int? IdCompagnia { get; set; }
        public DateTime? DtScarico { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgRamoBilancio { get; set; }
        public string FlgTipoDelega { get; set; }
        public decimal? PercNostraQuota { get; set; }
        public string NSinistro { get; set; }
        public DateTime? DtAccadimento { get; set; }
        public string FlgTipoGestione { get; set; }
        public string EstremiContraente { get; set; }
        public string EstremiAssicurato { get; set; }
        public string NPolizza { get; set; }
        public string NFlotta { get; set; }
        public DateTime? DtEffPolizza { get; set; }
        public string CodProvIvass { get; set; }
        public string CodRegioneIvass { get; set; }
        public string Settore { get; set; }
        public string Classe { get; set; }
        public string Uso { get; set; }
        public string FlgCardNaturale { get; set; }
        public string CodAgenzia { get; set; }
        public int? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? AnnoEsercizio { get; set; }
        public string CodRamo { get; set; }
        public string CodProdotto { get; set; }
        public string CodTariffa { get; set; }
        public decimal? PercRespRca { get; set; }
        public string FlgDirezioneEsteroSino { get; set; }
        public string FlgRamoTecnico { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string CodSettoreIvass { get; set; }
        public string FlgTardivoSino { get; set; }
    }
}
