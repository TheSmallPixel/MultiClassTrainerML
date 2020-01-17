using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepAttivazioneReportCc
    {
        public int IdRepAttivazioneReportCc { get; set; }
        public int IdRepAttivazioneReport { get; set; }
        public string FlgRuolo { get; set; }
        public int FlgImportanza { get; set; }
        public string FlgTipoRecapitoPreselezione { get; set; }
    }
}
