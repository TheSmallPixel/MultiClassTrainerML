using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AutosoftParcelle
    {
        public int IdAutosoftparcelle { get; set; }
        public string RifIncaricoautosoft { get; set; }
        public int IdSinistro { get; set; }
        public int IdEntitacoinvolta { get; set; }
        public int IdIncarico { get; set; }
        public string StatoFlusso { get; set; }
        public decimal? Importoperiziaivato { get; set; }
        public decimal? Onorarioard { get; set; }
        public string OnorarioardConf { get; set; }
        public decimal? Onorarioaccertamento { get; set; }
        public string OnorarioaccertamentoConf { get; set; }
        public decimal? Onorariointerlocutorie { get; set; }
        public string OnorariointerlocutorieConf { get; set; }
        public decimal? Onorarioriscontro { get; set; }
        public string OnorarioriscontroConf { get; set; }
        public decimal? Costounitariofoto { get; set; }
        public decimal? Fotoeffettuate { get; set; }
        public decimal? Fotoinfranchigia { get; set; }
        public decimal? Onorarioconcordato { get; set; }
        public string OnorarioconcordatoConf { get; set; }
        public decimal? Onorarioliquidazione { get; set; }
        public string OnorarioliquidazioneConf { get; set; }
        public decimal? SpFoto { get; set; }
        public string SpFotoConf { get; set; }
        public decimal? SpVisura { get; set; }
        public string SpVisuraConf { get; set; }
        public string SpVisuratipoimporto { get; set; }
        public decimal? Aliquotaiva { get; set; }
        public string Contributiprevidenziali { get; set; }
        public decimal? Costounitariokm { get; set; }
        public DateTime? Datachiusura { get; set; }
        public decimal? Imponibileconcassa { get; set; }
        public decimal? Imponibilesenzacassa { get; set; }
        public decimal? Importocassa { get; set; }
        public decimal? Importoiva { get; set; }
        public decimal? Importoritenutaacconto { get; set; }
        public string Autorizzazionepagamento { get; set; }
        public DateTime? Datacreazione { get; set; }
        public DateTime? Datafattura { get; set; }
        public decimal? Idfattura { get; set; }
        public string Numerofattura { get; set; }
        public decimal? Kminfranchigia { get; set; }
        public decimal? Kmpercorsi { get; set; }
        public string Noteparcella { get; set; }
        public decimal? Onorarionegativa { get; set; }
        public string OnorarionegativaConf { get; set; }
        public decimal? Onorarioperizia { get; set; }
        public string OnorarioperiziaConf { get; set; }
        public decimal? PercContributiprevidenziali { get; set; }
        public decimal? Ritenutaacconto { get; set; }
        public decimal? SpKm { get; set; }
        public string SpKmConf { get; set; }
        public string SpKmtipoimporto { get; set; }
        public decimal? SpPostali { get; set; }
        public string SpPostaliConf { get; set; }
        public string SpPostalitipoimporto { get; set; }
        public decimal? SpRaccomandate { get; set; }
        public string SpRaccomandateConf { get; set; }
        public string SpRaccomandatetipoimporto { get; set; }
        public decimal? SpVarieimponibile { get; set; }
        public string SpVarieimponibileConf { get; set; }
        public decimal? SpVarienonimponibile { get; set; }
        public string SpVarienonimponibileConf { get; set; }
        public string Statoautority { get; set; }
        public decimal? TotNonimponibile { get; set; }
        public decimal? TotOnorari { get; set; }
        public decimal? TotParcella { get; set; }
        public decimal? TotParcellaivato { get; set; }
        public decimal? TotParcellanettocassa { get; set; }
        public string TotParcellanettocassaConf { get; set; }
        public decimal? TotParcellanettoritacconto { get; set; }
        public decimal? TotSpImponibili { get; set; }
        public decimal? TotSpNonimponibili { get; set; }
        public decimal? Importocontributiprevidenziali { get; set; }
    }
}
