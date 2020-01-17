using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CardContrasti1f
    {
        public int IdCardContrasto1f { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdCompagnia { get; set; }
        public int? IdIspettorato { get; set; }
        public int? IdLiquidatore { get; set; }
        public int? IdFunzioneSinistro { get; set; }
        public DateTime? DtEvento { get; set; }
        public string CodAniaCompCtp { get; set; }
        public string TargaAssicurato { get; set; }
        public string TargaCtp { get; set; }
        public string FlgRagioneTorto { get; set; }
        public string FlgRagioneTortoCtp { get; set; }
        public string FlgRagioneTortoAnia { get; set; }
        public string FlgDebitoreGestionario { get; set; }
        public string FlgEsitoContrastoCard2017 { get; set; }
        public string FlgTipoOggetto { get; set; }
        public DateTime? DtInvioFlusso { get; set; }
        public DateTime? DtContrasto { get; set; }
        public DateTime? DtDefinizioneContrasto { get; set; }
        public DateTime? DtElaborazione { get; set; }
        public string FlgTipoCardAnia { get; set; }
        public int? IdCinquinaCard { get; set; }
    }
}
