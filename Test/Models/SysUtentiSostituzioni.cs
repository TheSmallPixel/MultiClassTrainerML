using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysUtentiSostituzioni
    {
        public int IdUtenteSostituzione { get; set; }
        public int IdUtenteIndisponibilita { get; set; }
        public string FlgTipoSostituzione { get; set; }
        public int? IdUtenteSostituto { get; set; }
        public DateTime? DtAnnullamento { get; set; }
        public int? IdUtenteInserimento { get; set; }
    }
}
