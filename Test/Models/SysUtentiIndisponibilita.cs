using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiIndisponibilita
    {
        public int IdUtenteIndisponibilita { get; set; }
        public int IdUtente { get; set; }
        public DateTime? DtIndisponibileDa { get; set; }
        public DateTime? DtIndisponibileA { get; set; }
        public string FlgMotivoIndisponibilita { get; set; }
        public string NoteIndisponibilita { get; set; }
        public DateTime? DtSysInserimento { get; set; }
        public DateTime? DtSysModifica { get; set; }
        public int? IdUtenteInserimento { get; set; }
        public int? IdUtenteModifica { get; set; }
        public string FlgAnnullatoSino { get; set; }
    }
}
