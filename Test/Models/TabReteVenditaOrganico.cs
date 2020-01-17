using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVenditaOrganico
    {
        public int KeyRetevenditaOrganico { get; set; }
        public int IdRetevenditaOrganico { get; set; }
        public int? IdAnagraficatitolare { get; set; }
        public string FlgRuoloOrganicoAgenzia { get; set; }
        public int? IdOrganicoriferimento { get; set; }
        public DateTime? DtInizioRapporto { get; set; }
        public DateTime? DtFineRapporto { get; set; }
        public string FlgTipoCollaboratore { get; set; }
        public int? IdCompagniaprincipale { get; set; }
        public int? IdAltracompagnia { get; set; }
        public int? IdCompagniaprovenienza { get; set; }
        public string FlgTipoSedeLavoro { get; set; }
        public int? IdIndirizzo { get; set; }
        public string FlgMotivoCessazioneRapporto { get; set; }
        public string FlgPosizioneEliminataSino { get; set; }
        public int IdRetevendita { get; set; }
        public string Note { get; set; }
        public DateTime? DtRatifica { get; set; }
        public DateTime? DtRevocaRatifica { get; set; }
        public string FlgBenevisoSino { get; set; }
        public DateTime? DtBeneviso { get; set; }
        public DateTime? DtRevocaBeneviso { get; set; }
        public string FlgPianoClrSino { get; set; }
        public DateTime? DtInizioPianoClr { get; set; }
        public DateTime? DtFinePianoClr { get; set; }
        public int? IdUtente { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string FlgAxaCampus { get; set; }
        public string FlgDpmiSino { get; set; }
        public DateTime? DtAxaCampus { get; set; }
    }
}
