using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSitaCopertureErr
    {
        public int KeyAniaSitaCopErr { get; set; }
        public int IdAniaSitaCopErr { get; set; }
        public int IdAniaSitaCopInvii { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string CodErrore { get; set; }
        public string DescrizioneErrore { get; set; }
        public string TipoErrore { get; set; }
        public string ProtocolloAniaNuovaCop { get; set; }
        public string TipoAggiornamento { get; set; }
        public string ProtocolloAniaMovErr { get; set; }
    }
}
