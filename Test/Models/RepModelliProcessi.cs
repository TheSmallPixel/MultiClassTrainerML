using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepModelliProcessi
    {
        public int IdModelloprocesso { get; set; }
        public int IdModello { get; set; }
        public int IdProcesso { get; set; }
        public string ParametroOutput { get; set; }
        public string FlgIgnoraErrStampaSino { get; set; }
        public int OrdineEsecuzione { get; set; }
    }
}
