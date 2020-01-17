using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class P3AgeProduzione
    {
        public int IdP3AgeProduzione { get; set; }
        public int IdRetevendita { get; set; }
        public int IdP3DatiGenerali { get; set; }
        public DateTime DtDal { get; set; }
        public DateTime DtAl { get; set; }
    }
}
