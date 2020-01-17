using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepAttivazioneReportDest
    {
        public int IdRepAttivazioneReportDest { get; set; }
        public int IdRepAttivazioneReport { get; set; }
        public string FlgRuolo { get; set; }
        public int FlgImportanza { get; set; }
        public string FlgTipoRecapitoPreselezione { get; set; }
    }
}
