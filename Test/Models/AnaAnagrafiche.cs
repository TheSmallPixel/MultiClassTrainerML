using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AnaAnagrafiche
    {
        public decimal KeyAnagrafica { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string Nome { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public DateTime? DtNascita { get; set; }
        public decimal? IdComune { get; set; }
        public DateTime? DtCostituzione { get; set; }
        public DateTime? DtDecesso { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgSesso { get; set; }
        public string FlgTitoloOnorifico { get; set; }
        public string Cognome { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string Note { get; set; }
        public decimal? IdLingua { get; set; }
        public decimal? IdDatiaggpersfisica { get; set; }
        public decimal? IdDatiaggpersgiuri { get; set; }
        public decimal? IdDatiprivacy { get; set; }
        public decimal? IdSottogruppo { get; set; }
        public string FlgRamoAttivita { get; set; }
        public string FlgSettorizzazioneSintetica { get; set; }
        public string IdEsternoAnagrafica { get; set; }
        public string FlgPubblicaSino { get; set; }
        public string FlgBloccataSino { get; set; }
        public string NoteBlocco { get; set; }
        public string MatricolaAlboAgenti { get; set; }
        public string MatricolaRui { get; set; }
        public DateTime? DtIscrizioneRui { get; set; }
        public string MatricolaFondoPensione { get; set; }
        public string FlgAdesioneContIntegrSino { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgEntePubblicoSino { get; set; }
        public string FlgPremessaOnorifica { get; set; }
        public string FlgAdesioneFondoPensSino { get; set; }
        public string FlgRichIscrizioneRuiSino { get; set; }
        public DateTime? DtRichiestaIscrizioneRui { get; set; }
        public decimal? IdNazioneIdentFiscale { get; set; }
    }
}
