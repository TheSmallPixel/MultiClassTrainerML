using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysDebug
    {
        public int IdUtente { get; set; }
        public string Timestamp { get; set; }
        public string FlgTipoDebug { get; set; }
        public string Metodo { get; set; }
        public string Messaggio1 { get; set; }
        public string Messaggio2 { get; set; }
        public string FlgTipoApplicazione { get; set; }
        public string PathApplicazione { get; set; }
        public string VersioneApp { get; set; }
        public string VersioneCombcl { get; set; }
        public string VersioneClassibase { get; set; }
        public string VersioneCombclbase { get; set; }
        public string VersioneEntitybase { get; set; }
        public string VersioneOmnidb { get; set; }
        public DateTime? DtCompilazioneApp { get; set; }
        public DateTime? DtCompilazioneCombcl { get; set; }
        public DateTime? DtCompilazioneClassibase { get; set; }
        public DateTime? DtCompilazioneCombclbase { get; set; }
        public DateTime? DtCompilazioneEntitybase { get; set; }
        public DateTime? DtCompilazioneOmnidb { get; set; }
    }
}
