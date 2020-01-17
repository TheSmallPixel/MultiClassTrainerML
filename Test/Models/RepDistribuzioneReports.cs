using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepDistribuzioneReports
    {
        public decimal IdDistribuzioneReport { get; set; }
        public decimal IdArchivioReport { get; set; }
        public decimal IdUtente { get; set; }

        public virtual RepArchivioReports IdArchivioReportNavigation { get; set; }
    }
}
