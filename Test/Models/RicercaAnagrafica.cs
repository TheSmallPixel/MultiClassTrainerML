using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RicercaAnagrafica
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
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgPubblicaSino { get; set; }
        public string FlgBloccataSino { get; set; }
        public string NoteBlocco { get; set; }
        public decimal? KeyIndirizzo { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Localita { get; set; }
        public decimal? IdResidenza { get; set; }
        public string Descrizione { get; set; }
        public decimal? IdProvincia { get; set; }
        public string CodProvincia { get; set; }
    }
}
