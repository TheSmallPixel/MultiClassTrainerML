using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinSinistriRca
    {
        public decimal KeySinistrorca { get; set; }
        public decimal? IdCasocid { get; set; }
        public decimal? PerResponsabilita { get; set; }
        public string NoteMotivoDepenalizzazione { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal IdSinistrorca { get; set; }
        public string FlgDepenalizzatoSino { get; set; }
        public string FlgTipoCard { get; set; }
        public string FlgFirmaCai { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdCasocidTerzo { get; set; }
        public string FlgCollisioneSino { get; set; }
        public DateTime? DtRichiestaArbitrato { get; set; }
        public DateTime? DtAperturaArbitrato { get; set; }
        public DateTime? DtChiusuraArbitrato { get; set; }
        public string FlgStanza { get; set; }
        public string FlgForzaturaRcaSino { get; set; }
        public decimal? IdProvForfait { get; set; }
        public DateTime? DtStatoCard { get; set; }
        public string FlgMotivoForzatura { get; set; }
        public string FlgDichiarazione { get; set; }
        public string FlgArbitratoCreatoSino { get; set; }
        public string FlgArbitratoInCaricoSino { get; set; }
        public string NoteArbitrato { get; set; }
        public string FlgTipoCardCompagnia { get; set; }
        public string FlgTipoResponsabilita { get; set; }
        public string FlgInviareSino { get; set; }
        public int? IdProvForfaitCtp { get; set; }
        public decimal? PerRespCompagnia { get; set; }
        public string FlgCausaleDepenalizzazione { get; set; }
        public string FlgClassificazioneNa { get; set; }
        public string FlgAssenzaDannoSino { get; set; }
        public string FlgCardNaturaleSino { get; set; }
        public string FlgRecordAnnullatoSino { get; set; }
    }
}
