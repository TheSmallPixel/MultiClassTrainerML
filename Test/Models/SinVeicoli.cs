using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinVeicoli
    {
        public decimal IdVeicolo { get; set; }
        public string Targa { get; set; }
        public string Telaio { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public DateTime? DtImmatricolazione { get; set; }
        public string NoteVeicolo { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string FlgTipoVeicoloIsvap { get; set; }
        public string FlgTipoTarga { get; set; }
        public decimal? IdNazione { get; set; }
        public decimal? IdSettore { get; set; }
        public decimal? IdClasse { get; set; }
        public decimal? IdUso { get; set; }
        public string TargaAnia { get; set; }
        public string FlgTipoDemolizione { get; set; }
        public DateTime? DtDemolizione { get; set; }
        public string FlgStatoInvio { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal KeyVeicolo { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int? Cc { get; set; }
        public int? Kw { get; set; }
        public decimal? Qli { get; set; }
        public int? Hp { get; set; }
        public decimal? Posti { get; set; }
        public string Targhino { get; set; }
        public decimal IdSinistro { get; set; }
        public decimal? IdProprietario { get; set; }
        public decimal? IdConducente { get; set; }
        public decimal? IdContraente { get; set; }
        public decimal? IdRimessa { get; set; }
        public string NPolizza { get; set; }
        public string NSinistro { get; set; }
        public decimal? IdCompagnia { get; set; }
        public DateTime? DtInizioCopertura { get; set; }
        public DateTime? DtFineCopertura { get; set; }
        public string CodAgenzia { get; set; }
        public string FlgVeicoloSostaSino { get; set; }
        public string CodInfocar { get; set; }
        public int? IdCorrispondenteestero { get; set; }
        public string FlgRdCvtSino { get; set; }
        public string FlgCondizioniVeicolo { get; set; }
        public int? MesiVetusta { get; set; }
        public string FlgVeicoloDiPolizzaSino { get; set; }
        public string FlgIvaSino { get; set; }
        public string RifCorrispondenteEstero { get; set; }
    }
}
