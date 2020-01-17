using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dp2Dossier
    {
        public decimal KeyDp2Dossier { get; set; }
        public decimal IdDp2Dossier { get; set; }
        public string FlgLetteraAdesioneSino { get; set; }
        public string FlgLetteraNominaSino { get; set; }
        public string FlgLetteraComodatoSino { get; set; }
        public string FlgLetteraContribuzioneSino { get; set; }
        public string FlgInpsSino { get; set; }
        public string FlgIvaSino { get; set; }
        public string FlgCcaaSino { get; set; }
        public string FlgCurriculumSino { get; set; }
        public string FlgCertificazioneSino { get; set; }
        public string FlgPianoContribuzioneSino { get; set; }
        public string FlgValutazioneSino { get; set; }
        public string NoteLetteraAdesione { get; set; }
        public string NoteLetteraNomina { get; set; }
        public string NoteLetteraComodato { get; set; }
        public string NoteLetteraContribuzione { get; set; }
        public string NoteInps { get; set; }
        public string NoteIva { get; set; }
        public string NoteCcaa { get; set; }
        public string NoteCurriculum { get; set; }
        public string NoteCertificazione { get; set; }
        public string NotePianoContribuzione { get; set; }
        public string NoteValutazione { get; set; }
        public DateTime? DtPianoContribuzione { get; set; }
        public DateTime? DtCertificazione { get; set; }
        public DateTime? DtContribuzione { get; set; }
        public decimal? Rating { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
    }
}
