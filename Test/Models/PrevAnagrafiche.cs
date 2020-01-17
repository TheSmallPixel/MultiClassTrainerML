using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrevAnagrafiche
    {
        public int KeyPrevAnagrafica { get; set; }
        public int IdPrevAnagrafica { get; set; }
        public int IdPolizza { get; set; }
        public string FlgCodRuolo { get; set; }
        public string FlgTipoAnagrafica { get; set; }
        public string CognomeRagioneSociale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public DateTime? DtNascita { get; set; }
        public string FlgSesso { get; set; }
        public int? IdComuneNascita { get; set; }
        public int? IdComuneResidenza { get; set; }
        public int? IdProvinciaResidenza { get; set; }
        public string CapResidenza { get; set; }
        public string FlgProfessione { get; set; }
        public string Indirizzo { get; set; }
        public string FlgTipoRecapito1 { get; set; }
        public string Recapito1 { get; set; }
        public string FlgTipoRecapito2 { get; set; }
        public string Recapito2 { get; set; }
        public int? IdUtente { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgPropContraenteSino { get; set; }
    }
}
