using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysFunzioni
    {
        public int IdFunzione { get; set; }
        public string Codice { get; set; }
        public string DisabilitataDefault { get; set; }
        public string CodiceParametroEccezioni { get; set; }
        public string ModuloWise { get; set; }
        public string MacroFunzioneWise { get; set; }
        public string DescrizioneFunzione { get; set; }
        public string FlgInserimentoUtenteSino { get; set; }
    }
}
