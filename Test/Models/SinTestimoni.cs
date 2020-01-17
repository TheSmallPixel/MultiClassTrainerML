using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinTestimoni
    {
        public decimal KeyTestimone { get; set; }
        public decimal? IdTestimone { get; set; }
        public string NoteTestimonianza { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdEntitacoinvolta { get; set; }
        public DateTime? DtPervenimentoTestimonianza { get; set; }
        public DateTime? DtRichiestaTestimonianza { get; set; }
    }
}
